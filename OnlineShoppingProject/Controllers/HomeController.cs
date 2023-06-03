using OnlineShoppingProject.Context;
using OnlineShoppingProject.Entity;
using OnlineShoppingProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace OnlineShoppingProject.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)//(string name, string surname, string email, string password, string repassword, string phonenumber, string adress, string birthdate)
        {
            User users = new User();
            users.Name = model.Name;
            users.Surname = model.Surname;
            users.Email = model.Email;
            users.Password = model.Password;
            users.RePassword = model.RePassword;
            users.PhoneNumber = model.PhoneNumber;
            users.Adress = model.Adress;
            users.Birthdate = model.Birthdate;
            if (users.Password != users.RePassword)
            {
                ModelState.AddModelError("", "Şifre uyuşmuyor");
            }
            else
            {
                db.users.Add(users);
                db.SaveChanges();
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)//(string email, string password)
        {
            User users = db.users.FirstOrDefault(i => i.Email == model.Email && i.Password == model.Password);
            if (users == null && model.Password != users.Password)
            {
                return View(model);
            }
            ViewBag.Durum = true;
            return RedirectToAction("Index","Home");
        }
        public ActionResult Detail()
        {
            return View();
        }
    }
}