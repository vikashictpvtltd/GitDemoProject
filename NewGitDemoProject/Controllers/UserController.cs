using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemoProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(int input1,int input2)
        {
            //get user input
            ViewBag.Input1 = 0;
            ViewBag.Input2 = 0;
            ViewBag.Output = 0;
            ViewBag.output = input1;
            if (input1!=0 && input2!=0) {
                //get user input
                ViewBag.Input1 = input1;
                ViewBag.Input2 = input2;
                ViewBag.Output = input1 + input2;
            }
            return View(ViewBag);
        }
    }
}