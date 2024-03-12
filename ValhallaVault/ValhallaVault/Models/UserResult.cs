using Microsoft.EntityFrameworkCore;
using ValhallaVault.Data;

namespace ValhallaVault.Models
{
    [PrimaryKey("UserId", ["ResultId"])]
    public class UserResult
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public int ResultId { get; set; }
        public ResultModel Result { get; set; } = null!;
    }
}
