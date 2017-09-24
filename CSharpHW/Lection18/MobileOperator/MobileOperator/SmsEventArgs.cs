namespace MobileOperator
{
    public class SmsEventArgs
    {
        public string FromNumber { get; set; }

        public string Text { get; set; }

        public SmsEventArgs(string fromNumber, string text)
        {
            FromNumber = fromNumber;
            Text = text;
        }
    }
}