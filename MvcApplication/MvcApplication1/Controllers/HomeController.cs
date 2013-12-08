using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Users()
    {
        List<string> testEmails = new List<string>();
        //testEmails.Add("sq@eer4");
        //    testEmails.Add("dmsk");
           

            UserModel model = new UserModel();
            testEmails = model.GetUserEmails();
            return View(testEmails);
                
    }
    }
}
