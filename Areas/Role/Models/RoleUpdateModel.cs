using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace QuanLyRapPhim.Models
{
    public class RoleUpdateModel
    {
        public IdentityRole role { set; get; }

        public IEnumerable<AppUserModel> members { set; get; }

        public IEnumerable<AppUserModel> nonMembers { set; get; }
    }
}