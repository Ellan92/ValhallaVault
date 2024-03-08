using ValhallaVault.Data;
using ValhallaVault.Data.Repository;

namespace ValhallaVault.Managers
{
    public class UserManager
    {
        private readonly UserRepo _userRepo;

        public UserManager(UserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public ApplicationUser? GetUserByName(string userName)
        {
            return _userRepo.GetUserByName(userName);
        }

        public async Task<ApplicationUser?> GetUserByNameAsync(string userName)
        {
            var user = await _userRepo.GetUserByNameAsync(userName);
            return user;
        }


    }
}
