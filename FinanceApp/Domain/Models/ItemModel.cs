namespace FinanceApp.Domain.Models
{
    public class ItemModel
    {
        public ItemModel()
        {
            ID = 0;
            Name = "";
            ValuePerUnit = 0.0;
            UnitAmount = 1;
            TransactionDate = DateTime.Now;
            DurationEstimativeDate = DateTime.Now;
            InstalmentAmount = 1;
            IdTransactionType = 1;
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public double ValuePerUnit { get; set; }
        public long UnitAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DurationEstimativeDate { get; set; }
        public int InstalmentAmount { get; set; }
        public int IdTransactionType { get; set; }
    }
}
