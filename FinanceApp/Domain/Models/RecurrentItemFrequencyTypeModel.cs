namespace FinanceApp.Domain.Models
{
    public class RecurrentItemFrequencyTypeModel
    {
        public RecurrentItemFrequencyTypeModel() // Day, Week, Month, Year
        {
            ID = 0;
            Name = "";

            RecurrentItemModels = new List<RecurrentItemModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }

        public ICollection<RecurrentItemModel> RecurrentItemModels { get; set; }
    }
}
