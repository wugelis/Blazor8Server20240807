using Application.Accounts;
using Application.Accounts.Models;

namespace Infrastructure.Accounts
{
    public class AccountRepository : IAccountRepository
    {
        public static List<LoginRequest> Accountdb = new List<LoginRequest>()
        {
                    new LoginRequest() { Username = "Gelis", EMail = "gelis@test.com" },
                    new LoginRequest() { Username = "Allan", EMail = "allan@test.com" },
                    new LoginRequest() { Username = "Mary", EMail = "mary@test.com" }
        };

        public bool AddAccount(LoginRequest account)
        {
            Accountdb.Add(account);
            return true;
        }

        public IEnumerable<LoginRequest> GetAllAcounts()
        {
            var result = Accountdb;

            return result;
        }
    }
}
