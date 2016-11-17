using System.Linq;
using BankNull.Common;
using BankNull.Repository;

namespace BankNull.Business
{
    public class AccountOperation
    {
        private readonly CustomerProvider _customerService;
        private readonly AccountRepository _accountRepository;

        public AccountOperation(IRepositoryProvider repositoryProvider)
        {
            _customerService = new CustomerProvider(repositoryProvider);
            _accountRepository = new AccountRepository(repositoryProvider);
        }

        public Maybe<Account> GetAccount(int id)
        {
            var customer = _customerService.GetCustomer(id);
            
            //if (customer == null)
            //{
            //    return null;
            //}
            return customer
                .Select(cust => _accountRepository.GetAccount(cust.Reference))
                .FirstOrDefault();
        }

        public void Withdraw(Maybe<Account> account, int amount)
        {
            _accountRepository.Withdraw(account, amount);
        }
    }
}
