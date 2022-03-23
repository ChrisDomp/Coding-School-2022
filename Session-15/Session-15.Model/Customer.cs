namespace Session_15.Model
{
    public class Customer : Person
    {

        public string Phone { get; set; }
        public string TIN { get; set; }
        public Guid TransactionID { get; set; }
       // public Transaction Transaction {get; set; }
        public Customer()
        {
            //Transaction = new Transaction();
        }

    }
}
