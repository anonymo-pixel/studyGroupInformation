using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studyGroupInformation.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult People()
        {
            List<Models.StudyGroupModel> people = new List<Models.StudyGroupModel>();

            people.Add(new Models.StudyGroupModel { StudentNumber = "u24723399", FirstName = "Patience", LastName = "Chitsulo", EmailAddress = "patience.chitsulo@tuks.co.za", Link = "~/HTML/Patience.html"});
            people.Add(new Models.StudyGroupModel { StudentNumber = "u24736661", FirstName = "Regopotswe", LastName = "Moholane", EmailAddress = "regopotswe.moholane@tuks.co.za", Link = "~/HTML/Regopotswe.html" });
            people.Add(new Models.StudyGroupModel { StudentNumber = "u24584127", FirstName = "Bih", LastName = "Abongnui", EmailAddress = "bih.abongnui@tuks.co.za", Link = "~/HTML/Bih.html" });
            people.Add(new Models.StudyGroupModel { StudentNumber = "u24974553", FirstName = "Aviwe", LastName = "Mahlukane", EmailAddress = "aviwe.mahlukane.tuks.co.za" , Link = "~/HTML/Aviwe.html" });
            people.Add(new Models.StudyGroupModel { StudentNumber = "u24603199", FirstName = "Caitanya", LastName = "Narain Singh", EmailAddress = "caitanya.narainsingh@tuks.co.za" , Link = "~/HTML/Caitanya.html" });
            
            
            return View(people);
        }
    }
}