using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quizz.Models;

namespace Quizz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();


            //return View(new PartialModel2() { partialModel = Sampledetails() });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //private List<PartialModel2> Sampledetails()
        //{
        //    List<PartialModel2> model = new List<PartialModel2>();

        //    model.Add(new PartialModel2()
        //    {

        //        Name = "Rima",
        //        Age = 20,
        //        Address = "Kannur"
        //    });

        //    model.Add(new PartialModel2()
        //    {

        //        Name = "Rohan",
        //        Age = 23,
        //        Address = "Ernakulam"
        //    });
        //    model.Add(new PartialModel2()
        //    {
        //        Name = "Reshma",
        //        Age = 22,
        //        Address = "Kannur"
        //    });

        //    return model;
        //}
    }
}