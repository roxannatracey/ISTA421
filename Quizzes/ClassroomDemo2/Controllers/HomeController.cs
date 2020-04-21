using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassroomDemo2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomDemo2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            MyPerson Roxanna = new MyPerson
            {
                FirstName = "Roxanna",
                LastName = "Barahona",
                MyFavoriteSnack = "Sour Patch Kids",

              
            };
                 return View(Roxanna);
        }

    }
}

