namespace FinanceApp.Domain.Models
{
    public class ItemTagRelationModel
    {
        public ItemTagRelationModel()
        {
            ID = 0;
            IdUserModel = 0;
            IdItemModel = 0;
        }

        public long ID { get; set; }
        public long IdUserModel { get; set; }
        public long IdItemModel { get; set; }
    }
}
