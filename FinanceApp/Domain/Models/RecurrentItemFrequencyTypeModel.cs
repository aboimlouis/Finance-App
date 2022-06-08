namespace FinanceApp.Domain.Models
{
    public class RecurrentItemFrequencyTypeModel
    {
        public RecurrentItemFrequencyTypeModel()
        {
            ID = 0;
            Name = "";
            IdUser = 0;

            RecurrentItemModels= new List<RecurrentItemModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public long IdUser { get; set; }

        public ICollection<RecurrentItemModel> RecurrentItemModels { get; set; }
    }
}
