using BankNull.Business;
using BankNull.Repository;

namespace BankNull.Client
{
    public class OperationController
    {
        private readonly AccountOperation _accountOperation;

        public OperationController(IRepositoryProvider repositoryProvider)
        {
            _accountOperation = new AccountOperation(repositoryProvider);
        }


        public void Withdraw(int id, int amout)
        {
            var account = _accountOperation.GetAccount(id);
            _accountOperation.Withdraw(account, amout);
        }
    }
}
