using System;
using System.Collections.Generic;

using System.IO;
using System.IO.Compression;


using System.Linq;
using System.Xml.Serialization;

namespace MobileOperator
{
    public class Operator : IOperator
    {
        private const string XmlPath = "../../Data.xml";
        private const string ZipPath = "../../Data.zip";
        public delegate void Sms(object sender, SmsEventArgs e);
        public delegate void Call(object sender, CallEventArgs e);

        public event Sms SendSMS;
        public event Call MakeCall;
        
        public List<MobileAccount> RegisteredUsers { get; set; }
        private readonly List<Activity> _activityHistory = new List<Activity>();

        public Operator(string dataType)
        {
            if (dataType == "xml")
            {
                RegisteredUsers = Deserialize(XmlPath);
            }
            else
            {
                LoadFromZip(ZipPath);
            }


        }

        //public Operator()
        //{
        //    RegisteredUsers = new List<MobileAccount>();
        //}

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
                        _activityHistory.Add(new Activity(fromNumber, toNumber, ActivityType.SMS));
                        Console.WriteLine("Processing SMS from {0} to {1}", fromNumber, toNumber);
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
                num.Count(act => act.Type == ActivityType.Call) + num.Count(act => act.Type == ActivityType.SMS) / 2

            }).OrderByDescending(act => act.CountCall).ToList();

            return a.Select(x => x.Key).Take(5).ToList();
        }




        public void Serialize(List<MobileAccount> list, string xmlPath)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<MobileAccount>));

            using (FileStream fs = new FileStream(xmlPath, FileMode.Create))
            {
                xmlFormatter.Serialize(fs, list);
            }
        }


        private List<MobileAccount> Deserialize(string xmlPath)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<MobileAccount>));

            using (FileStream fs = new FileStream(xmlPath, FileMode.Open))
            {
                return (List<MobileAccount>)xmlFormatter.Deserialize(fs);
            }
        }
        private void LoadFromZip(string path)
        {
            using (ZipArchive archive = ZipFile.OpenRead(path))
            {
                var zipEntry = archive.GetEntry("Data.xml");
                using (var zipEntryStream = zipEntry.Open())
                {
                    using (var ms = new MemoryStream())
                    {
                        zipEntryStream.CopyTo(ms);
                        ms.Position = 0;
                        XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<MobileAccount>));
                        RegisteredUsers = (List<MobileAccount>)xmlFormatter.Deserialize(ms);
                    }
                }
            }
        }
    }
}



