namespace FinanceApp.Domain.Models
{
    public class TagModel
    {
        public TagModel()
        {
            ID = 0;
            Name = "";

            UserId = 0;

            User = new UserModel();
            Items = new List<ItemModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }

        public long UserId { get; set; }


        public UserModel User { get; set; }
        public ICollection<ItemModel> Items { get; set; }
    }
}
