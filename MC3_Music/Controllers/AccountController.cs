﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MC3_Music.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        //this is the second conflict comment
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