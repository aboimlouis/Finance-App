using FinanceApp.Domain.Models;

namespace FinanceApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var users = new UserModel[]
            {
                new UserModel{ Name = "Test1", UserName = "TestUserName1", Password = "TempPassword" },
                new UserModel{ Name = "Test2", UserName = "TestUserName2", Password = "TempPassword" },
                new UserModel{ Name = "Test3", UserName = "TestUserName3", Password = "TempPassword" },
                new UserModel{ Name = "Test4", UserName = "TestUserName4", Password = "TempPassword" }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
