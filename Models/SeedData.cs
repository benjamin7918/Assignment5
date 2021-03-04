using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)

        {
            BooksDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BooksDbContext>();

            //This if checks if there are any pending migrations
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Projects.Any())
            {
                context.Projects.AddRange(

                    //This is where the data is created for each book
                        new Project
                        {
                            Title = "Les Miserable",
                            Author = "Victor Hugo",
                            Publisher = "Signet",
                            ISBN = "978-0451419439",
                            Classification = "Fiction, Classic",
                            Price = 9.95,
                            PageNumbers = 1488
                        },

                        new Project
                        {
                            Title = "Team of Rivals",
                            Author = "Doris Kearns Goodwin",
                            Publisher = "Simon & Schuster",
                            ISBN = "978-0743270755",
                            Classification = "Non-Fiction, Biography",
                            Price = 14.58,
                            PageNumbers = 944
                        },

                        new Project
                        {
                            Title = "The Snowball",
                            Author = "Alice Schroeder",
                            Publisher = "Bantam",
                            ISBN = "978-0553384611",
                            Classification = "Non-Fiction, Biography",
                            Price = 21.54,
                            PageNumbers = 832
                        },

                        new Project
                        {
                            Title = "American Ulysses",
                            Author = "Ronald C. White",
                            Publisher = "Random House",
                            ISBN = "978-0812981254",
                            Classification = "Non-Fiction, Biography",
                            Price = 11.61,
                            PageNumbers = 864
                        },

                        new Project
                        {
                            Title = "Unbroken",
                            Author = "Laura Hillenbrand",
                            Publisher = "Random House",
                            ISBN = "978-0812974492",
                            Classification = "Non-Fiction, Historical",
                            Price = 13.33,
                            PageNumbers = 528
                        },

                        new Project
                        {
                            Title = "The Great Train Robbery",
                            Author = "Michael Crichton",
                            Publisher = "Vintage",
                            ISBN = "978-0804171281",
                            Classification = "Fiction, Historical Fiction",
                            Price = 15.95,
                            PageNumbers = 288
                        },

                        new Project
                        {
                            Title = "Deep Work",
                            Author = "Cal Newport",
                            Publisher = "Grand Central Publishing",
                            ISBN = "978-1455586691",
                            Classification = "Non-Fiction, Self-Help",
                            Price = 14.99,
                            PageNumbers = 304
                        },

                        new Project
                        {
                            Title = "It's Your Ship",
                            Author = "Michael Abrashoff",
                            Publisher = "Grand Central Publishing",
                            ISBN = "978-1455523023",
                            Classification = "Non-Fiction, Self-Help",
                            Price = 21.66,
                            PageNumbers = 240
                        },

                        new Project
                        {
                            Title = "The Virgin Way",
                            Author = "Richard Branson",
                            Publisher = "Portfolio",
                            ISBN = "978-1591847984",
                            Classification = "Non-Fiction, Business",
                            Price = 29.16,
                            PageNumbers = 400
                        },

                        new Project
                        {
                            Title = "Sycamore Row",
                            Author = "John Grisham",
                            Publisher = "Bantam",
                            ISBN = "978-0553393613",
                            Classification = "Fiction, Thrillers",
                            Price = 15.03,
                            PageNumbers = 642
                        },

                        new Project
                        {
                            Title = "Book of Mormon",
                            Author = "God",
                            Publisher = "The Church of Jesus Christ of Latter-day Saints",
                            ISBN = "978-0530829500",
                            Classification = "Religous, Historical",
                            Price = 3.10,
                            PageNumbers = 531
                        },

                        new Project
                        {
                            Title = "The Great Gatsby",
                            Author = "F. Scott Fitzgerald",
                            Publisher = "Charles Scribner's Sons",
                            ISBN = "978-0743273565",
                            Classification = "Fiction, Tragedy",
                            Price = 4.79,
                            PageNumbers = 218
                        },

                        new Project
                        {
                            Title = "The Ferguson Rifle",
                            Author = "Louis L'Amour",
                            Publisher = "Bantam",
                            ISBN = "978-0804126618",
                            Classification = "Western, Fiction",
                            Price = 4.49,
                            PageNumbers = 240
                        }


                    );

                    context.SaveChanges();
            }
        }
    }
}
