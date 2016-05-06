using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//kasih using MVC bootcamp biar tidak perlu ditulis lengkap lagi (using utk import namespace)
using MvcBootcamp.Web.Models;

namespace MvcBootcamp.Web.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello From Store.Index";
        }

        public string Browse(string category)
        {
            return HttpUtility.HtmlEncode("Hello from Browse with category: " + category);
        }

        public string News(int year, int month, int day)
        {
            return HttpUtility.HtmlEncode("Hello from Store.News with Year: " + year.ToString() + ", Month: " + month.ToString() + ", Day: " + day.ToString());
        }

        public ActionResult Home()
        {
            //return View();
            //return View("About");
            return View("~/Views/Home/About.cshtml");
        }

        public ActionResult DataSample()
        {
            ViewData["event"] = "MSP Bootcamp";
            ViewData["place"] = "Hotel Neo";

            ViewBag.events = "MSP Bootcamp";
            ViewBag.place = "Hotel Neo";

            var books = new List<string>() { "ASP.NET", "SQL SERVER", "Windows 10" };
            ViewBag.booklist = books;

            return View();
        }

        public ViewResult StronglyTypeView()
        {

            /*var newCust = new Models.Customer()
            {
                CompanyName = "Native Enterprise",
                City = "Bandung"               
            };*/


            //return View(newCust);

            var listCust = new List<CustomerData>();
            listCust.Add(new CustomerData
            {
                CompanyName = "Native Enterprise",
                City = "Bandung"
            });

            listCust.Add(new CustomerData
            {
                CompanyName = "Microsoft Indonesia",
                City = "Jakarta"
            });

            return View(listCust);
            
        }
    }
}