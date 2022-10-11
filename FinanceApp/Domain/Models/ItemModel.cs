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
            DurationEstimativeDate = null;

            UserId = 0;
            GroupId = null;
            TransactionTypeId = 0;

            User = new UserModel();
            Group = new GroupModel();
            TransactionType = new ItemTransactionTypeModel();
            Tags = new List<TagModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public double ValuePerUnit { get; set; }
        public long UnitAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? DurationEstimativeDate { get; set; }

        public long UserId { get; set; }
        public long? GroupId { get; set; }
        public long TransactionTypeId { get; set; }

        public UserModel User { get; set; }
        public GroupModel Group { get; set; }
        public ItemTransactionTypeModel TransactionType { get; set; }
        public ICollection<TagModel> Tags { get; set; }
    }
}
