using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz11B.Models;

namespace Quiz11B.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()

        {
            List<string> siblings = new List<string>();
            foreach (Person p in People.Person())
            {
                string Name = p.Name;
                int Age = p.Age;
                string FavoriteColor = p.FavoriteColor;
                string Gender = p.Gender;
                siblings.Add(string.Format("My Name is {0}. I am {1} years old. My favorite color is {2} and I am a {3}",
                    Name, Age, FavoriteColor, Gender));
            }
            return View(siblings);
        }
    }
}

//        public IActionResult About()
//        {
//            ViewData["Message"] = "Your application description page.";

//            return View();
//        }

//        public IActionResult Contact()
//        {
//            ViewData["Message"] = "Your contact page.";

//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
