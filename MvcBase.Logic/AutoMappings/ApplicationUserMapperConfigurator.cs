using AutoMapper;
using MvcBase.Logic.AutoMappings.Common;
using Mo = MvcBase.Models;
using Vm = MvcBase.ViewModels;

namespace MvcBase.Logic.AutoMappings
{
    public class ApplicationUserMapperConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Vm.LoginViewModel, Mo.ApplicationUser>()
                .ForMember(u => u.FirstName, opt => opt.Ignore())
                .ForMember(u => u.LastName, opt => opt.Ignore())
                .ForMember(u => u.Id, opt => opt.Ignore())
                .ForMember(u => u.NormalizedUserName, opt => opt.Ignore())
                .ForMember(u => u.EmailConfirmed, opt => opt.Ignore())
                .ForMember(u => u.PasswordHash, opt => opt.Ignore())
                .ForMember(u => u.SecurityStamp, opt => opt.Ignore())
                .ForMember(u => u.ConcurrencyStamp, opt => opt.Ignore())
                .ForMember(u => u.PhoneNumber, opt => opt.Ignore())
                .ForMember(u => u.PhoneNumberConfirmed, opt => opt.Ignore())
                .ForMember(u => u.TwoFactorEnabled, opt => opt.Ignore())
                .ForMember(u => u.LockoutEnabled, opt => opt.Ignore())
                .ForMember(u => u.LockoutEnd, opt => opt.Ignore())
                .ForMember(u => u.AccessFailedCount, opt => opt.Ignore());
        }
    }
}
