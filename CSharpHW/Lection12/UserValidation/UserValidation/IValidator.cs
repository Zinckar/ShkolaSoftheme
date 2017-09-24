namespace UserValidation
{
    public interface IValidator
    {
        bool ValidateUser(IUser user);
    }
}