﻿namespace FinanceApp.Domain.Models
{
    public class ItemTransactionTypeModel
    {
        public ItemTransactionTypeModel()
        {
            ID = 0;
            Name = "";
            IdUser = 0;
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public long IdUser { get; set; }
    }
}