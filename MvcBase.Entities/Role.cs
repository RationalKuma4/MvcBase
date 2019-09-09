using Microsoft.AspNetCore.Identity;

namespace MvcBase.Models
{
    public class Role : IdentityRole<int>
    {
        public Role() { }

        public Role(string name)
        {
            Name = name;
        }
    }
}
