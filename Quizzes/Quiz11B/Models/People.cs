using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz11B.Models;

namespace Quiz11B.Models
{
    public class People
    {
        public static Person[] Person()
        {
            Person Roxanna = new Person { Name = "Roxanna", Age = 25, FavoriteColor = "Pink", Gender = "Female" };
            Person Tanya = new Person { Name = "Tanya", Age = 24, FavoriteColor = "Pink", Gender = "Female" };
            Person James = new Person { Name = "James", Age = 34, FavoriteColor = "Red", Gender = "Male" };
            Person Michelle = new Person { Name = "Michelle", Age = 16, FavoriteColor = "Blue", Gender = "Female" };
            Person Luis = new Person { Name = "Luis", Age = 3, FavoriteColor = "Green", Gender = "Male" };
            return new Person[] { Roxanna, Tanya, James, Michelle, Luis };
        }
    }
}
