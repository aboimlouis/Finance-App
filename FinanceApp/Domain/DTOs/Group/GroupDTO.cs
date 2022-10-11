namespace FinanceApp.Domain.DTOs.Group
{
    public class GroupDTO
    {
        public GroupDTO()
        {
            ID = 0;
            Name = "";
        }
        public long ID { get; set; }
        public string Name { get; set; }
    }
}
