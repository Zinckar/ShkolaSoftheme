namespace MobileOperator
{
    public interface IOperator
    {
        void ProcessCall(string fromNumber, string toNumber);

        void ProcessSms(string fromNumber, string toNumber, string text);
    }
}