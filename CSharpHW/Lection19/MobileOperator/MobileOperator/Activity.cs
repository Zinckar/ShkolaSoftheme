namespace MobileOperator
{
    public class Activity
    {

        public string SenderNumber { get; set; }

        public string ReceiverNumber { get; set; }

        public ActivityType Type { get; set; }

        public Activity(string senderNumber, string receiverNumber, ActivityType type)
        {
            SenderNumber = senderNumber;
            ReceiverNumber = receiverNumber;
            Type = type;
        }
    }
}