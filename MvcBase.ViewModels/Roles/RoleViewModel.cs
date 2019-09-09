using System.ComponentModel.DataAnnotations;

namespace MvcBase.ViewModels.Roles
{
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
