namespace FinanceApp.Domain.Models
{
    public class RecurrentItemModel
    {
        public RecurrentItemModel()
        {
            ID = 0;
            Name = "";
            ValuePerUnit = 0.0;
            UnitAmount = 1;
            TransactionDate = DateTime.Now;
            DurationEstimativeDate = DateTime.Now;
            IdTransactionType = 1;
            IdFrequencyType = null;
            CustomFrequencyDays = null;
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public double ValuePerUnit { get; set; }
        public long UnitAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DurationEstimativeDate { get; set; }
        public int IdTransactionType { get; set; }
        public int? IdFrequencyType { get; set; }
        public int? CustomFrequencyDays { get; set; }
    }
}
