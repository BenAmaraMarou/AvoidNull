using BankNull.Business;
using BankNull.Common;

namespace BankNull.Repository
{
    public class CustomerRepositoy
    {
        private readonly IRepositoryProvider _repositoryProvider;

        public CustomerRepositoy(IRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }

        public Maybe<Customer> GetCustomer(int id)
        {
            //BDD....
            var customer = _repositoryProvider.GetCustomer(id);
            if (customer == null)
            {
                return new Maybe<Customer>();
            }
            return new Maybe<Customer>(customer);
        }
    }
}
