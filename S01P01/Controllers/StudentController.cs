using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S01P01.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListStudent()
        {
            List<S01P01.Models.Student> students=new List<Models.Student> ();
            students.Add(new Models.Student {StudentNo="u21731234", Name="Mhlengi" , Surname="Ndaba" ,Email="mhlengindababless@gmail.com" });
            students.Add(new Models.Student {StudentNo="u21731234", Name="Mhlengi" , Surname="Ndaba" ,Email="mhlengindababless@gmail.com" });
            students.Add(new Models.Student {StudentNo="u21731234", Name="Mhlengi" , Surname="Ndaba" ,Email="mhlengindababless@gmail.com" });
            students.Add(new Models.Student {StudentNo="u21731234", Name="Mhlengi" , Surname="Ndaba" ,Email="mhlengindababless@gmail.com" });
            students.Add(new Models.Student {StudentNo="u21731234", Name="Mhlengi" , Surname="Ndaba" ,Email="mhlengindababless@gmail.com" });
            return View(students);

        }
    }
}