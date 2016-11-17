using BankNull.Business;
using BankNull.Client;
using BankNull.Repository;
using Moq;
using Xunit;

namespace BankNull.Tests
{
    public class BankTests
    {
        private readonly Mock<IRepositoryProvider> _repositoryProviderMock;

        public BankTests()
        {
            _repositoryProviderMock = new Mock<IRepositoryProvider>();
        }

        [Fact]
        public void Should_Withdraw()
        {
            _repositoryProviderMock.Setup(_ => _.GetCustomer(1)).Returns(new Customer(1, "XXX"));
            _repositoryProviderMock.Setup(_ => _.GetAccount("XXX")).Returns(new Account("XXX", 100));
            _repositoryProviderMock.Setup(_ => _.Withdraw("XXX", 30));
            var operationController = new OperationController(_repositoryProviderMock.Object);

            operationController.Withdraw(1, 30);
            
            _repositoryProviderMock.Verify(_=>_.Withdraw("XXX", 30));

        }
    }
}
