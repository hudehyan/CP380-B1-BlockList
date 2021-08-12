
namespace CP380_B1_BlockList.Models
{
    public enum TransactionTypes
    {
        BUY, SELL, GRANT
    }

     public class Payload
    {
        public string User { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public int Amount  { get; set; }
        public string Item { get; set; }

        public Payload(string user, TransactionTypes transactionType, int amount, string item)
        {
            this.user = user;
            this.transactionType = transactionType;
            this.amount = amount;
            this.item = item;
        }
}
}