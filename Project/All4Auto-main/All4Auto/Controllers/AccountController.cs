namespace All4Auto.Controllers
{
    using All4Auto.Core.Constants;
    using All4Auto.Core.Models.Account;
    using All4Auto.DataProcessor.Models.Account;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Authorization;

    public class AccountController : BaseController
    {
        private readonly UserManager<UserProfile> userManager;
        private readonly SignInManager<UserProfile> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(
            UserManager<UserProfile> _userManager,
            SignInManager<UserProfile> _signInManager,
            RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        //[HttpGet]
        //public IActionResult Profile()
        //{
        //    return View();
        //}

        //public async Task<IActionResult> Profile(ProfileVIewModel profile)
        //{
            
        //    if (!ModelState.IsValid)
        //    {
        //        return View(profile);
        //    }
        //    return View();
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new UserProfile()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                EmailConfirmed = true,
                LastName = model.LastName,
                UserName = model.Email
            };

            var result = await userManager.CreateAsync(user, model.Password);
            await userManager
                    .AddClaimAsync(user, new System.Security.Claims.Claim(ClaimTypeConst.FirsName, user.FirstName ?? user.Email));


            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }


            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string? returnUrl = null)
        {
            var model = new LoginViewModel()
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {

                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    if (model.ReturnUrl != null)
                    {
                        return Redirect(model.ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> CreateRoles()
        {
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Owner));
            await roleManager.CreateAsync(new IdentityRole(RoleConstants.Administrator));

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AddUsersToRoles()
        {
            string email1 = "dolt@all4auto.eu";
            string email2 = "user@abv.bg";
            string admin = "Webmaster@all4auto.eu";

            var adminUser = await userManager.FindByNameAsync(admin);
            var user = await userManager.FindByEmailAsync(email1);
            var user2 = await userManager.FindByEmailAsync(email2);
            
            await userManager.AddToRoleAsync(adminUser, RoleConstants.Administrator);
            await userManager.AddToRoleAsync(user, RoleConstants.Owner);
            await userManager.AddToRolesAsync(user2, new string[] { RoleConstants.Owner });

            return RedirectToAction("Index", "Home");
        }
    }
}
