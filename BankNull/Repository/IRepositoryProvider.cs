using BankNull.Business;

namespace BankNull.Repository
{
    public interface IRepositoryProvider
    {
        Customer GetCustomer(int id);

        Account GetAccount(string reference);

        void Withdraw(string reference, int amount);
    }
}