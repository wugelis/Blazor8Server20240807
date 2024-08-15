namespace Domain.Accounts
{
    public class LoginRules
    {
        public LoginType CheckLoginType(string userName)
        {
            return LoginType.Normal;
        }
    }
}

namespace Domain.Accounts
{
    public enum LoginType
    {
        Normal,
        VIP
    }
}