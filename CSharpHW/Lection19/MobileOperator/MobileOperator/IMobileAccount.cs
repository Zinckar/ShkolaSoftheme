namespace MobileOperator
{
    public interface IMobileAccount
    {
        string Number { get; }

        string Name { get; }

        void MakeCall(string toNumber);

        void SendSms(string toNumber, string text);

        void ReceiveCall(object sender, CallEventArgs e);

        void ReceiveSms(object sender, SmsEventArgs e);

        void AddNumberToAddressBook(User user);
    }
}