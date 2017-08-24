using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Mvc_Roles_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Roles_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

            Response.Write("User Details are accessible      :      " + user.Email);

            Response.Write("<hr>");

            ICollection<IdentityRole> roless = new ApplicationDbContext().Roles.ToList();

            foreach (var item in roless)
            {
                Response.Write(item.Name + " , ");
            }

            // Users
            Response.Write("<hr>");


            ICollection<IdentityUserRole> UserRoles = user.Roles.ToList();

            foreach (var item in UserRoles)
            {
                Response.Write(GetRoleNameFromID(item.RoleId));
            }

            return View();
        }

        private string GetRoleNameFromID(string roleId)
        {
            IdentityRole role = new ApplicationDbContext().Roles.Where(c => c.Id == roleId).First();
            return role.Name;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}