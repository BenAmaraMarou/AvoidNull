namespace BankNull.Business
{
    public class Customer
    {
        public int Id { get; }

        public string Reference { get; }

        public Customer(int id, string reference)
        {
            Id = id;
            Reference = reference;
        }
    }
}
