namespace FinanceApp.Domain.Models
{
    public class UserModel
    {
        public UserModel()
        {
            ID = 0;
            Name = "";
            UserName = "";
            Password = "";
            Tags = new List<TagModel>();
            Groups = new List<GroupModel>();
            Items = new List<ItemModel>();
            RecurrentItems = new List<RecurrentItemModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<TagModel> Tags { get; set; }
        public ICollection<GroupModel> Groups { get; set; }
        public ICollection<ItemModel> Items { get; set; }
        public ICollection<RecurrentItemModel> RecurrentItems { get; set; }
    }
}
