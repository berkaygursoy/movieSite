using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MovieProject.Models.DTO;
using MovieProject.Repositories.Abstract;

namespace MovieProject.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationService authService;
        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            this.authService = authService;
        }

        //public async Task<IActionResult> Register()
        //{
        //    var model = new MovieProject.Models.DTO.RegistrationModel
        //    {
        //        Email = "admin@gmail.com",
        //        UserName = "admin",
        //        Name = "Berkay",
        //        Password = "Berkay@123",
        //        PasswordConfirm = "Berkay@123",
        //        Role = "Admin"
        //    };

        //    //Eğer kullanıcı olarak giriş yapmak isterseniz "Role" kısmını "User" olarak değiştirebilirsiniz.

        //    var result = await authService.RegisterAsync(model);

        //    return Ok(result.Message);
        //}

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await authService.LoginAsync(model);
            if (result.StatusCode == 1)
                return RedirectToAction("Index", "Home");
            else
            {
                TempData["msg"] = "Could not logged in..";
                return RedirectToAction(nameof(Login));
            }
        }

        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }

    }
}

