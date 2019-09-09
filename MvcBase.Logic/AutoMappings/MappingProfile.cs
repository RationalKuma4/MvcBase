using AutoMapper;
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
            CreateMap<Vm.LoginViewModel, Mo.ApplicationUser>();
            CreateMap<Mo.ApplicationUser, Vm.LoginViewModel>();
        }
    }
}
