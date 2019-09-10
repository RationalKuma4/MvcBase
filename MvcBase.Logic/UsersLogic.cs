using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MvcBase.Data;
using Mo = MvcBase.Models;
using Vm = MvcBase.ViewModels;

namespace MvcBase.Logic
{
    public class UsersLogic
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Mo.ApplicationUser> _userManager;
        private readonly RoleManager<Mo.Role> _roleManager;
        private readonly MvcBaseDbContext _dbContext;

        public UsersLogic(IMapper mapper, UserManager<Mo.ApplicationUser> userManager,
            RoleManager<Mo.Role> roleManager, MvcBaseDbContext dbContext)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        public string MapUsers(Vm.LoginViewModel loginViewModel)
        {
            var mappedresult = _mapper.Map<Mo.ApplicationUser>(loginViewModel);
            return mappedresult.UserName;
        }

        public async Task<Vm.ApplicationUserViewModel> ResgisterAsync(string username, string password, string email)
        {
            var userExists = _userManager.FindByNameAsync(username);

            if (userExists != null)
            {
                return new Vm.ApplicationUserViewModel
                {
                    RegitratonError = "Username not avaliable"
                };
            }

            var newUserId = Guid.NewGuid();
            var newUser = new Mo.ApplicationUser
            {
                Id = 1,
                Email = email,
                UserName = username
            };

            var createdUser = await _userManager.CreateAsync(newUser, password);
            return _mapper.Map<Vm.ApplicationUserViewModel>(createdUser);
        }
    }
}
