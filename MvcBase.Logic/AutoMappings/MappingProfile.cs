using AutoMapper;
using MvcBase.ViewModels.Roles;
using MvcBase.ViewModels.Users;
using Vm = MvcBase.ViewModels;
using Mo = MvcBase.Models;

namespace MvcBase.Logic.AutoMappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateUsersMaps();
            CreateRolesMaps();
        }

        private void CreateRolesMaps()
        {
            
        }

        private void CreateUsersMaps()
        {
            CreateMap<LoginViewModel, Mo.ApplicationUser>();
            CreateMap<Mo.ApplicationUser, LoginViewModel>();
        }
    }
}
