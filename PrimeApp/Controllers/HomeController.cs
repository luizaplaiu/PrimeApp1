using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var num = Request["text1"];
           

            List<int> myList = new List<int>();

            PrimeN myPrime = new PrimeN();

            int input;
            if((int.TryParse(num, out input)))
            {
                myList = myPrime.CheckPrime( input);
            }

            return View(myList);
        }

     
    }
}