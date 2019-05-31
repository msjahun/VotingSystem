using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VotingSystemWeb.Models;
using Vs.Core.Users;

namespace VotingSystemWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserManager<ApplicationUser> _userManager { get; }

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Route("Account")]
        [Route("Login")]
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
           
            return View();
        }

        [Route("Account")]
        [Route("Login/")]
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.Users.FirstOrDefault(s => s.UserName == vm.Username);
                if (user == null)
                {
                    ModelState.AddModelError("", "User doesn't exist");
                    return View(vm);
                }

               
                var result = await _signInManager.PasswordSignInAsync(vm.Username, vm.Password, vm.RememberMe, false);

                if (result.Succeeded)
                {
                    //save last login date
                    var User = _userManager.Users.Where(c => c.UserName == vm.Username).FirstOrDefault();
                    user.LastLoginDateUtc = DateTime.UtcNow;
                    await _userManager.UpdateAsync(User);

                    var st = vm.ReturnUrl;
                    if (st != null)
                        return Redirect(vm.ReturnUrl);
                    else


                        return RedirectToAction("index", "Home");
                }

                ModelState.AddModelError("", "Invalid Login attempt");
               
            }


            return View(vm);
        }



        [Route("Register/")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [Route("Register/")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = vm.UserName,
                    CitizenNumber = vm.CitizenshipNumber,
                    LastLoginDateUtc = DateTime.Now,
                    FirstName = vm.Firstname,
                    LastName = vm.LastName
                    
                };
                var result = await _userManager.CreateAsync(user, vm.Password);

                if (result.Succeeded)
                {
                    
                    // await signInManager.SignInAsync(user, false);
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }

            }
            return View(vm);
        }



        [Route("Logout/")]
        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
    }
}