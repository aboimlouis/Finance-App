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
            IdFrequencyType = null;
            CustomFrequencyDays = null;

            UserId = 0;
            TransactionTypeId = 0;
            FrequencyId = 0;

            User = new UserModel();
            TransactionType = new ItemTransactionTypeModel();
            Frequency = new RecurrentItemFrequencyTypeModel();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public double ValuePerUnit { get; set; }
        public long UnitAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DurationEstimativeDate { get; set; }
        public int? IdFrequencyType { get; set; }
        public int? CustomFrequencyDays { get; set; }

        public long UserId { get; set; }
        public long TransactionTypeId { get; set; }
        public long FrequencyId { get; set; }

        public UserModel User { get; set; }
        public ItemTransactionTypeModel TransactionType { get; set; }
        public RecurrentItemFrequencyTypeModel Frequency { get; set; }
    }
}
