using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Quiz11.Controllers
{
    public class Person2Controller : Controller
    {
        public ViewResult Index()
        {
            Person Jose = new Person
            {
                FirstName = "Jose",
                LastName = "Pimentel",
                MyFavoriteSnack = "Skittles",
                MyFavoriteColor = "Green",
            };
            return View(Jose);
        }
    }
}
