using Application.Accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Accounts
{
    public interface IAccountRepository
    {
        IEnumerable<LoginRequest> GetAllAcounts();
        bool AddAccount(LoginRequest account);
    }
}
