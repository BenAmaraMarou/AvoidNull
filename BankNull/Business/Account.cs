namespace BankNull.Business
{
    public class Account
    {
        public string Reference { get;  }
        public int Amount { get; private set; }

        public Account(string reference, int amount)
        {
            Reference = reference;
            Amount = amount;
        }

        public void Withdraw(int amount)
        {
            Amount -= amount;
        }
    }
}