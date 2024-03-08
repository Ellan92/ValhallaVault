using Microsoft.EntityFrameworkCore;

namespace ValhallaVault.Data.Repository
{
    public class UserRepo
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser?> GetUserByNameAsync(string userName)
        {

            var user = await _context.Users.Include(u => u.UserResults).ThenInclude(r => r.Result)
                .FirstOrDefaultAsync(u => u.UserName == userName);

            return user;
        }

        public ApplicationUser? GetUserByName(string userName)
        {
            // Använd LINQ för att hämta användaren med det angivna användarnamnet
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == userName);

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }

        }

    }
}
