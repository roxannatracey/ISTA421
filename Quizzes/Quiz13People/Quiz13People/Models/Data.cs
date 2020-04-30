using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Quiz13People.Data;
using System;
using System.Linq;

namespace Quiz13People.Models
{
    public static class Data
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PeopleQuizContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PeopleQuizContext>>()))
            {
               
                if (context.People.Any())
                {
                    return;   
                }

                context.People.AddRange(
                    new People
                    {
                        Name = "Roxanna Barahona",
                        DateofBirth = DateTime.Parse("1994-04-30"),
                        Relationship = "Self",
                        Alive = true
                    },
                    new People
                    {
                        Name = "Michelle Barahona",
                        DateofBirth = DateTime.Parse("2003-08-28"),
                        Relationship = "sister",
                        Alive = true
                    },
                    new People
                    {
                        Name = "Tanya Barahona",
                        DateofBirth = DateTime.Parse("1995-11-04"),
                        Relationship = "sister",
                        Alive = true
                    },
                    new People
                    {
                        Name = "James Barahona",
                        DateofBirth = DateTime.Parse("1985-01-25"),
                        Relationship = "brother",
                        Alive = true
                    },
                    new People
                    {
                        Name = "Luis Barahona",
                        DateofBirth = DateTime.Parse("2018-08-28"),
                        Relationship = "ME",
                        Alive = false
                    }

                );
                context.SaveChanges();
            }
        }
    }
}