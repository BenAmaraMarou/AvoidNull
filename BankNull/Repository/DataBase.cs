using System.Collections.Generic;
using System.Linq;
using BankNull.Business;

namespace BankNull.Repository
{
    public class DataBase : IRepositoryProvider
    {
        private readonly IEnumerable<Customer> _customers;
        private readonly IEnumerable<Account> _accounts;

        public DataBase()
        {
            _customers = new[] {new Customer( 1, "ABCD")};
            _accounts = new []{ new Account("ABCD", 10 )};
        }

        public Customer GetCustomer(int id)
        {
            return _customers.FirstOrDefault(_=>_.Id == id);
        }

        public Account GetAccount(string reference)
        {
            return _accounts.FirstOrDefault(_=>_.Reference == reference);
        }

        public void Withdraw(string reference, int amount)
        {
            _accounts.Single(_ => _.Reference == reference).Withdraw(amount);
        }
    }
}
