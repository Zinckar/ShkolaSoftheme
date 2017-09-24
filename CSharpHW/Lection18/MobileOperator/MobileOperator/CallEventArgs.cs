namespace MobileOperator
{
    public class CallEventArgs
    {
        public string FromNumber { get; set; }

        public CallEventArgs(string fromNumber)
        {
            FromNumber = fromNumber;
        }
    }
}