using CodeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeProject.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Message()
        {
            return View();
        }
        public ActionResult ShowPerson()
        {
            List<Person> persons = new List<Person>{
                new Person(){FirstName = "Sherlock" , LastName = "Holmes"},
                new Person(){FirstName = "James" , LastName = "Watson"},
            };
            return View(persons);
        }

    }
}
