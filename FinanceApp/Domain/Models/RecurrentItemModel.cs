namespace FinanceApp.Domain.Models
{
    public class RecurrentItemModel
    {
        public RecurrentItemModel()
        {
            ID = 0;
            Name = "";
            Value = 0.0;
            UnitAmount = 1;
            TransactionDate = DateTime.Now;
            DurationEstimativeDate = null;
            IdFrequencyType = 1;
            FrequencyTimeUnits = 1;
            IsValueSplited = false;
            IsAutomaticConfirm = false;
            FrequencyInstancesAmount = 1;
            FrequencyInstancesAmountCount = 0;
            ConfirmReminderDateTime = null;

            UserId = 0;
            TransactionTypeId = 0;
            FrequencyId = 0;

            User = new UserModel();
            TransactionType = new ItemTransactionTypeModel();
            Frequency = new RecurrentItemFrequencyTypeModel();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public double Value { get; set; } // Value of the repeatable transaction
        public long UnitAmount { get; set; } // Amount of items bought
        public DateTime TransactionDate { get; set; } // Date of the transaction creation
        public DateTime? DurationEstimativeDate { get; set; } // Item duration of use
        public bool IsValueSplited { get; set; } // If the value of the product is splitted between the frequency instances
        public bool IsAutomaticConfirm { get; set; } // If the user needs to confirm the item execution every time
        public int IdFrequencyType { get; set; } // Id of the frequency, days, months, etc...
        public int FrequencyTimeUnits { get; set; } // 1 day, 2 months, etc...
        public int FrequencyInstancesAmount { get; set; } // Number of times the recurrent item triggers
        public int FrequencyInstancesAmountCount { get; set; } // Number of times the recurrent item triggered
        public DateTime? ConfirmReminderDateTime { get; set; } // Date when the user wants to be reminded of the item confirmation

        public long UserId { get; set; }
        public long TransactionTypeId { get; set; }
        public long FrequencyId { get; set; }

        public UserModel User { get; set; }
        public ItemTransactionTypeModel TransactionType { get; set; }
        public RecurrentItemFrequencyTypeModel Frequency { get; set; }
    }
}
