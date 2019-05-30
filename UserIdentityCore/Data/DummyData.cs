using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserIdentityCore.Models;

namespace UserIdentityCore.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                             UserManager<CustomUser> userManager,
                             RoleManager<CustomRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new CustomRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new CustomRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("aa@aa.aa") == null)
            {
                var user = new CustomUser
                {
                    UserName = "aa@aa.aa",
                    Email = "aa@aa.aa",
                    Employee = new Employee
                    {
                        FirstName = "Adam",
                        LastName = "Aldridge",
                        PhoneNumber = "6902341234",
                        Address = new Address
                        {
                            Street = "Fake St",
                            City = "Vancouver",
                            Province = "BC",
                            PostalCode = "V5U K8I",
                            Country = "Canada"
                        }
                    },

                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("bb@bb.bb") == null)
            {

                var user = new CustomUser
                {
                    UserName = "bb@bb.bb",
                    Email = "bb@bb.bb",
                    Employee = new Employee
                    {
                        FirstName = "Bob",
                        LastName = "Barker",
                        PhoneNumber = "7788951456",
                        Address = new Address
                        {
                            Street = "Vermont St",
                            City = "Surrey",
                            Province = "BC",
                            PostalCode = "V1P I5T",
                            Country = "Canada"
                        }
                    },
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId2 = user.Id;
            }

            if (await userManager.FindByNameAsync("mm@mm.mm") == null)
            {
                var user = new CustomUser
                {
                    UserName = "mm@mm.mm",
                    Email = "mm@mm.mm",

                    Employee = new Employee
                    {
                        FirstName = "Mike",
                        LastName = "Myers",
                        PhoneNumber = "6572136821",
                        Address = new Address
                        {
                            Street = "Yew St",
                            City = "Vancouver",
                            Province = "BC",
                            PostalCode = "V3U E2Y",
                            Country = "Canada"
                        }
                    }
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            if (await userManager.FindByNameAsync("dd@dd.dd") == null)
            {
                var user = new CustomUser
                {

                    UserName = "dd@dd.dd",
                    Email = "dd@dd.dd",
                    Employee = new Employee
                    {
                        FirstName = "Donald",
                        LastName = "Duck",
                        PhoneNumber = "6041234567",
                        Address = new Address
                        {
                            Street = "Well St",
                            City = "Vancouver",
                            Province = "BC",
                            PostalCode = "V8U R9Y",
                            Country = "Canada",
                        }
                    },
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}
