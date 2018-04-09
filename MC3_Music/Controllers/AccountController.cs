using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MC3_Music.Controllers
{

    [Authorize]
    public class AccountController : Controller
    {
        // GET: Account
        //this is the second conflict comment
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AccountController();

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {

        }

        public ApplicaitonSignInManager()
        {

        }
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }

  
}