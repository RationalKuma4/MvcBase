using System.ComponentModel.DataAnnotations;

namespace MvcBase.ViewModels
{
    public class RoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
