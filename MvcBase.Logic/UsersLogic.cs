using AutoMapper;
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
        public string MapUsers(Vm.LoginViewModel loginViewModel)
        {
            var mappedresult = _mapper.Map<Mo.ApplicationUser>(loginViewModel);
            return mappedresult.UserName;
        }
    }
}
