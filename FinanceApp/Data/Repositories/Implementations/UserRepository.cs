using FinanceApp.Data;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private Context _context { get; set; }
        public UserRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<UserModel>> GetCompleteUser()
        {
            return
                await _context.Users
                .Include(l => l.Characters)
                .OrderBy(l => l.ID)
                .ToListAsync();
        }
    }
}
