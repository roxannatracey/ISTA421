using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz11.Models;

namespace Quiz11.Controllers   
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
           Person Roxanna = new Person
         {
              FirstName = "Roxanna",
               LastName = "Barahona",
               MyFavoriteSnack = "Sour Patch Kids",
               MyFavoriteColor = "pastel Pink",
           };
           return View(Roxanna); 
        }
    }
   
}




