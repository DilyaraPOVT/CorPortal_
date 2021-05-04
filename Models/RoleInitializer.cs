using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corportal.Models
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "_Aa123456";

            string employeeEmail = "employee@gmail.com";
            string employeePassword = "_Aa123456";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("employee") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("employee"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                var admin = new IdentityUser(adminEmail);
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin"); //Куратор
                }
            }
            if (await userManager.FindByNameAsync(employeeEmail) == null)
            {
                var employee = new IdentityUser(employeeEmail);
                IdentityResult result = await userManager.CreateAsync(employee, employeePassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(employee, "employee"); //Сотрудник
                }
            }
        }
    }
}
