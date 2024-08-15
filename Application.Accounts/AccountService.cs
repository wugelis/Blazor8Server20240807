using Application.Accounts.Models;

namespace Application.Accounts
{
    public class AccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool AddAccount(LoginRequest account)
        {
            return _accountRepository.AddAccount(account);
        }
        public IEnumerable<LoginRequest> GetAccounts()
        {
            return _accountRepository.GetAllAcounts();
        }
    }
}
