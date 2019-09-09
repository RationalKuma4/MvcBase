using AutoMapper;
using MvcBase.ViewModels.Roles;
using MvcBase.ViewModels.Users;
using Mo = MvcBase.Models;
using Vm = MvcBase.ViewModels;

namespace MvcBase.Logic
{
    public class UsersLogic
    {
        private readonly IMapper _mapper;

        public UsersLogic(IMapper mapper)
        {
            _mapper = mapper;
        }

        public string MapUsers(LoginViewModel loginViewModel)
        {
            var mappedresult = _mapper.Map<Mo.ApplicationUser>(loginViewModel);
            return mappedresult.UserName;
        }
    }
}
