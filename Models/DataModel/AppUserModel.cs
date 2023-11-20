using Microsoft.AspNetCore.Identity;

namespace QuanLyRapPhim.Models
{
    public class AppUserModel : IdentityUser
    {
        public string peopleId { set; get; }

        public string fullName { set; get; }
    }
}