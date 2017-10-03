using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    public class Operator : IOperator
    {
        private const string ErrMsgSenderNotRegistered = "Sender number is not registered!";
        private const string ErrMsgReceiverNotRegistered = "Receiver number is not registered!";
        private const string ErrMsgEqualNumbers = "Sender and Receiver numbers should be different";
        private const string ErrMsgUserDublicate = "User with same number already exist!";
        public delegate void Sms(object sender, SmsEventArgs e);
        public delegate void Call(object sender, CallEventArgs e);

        public event Sms SendSms;
        public event Call MakeCall;

        private List<MobileAccount> RegisteredUsers { get; }
        private readonly List<Activity> _activityHistory = new List<Activity>();

        public Operator()
        {
            RegisteredUsers = new List<MobileAccount>();
        }

        public void ProcessCall(string fromNumber, string toNumber)
        {
            if (RegisteredUsers.Find(x => x.Number == fromNumber).Number == null)
            {
                throw new ArgumentException(ErrMsgSenderNotRegistered);
            }
            if (RegisteredUsers.Find(x => x.Number == toNumber).Number == null)
            {
                throw new ArgumentException(ErrMsgReceiverNotRegistered);
            }
            if (fromNumber == toNumber)
            {
                throw new ArgumentException(ErrMsgEqualNumbers);
            }

            foreach (var user in RegisteredUsers)
            {
                if (user.Number == toNumber)
                {
                    MakeCall += user.ReceiveCall;
                    if (MakeCall != null)
                    {
                        _activityHistory.Add(new Activity(fromNumber, toNumber, ActivityType.Call));
                        Console.WriteLine("Processing call from {0} to {1}", fromNumber, toNumber);
                        MakeCall(this, new CallEventArgs(fromNumber));
                    }
                    MakeCall -= user.ReceiveCall;
                    return;
                }
            }
        }

        public void ProcessSms(string fromNumber, string toNumber, string text)
        {

            if (RegisteredUsers.Find(x => x.Number == fromNumber).Number == null)
            {
                throw new ArgumentException(ErrMsgSenderNotRegistered);
            }
            if (RegisteredUsers.Find(x => x.Number == toNumber).Number == null)
            {
                throw new ArgumentException(ErrMsgReceiverNotRegistered);
            }
            if (fromNumber == toNumber)
            {
                throw new ArgumentException(ErrMsgEqualNumbers);
            }

            foreach (var user in RegisteredUsers)
            {
                if (user.Number == toNumber)
                {
                    SendSms += user.ReceiveSms;
                    if (SendSms != null)
                    {
                        _activityHistory.Add(new Activity(fromNumber, toNumber, ActivityType.Sms));
                        Console.WriteLine("Processing SMS from {0} to {1}", fromNumber, toNumber);
                        SendSms(this, new SmsEventArgs(fromNumber, text));
                    }
                    SendSms -= user.ReceiveSms;
                    return;
                }
            }
        }

        public void Register(MobileAccount account)
        {
            if (RegisteredUsers.Exists(x => x.Number == account.Number))
            {
                throw new ArgumentException(ErrMsgUserDublicate);
            }
            RegisteredUsers.Add(account);
        }

        public List<string> GetFiveMostCommonNumbers()
        {
            return _activityHistory
                .Where(num => num.Type == ActivityType.Call)
                .GroupBy(num => num.ReceiverNumber)
                .OrderByDescending(num => num.Count())
                .Take(5)
                .Select(num => num.Key).ToList();
        }

        public List<string> GetFiveMostActiveNumbers()
        {
            var a = _activityHistory.GroupBy(num => num.SenderNumber).Select(num => new
            {
                num.Key,
                CountCall =
                num.Count(act => act.Type == ActivityType.Call) + num.Count(act => act.Type == ActivityType.Sms) / 2
            }).OrderByDescending(act => act.CountCall).ToList();

            return a.Select(x => x.Key).Take(5).ToList();
        }
    }
}