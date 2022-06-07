﻿namespace FinanceApp.Domain.Models
{
    public class TagModel
    {
        public TagModel()
        {
            ID = 0;
            Name = "";
            IdUser = 0;
            Items = new List<ItemModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public long IdUser { get; set; }

        public ICollection<ItemModel> Items { get; set; }
    }
}
