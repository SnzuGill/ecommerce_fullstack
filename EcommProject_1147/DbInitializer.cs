using EcommProject_1147.DataAccess.Data;
using EcommProject_1147.Models;
using EcommProject_1147.Utility;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                if (context != null)
                {
                    if (!context.Categories.Any())
                    {
                        context.Categories.AddRange(
                            new Category { Name = "Fiction" },
                            new Category { Name = "Non-Fiction" },
                            new Category { Name = "Science" },
                            new Category { Name = "History" },
                            new Category { Name = "Biography" },
                            new Category { Name = "Indian Literature" }
                        );
                    }

                    if (!context.CoverTypes.Any())
                    {
                        context.CoverTypes.AddRange(
                            new CoverType { Name = "Hardcover" },
                            new CoverType { Name = "Paperback" },
                            new CoverType { Name = "E-book" },
                            new CoverType { Name = "Audiobook" }
                        );
                    }

                    if (!context.Products.Any())
                    {
                        context.Products.AddRange(
                            new Product
                            {
                                Title = "The White Tiger",
                                Description = "A powerful novel about India's class divide by Aravind Adiga.",
                                Author = "Aravind Adiga",
                                ISBN = "978-1-84354-722-0",
                                ListPrice = 1198,
                                Price = 998,
                                Price50 = 898,
                                Price100 = 798,
                                ImageUrl = "/images/books/The_White_Tiger.jpg",
                                CategoryId = 1,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "Midnight's Children",
                                Description = "Salman Rushdie's masterpiece about India's independence.",
                                Author = "Salman Rushdie",
                                ISBN = "978-0-09-957851-4",
                                ListPrice = 1398,
                                Price = 1198,
                                Price50 = 1098,
                                Price100 = 998,
                                ImageUrl = "/images/books/MidnightsChildren.jpg",
                                CategoryId = 6,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "The Discovery of India",
                                Description = "Jawaharlal Nehru's reflections on India's history and culture.",
                                Author = "Jawaharlal Nehru",
                                ISBN = "978-0-19-562359-7",
                                ListPrice = 998,
                                Price = 798,
                                Price50 = 718,
                                Price100 = 638,
                                ImageUrl = "/images/books/Jawaharlal_Nehru_-_The_Discovery_of_India.jpg",
                                CategoryId = 4,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "My Experiments with Truth",
                                Description = "Autobiography of Mahatma Gandhi.",
                                Author = "Mahatma Gandhi",
                                ISBN = "978-81-7223-589-4",
                                ListPrice = 798,
                                Price = 598,
                                Price50 = 538,
                                Price100 = 478,
                                ImageUrl = "/images/books/The_Story_of_My_Experiments_with_Truth.jpg",
                                CategoryId = 5,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The God of Small Things",
                                Description = "Arundhati Roy's debut novel set in Kerala.",
                                Author = "Arundhati Roy",
                                ISBN = "978-0-06-097749-8",
                                ListPrice = 1098,
                                Price = 898,
                                Price50 = 798,
                                Price100 = 698,
                                ImageUrl = "/images/books/Thegodofsmallthings.jpg",
                                CategoryId = 1,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "Train to Pakistan",
                                Description = "Khushwant Singh's novel about the partition of India.",
                                Author = "Khushwant Singh",
                                ISBN = "978-81-7223-467-5",
                                ListPrice = 798,
                                Price = 598,
                                Price50 = 538,
                                Price100 = 478,
                                ImageUrl = "/images/books/Train_to_Pakistan.jpg",
                                CategoryId = 1,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The Inheritance of Loss",
                                Description = "Kiran Desai's Man Booker Prize-winning novel.",
                                Author = "Kiran Desai",
                                ISBN = "978-0-241-14346-9",
                                ListPrice = 1198,
                                Price = 998,
                                Price50 = 898,
                                Price100 = 798,
                                ImageUrl = "/images/books/Inheritance_of_loss_cover.jpg",
                                CategoryId = 1,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "A Suitable Boy",
                                Description = "Vikram Seth's epic novel set in post-independence India.",
                                Author = "Vikram Seth",
                                ISBN = "978-0-316-76974-9",
                                ListPrice = 1798,
                                Price = 1598,
                                Price50 = 1438,
                                Price100 = 1278,
                                ImageUrl = "/images/books/Asuitableboy.jpg",
                                CategoryId = 1,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The Palace of Illusions",
                                Description = "Chitra Banerjee Divakaruni's retelling of the Mahabharata from Draupadi's perspective.",
                                Author = "Chitra Banerjee Divakaruni",
                                ISBN = "978-0-7432-8479-5",
                                ListPrice = 998,
                                Price = 798,
                                Price50 = 718,
                                Price100 = 638,
                                ImageUrl = "/images/books/The_Palace_of_Illusions.jpg",
                                CategoryId = 6,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "Interpreter of Maladies",
                                Description = "Jhumpa Lahiri's Pulitzer Prize-winning short stories.",
                                Author = "Jhumpa Lahiri",
                                ISBN = "978-0-395-92720-5",
                                ListPrice = 898,
                                Price = 698,
                                Price50 = 628,
                                Price100 = 558,
                                ImageUrl = "/images/books/Interpreterofmaladiescover.jpg",
                                CategoryId = 1,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The Namesake",
                                Description = "Jhumpa Lahiri's novel about an Indian-American family.",
                                Author = "Jhumpa Lahiri",
                                ISBN = "978-0-618-48422-4",
                                ListPrice = 998,
                                Price = 798,
                                Price50 = 718,
                                Price100 = 638,
                                ImageUrl = "/images/books/The_Namesake.png",
                                CategoryId = 1,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "Shabaash! You Did It",
                                Description = "A collection of stories by Ruskin Bond.",
                                Author = "Ruskin Bond",
                                ISBN = "978-81-7223-123-4",
                                ListPrice = 598,
                                Price = 398,
                                Price50 = 358,
                                Price100 = 318,
                                ImageUrl = "/images/books/Shabaash! You Did It.png",
                                CategoryId = 1,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The Great Indian Novel",
                                Description = "Shashi Tharoor's satirical take on the Mahabharata.",
                                Author = "Shashi Tharoor",
                                ISBN = "978-0-14-027514-8",
                                ListPrice = 1098,
                                Price = 898,
                                Price50 = 798,
                                Price100 = 698,
                                ImageUrl = "/images/books/The_Great_Indian_Novel.jpg",
                                CategoryId = 6,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "Wings of Fire",
                                Description = "Autobiography of Dr. A.P.J. Abdul Kalam.",
                                Author = "A.P.J. Abdul Kalam",
                                ISBN = "978-81-7371-146-6",
                                ListPrice = 798,
                                Price = 598,
                                Price50 = 538,
                                Price100 = 478,
                                ImageUrl = "/images/books/Wings_of_Fire_by_A_P_J_Abdul_Kalam_Book_Cover.jpg",
                                CategoryId = 5,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The Argumentative Indian",
                                Description = "Amartya Sen's essays on Indian culture and identity.",
                                Author = "Amartya Sen",
                                ISBN = "978-0-7139-9687-6",
                                ListPrice = 1398,
                                Price = 1198,
                                Price50 = 1078,
                                Price100 = 958,
                                ImageUrl = "/images/books/Amartya_Kumar_Sen_-_The_argumentative_Indian_writings_on_Indian_history,_culture_and_identity.jpeg",
                                CategoryId = 2,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "India After Gandhi",
                                Description = "Ramachandra Guha's history of India post-independence.",
                                Author = "Ramachandra Guha",
                                ISBN = "978-0-06-019881-7",
                                ListPrice = 1598,
                                Price = 1398,
                                Price50 = 1258,
                                Price100 = 1118,
                                ImageUrl = "/images/books/India_After_Gandhi_Revised_and_Updated_Edition.jpg",
                                CategoryId = 4,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The Shadow Lines",
                                Description = "Amitav Ghosh's novel exploring memory and history.",
                                Author = "Amitav Ghosh",
                                ISBN = "978-0-19-566220-6",
                                ListPrice = 998,
                                Price = 798,
                                Price50 = 718,
                                Price100 = 638,
                                ImageUrl = "/images/books/The_Shadow-lines.jpg",
                                CategoryId = 1,
                                CoverTypeId = 1
                            },
                            new Product
                            {
                                Title = "The Glass Palace",
                                Description = "Amitav Ghosh's epic about Burma and India.",
                                Author = "Amitav Ghosh",
                                ISBN = "978-0-00-651409-7",
                                ListPrice = 1298,
                                Price = 1098,
                                Price50 = 988,
                                Price100 = 878,
                                ImageUrl = "/images/books/The_Glass_Palace.jpg",
                                CategoryId = 1,
                                CoverTypeId = 2
                            },
                            new Product
                            {
                                Title = "The Ministry of the Future",
                                Description = "Kim Stanley Robinson's novel on climate change, relevant to India.",
                                Author = "Kim Stanley Robinson",
                                ISBN = "978-0-316-33209-9",
                                ListPrice = 1198,
                                Price = 998,
                                Price50 = 898,
                                Price100 = 798,
                                ImageUrl = "/images/books/The_Ministry_for_the_Future.png",
                                CategoryId = 3,
                                CoverTypeId = 1
                            }
                        );
                    }

                    context.SaveChanges();
                }

                // Update existing ImageUrls to fix the path
                foreach (var product in context.Products)
                {
                    if (product.ImageUrl != null && product.ImageUrl.Contains("/images/books/"))
                    {
                        product.ImageUrl = product.ImageUrl.Replace("/images/books/", "/images/");
                    }
                }
                context.SaveChanges();

                // Seed Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!roleManager.Roles.Any())
                {
                    roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).Wait();
                    roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).Wait();
                    roleManager.CreateAsync(new IdentityRole(SD.Role_Company)).Wait();
                    roleManager.CreateAsync(new IdentityRole(SD.Role_Individual)).Wait();
                }

                // Seed Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                if (!userManager.Users.Any())
                {
                    var adminUser = new ApplicationUser
                    {
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                        Name = "Admin User",
                        PhoneNumber = "1234567890",
                        StreetAddress = "123 Admin St",
                        City = "Mumbai",
                        State = "Maharashtra",
                        PostalCode = "400001"
                    };
                    userManager.CreateAsync(adminUser, "Admin@123").Wait();
                    userManager.AddToRoleAsync(adminUser, SD.Role_Admin).Wait();

                    var employeeUser = new ApplicationUser
                    {
                        UserName = "employee@example.com",
                        Email = "employee@example.com",
                        Name = "Employee User",
                        PhoneNumber = "9876543210",
                        StreetAddress = "456 Employee Rd",
                        City = "Delhi",
                        State = "Delhi",
                        PostalCode = "110001"
                    };
                    userManager.CreateAsync(employeeUser, "Employee@123").Wait();
                    userManager.AddToRoleAsync(employeeUser, SD.Role_Employee).Wait();

                    var individualUser = new ApplicationUser
                    {
                        UserName = "user@example.com",
                        Email = "user@example.com",
                        Name = "Individual User",
                        PhoneNumber = "5555555555",
                        StreetAddress = "789 User Ave",
                        City = "Bangalore",
                        State = "Karnataka",
                        PostalCode = "560001"
                    };
                    userManager.CreateAsync(individualUser, "User@123").Wait();
                    userManager.AddToRoleAsync(individualUser, SD.Role_Individual).Wait();
                }
            }
        }
    }