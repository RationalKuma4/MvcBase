using Microsoft.AspNetCore.Mvc;
using MvcBase.Logic;
using MvcBase.ViewModels;

namespace MvcBase.Web.Controllers.Account
{
    public class AccountController : BaseController
    {
        private readonly UsersLogic _usersLogic;

        public AccountController(UsersLogic usersLogic)
        {
            _usersLogic = usersLogic;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var userMapped = _usersLogic.MapUsers(loginViewModel);

            return RedirectToAction("Index", "Home");
        }
    }
}