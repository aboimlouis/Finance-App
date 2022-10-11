namespace FinanceApp.Domain.DTOs.Tag
{
    public class TagDTO
    {
        public TagDTO()
        {
            ID = 0;
            Name = "";
        }
        public long ID { get; set; }
        public string Name { get; set; }
    }
}
