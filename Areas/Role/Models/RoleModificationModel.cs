using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class RoleModification
    {
        public string roleId { set; get; }

        [Required]
        public string roleName { set; get; }

        public List<string> addIds { set; get; }

        public List<string> deleteIds { set; get; }
    }
}