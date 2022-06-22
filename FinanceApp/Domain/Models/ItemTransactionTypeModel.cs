namespace FinanceApp.Domain.Models
{
    public class ItemTransactionTypeModel
    {
        public ItemTransactionTypeModel() // Debit Card, Credit Card 
        {
            ID = 0;
            Name = "";

            ItemModels = new List<ItemModel>();
            RecurrentItemModels = new List<RecurrentItemModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }

        public ICollection<ItemModel> ItemModels { get; set; }
        public ICollection<RecurrentItemModel> RecurrentItemModels { get; set; }
    }
}
