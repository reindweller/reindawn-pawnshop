using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Reindawn.Domain.Models;
using Reindawn.Domain.Enumerations;

namespace Reindawn.Repository.Context
{
    public class ReindawnInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReindawnContext>
    {
        protected override void Seed(ReindawnContext context)
        {

            if (!(context.Users.Any(u => u.Email == "reindweller@gmail.com")))
            {
                var roleManager = new RoleManager<Role, Guid>(new CustomRoleStore(context));
                roleManager.Create(new Role(Guid.NewGuid(), "admin"));
                roleManager.Create(new Role(Guid.NewGuid(), "user"));

                var userStore = new CustomUserStore(context);
                var userManager = new UserManager<User, Guid>(userStore);

                var user = new User { UserName = "reindweller@gmail.com", Email = "reindweller@gmail.com" };
                var ssss = userManager.Create(user, "123456");


                //var pass = new Microsoft.AspNet.Identity.PasswordHasher().HashPassword("123456");
                //var userToInsert = new User
                //{
                //    Email = "reindweller@gmail.com",
                //    EmailConfirmed = true,
                //    UserName = "reindawn"
                //};
                //userManager.Create(userToInsert, "123456");

                userManager.AddToRole(user.Id, "admin");
            }


            //var roles = new List<Role>
            //{
            //new Role{ Name = "admin" },
            //new Role{ Name = "user" },
            //};

            //roles.ForEach(s => context.Roles.Add(s));
            //context.SaveChanges();


            //var pass = new Microsoft.AspNet.Identity.PasswordHasher().HashPassword("123456");
            //var users = new List<User>
            //{
            //new User{Email= "reindweller@gmail.com",EmailConfirmed= true, PasswordHash = pass, UserName = "reindawn"}
            //};

            //users.ForEach(s => context.Users.Add(s));
            //context.SaveChanges();


            //var userRoles = new List<CustomUserRole>
            //{
            //new Role{ Name = "admin" },
            //new Role{ Name = "user" },
            //};


            //ApplicationUser.
            //roles.ForEach(s => context.userrole.Add(s));
            //context.SaveChanges();
        }
        
}
}
