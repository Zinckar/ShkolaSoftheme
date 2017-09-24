using System;
using System.Collections.Generic;

namespace MobileOperator
{
    public class Operator : IOperator
    {
        public delegate void Sms(object sender, SmsEventArgs e);
        public delegate void Call(object sender, CallEventArgs e);

        public event Sms SendSMS;
        public event Call MakeCall;

        private List<MobileAccount> RegisteredUsers { get; set; }

        public Operator()
        {
            RegisteredUsers = new List<MobileAccount>();
        }

        public void ProcessCall(string fromNumber, string toNumber)
        {
            if (RegisteredUsers.Find(x => x.Number == fromNumber).Number == null)
            {
                throw new ArgumentException("Sender number is not registered!");
            }
            if (RegisteredUsers.Find(x => x.Number == toNumber).Number == null)
            {
                throw new ArgumentException("Receiver number is not registered!");
            }
            if (fromNumber == toNumber)
            {
                throw new ArgumentException("Sender and Receiver numbers should be different");
            }

            foreach (var user in RegisteredUsers)
            {
                if (user.Number == toNumber)
                {
                    MakeCall += user.ReceiveCall;
                    if (MakeCall != null)
                    {
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
                throw new ArgumentException("Sender number is not registered!");
            }
            if (RegisteredUsers.Find(x => x.Number == toNumber).Number == null)
            {
                throw new ArgumentException("Receiver number is not registered!");
            }
            if (fromNumber == toNumber)
            {
                throw new ArgumentException("Sender and Receiver numbers should be different");
            }

            foreach (var user in RegisteredUsers)
            {
                if (user.Number == toNumber)
                {
                    SendSMS += user.ReceiveSms;
                    if (SendSMS != null)
                    {
                        Console.WriteLine("Processing sms from {0} to {1}", fromNumber, toNumber);
                        SendSMS(this, new SmsEventArgs(fromNumber, text));
                    }
                    SendSMS -= user.ReceiveSms;
                    return;
                }
            }
        }

        public void Register(MobileAccount account)
        {
            if (RegisteredUsers.Exists(x => x.Number == account.Number))
            {
                throw new ArgumentException("User with same number already exist!");
            }
            RegisteredUsers.Add(account);
        }
    }
}