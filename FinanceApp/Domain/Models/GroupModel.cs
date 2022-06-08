namespace FinanceApp.Domain.Models
{
    public class GroupModel
    {
        public GroupModel()
        {
            ID = 0;
            Name = "";

            UserId = 0;

            User = new UserModel();
        }

        public long ID { get; set; }
        public string Name { get; set; }

        public long UserId { get; set; }

        public UserModel User { get; set; }
    }
}
