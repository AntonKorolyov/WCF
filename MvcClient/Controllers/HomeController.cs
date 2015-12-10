using MvcClient.Models;
using MvcClient.ServiceReferencePerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPerson()
        {
            List<Person> persons = new List<Person>();
            FuncClient clients = new FuncClient();
            persons = clients.GetPersons();
            return Json(persons);
        }
        public ActionResult DeletePerson(string id)
        {
            FuncClient func = new FuncClient();
            func.DeletePersons(Convert.ToInt32(id));
            return null;
        }
        public ActionResult CreatePerson(Person pers)
        {
            FuncClient func = new FuncClient();
            func.CreatePersons(pers);
            return null;
        }
        public ActionResult UpdatePerson(Person pers)
        {
            FuncClient func = new FuncClient();
            func.UpdatePersons(pers);
            return null;
        }
    }
}
