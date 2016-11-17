using BankNull.Common;
using BankNull.Repository;

namespace BankNull.Business
{
    public class CustomerProvider
    {
        private readonly CustomerRepositoy _customerRepositoy;

        public CustomerProvider(IRepositoryProvider repositoryProvider)
        {
            _customerRepositoy = new CustomerRepositoy(repositoryProvider);
        }

        public Maybe<Customer> GetCustomer(int id)
        {
            return _customerRepositoy.GetCustomer(id);
        }
    }
}
