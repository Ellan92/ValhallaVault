namespace ValhallaVault.Data.Repository
{
    public class UserRepo
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
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
