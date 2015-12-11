using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ToyAppChina.Models;

namespace ToyAppChina.Controllers
{
    public class AccountController : Controller
    {
        [Route("account/signup")]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [Route("account/signup")]
        public async Task<ActionResult> Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FullName = model.FullName
                };

                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Json(result);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }

            // If we reach this point, something failed, redisplay the form
            return View();
        }
    }
}
