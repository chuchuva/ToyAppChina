﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyAppChina.Models;

namespace ToyAppChina.Controllers
{
    public class StaticPagesController : Controller
    {
        [Route("")]
        public ActionResult Home()
        {
            return View();
        }

        [Route("help")]
        public ActionResult Help()
        {
            return View();
        }

        [Route("about")]
        public ActionResult About()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("debug-connection-string-hjkdfh484323rf")]
        public ActionResult DebugConnectionStringDontForgetToDelete()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"];
            return Content((connectionString != null ? connectionString.ConnectionString : "null :(") +
                System.Configuration.ConfigurationManager.AppSettings["SQLSERVER_URI"]);
        }

    }
}