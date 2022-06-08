namespace FinanceApp.Domain.Models
{
    public class ItemTransactionTypeModel
    {
        public ItemTransactionTypeModel()
        {
            ID = 0;
            Name = "";
            IdUser = 0;

            ItemModels = new List<ItemModel>();
            RecurrentItemModels = new List<RecurrentItemModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public long IdUser { get; set; }

        public ICollection<ItemModel> ItemModels { get; set; }
        public ICollection<RecurrentItemModel> RecurrentItemModels { get; set; }
    }
}
