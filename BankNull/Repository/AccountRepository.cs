using System.Linq;
using BankNull.Business;
using BankNull.Common;

namespace BankNull.Repository
{
    internal class AccountRepository
    {
        private readonly IRepositoryProvider _repositoryProvider;

        public AccountRepository(IRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }

        public Maybe<Account> GetAccount(string reference)
        {
            //BDD...
            var account = _repositoryProvider.GetAccount(reference);
            if (account == null)
            {
                return new Maybe<Account>();
            }
            return new Maybe<Account>(account);
        }

        public void Withdraw(Maybe<Account> account, int amount)
        {
            if (account.FirstOrDefault()?.Amount >= amount)
            {
                //BDD...
                _repositoryProvider.Withdraw(account.Single().Reference,  amount);
            }
        }
    }
}