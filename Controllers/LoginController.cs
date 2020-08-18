using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectoprogramado.Models;

namespace proyectoprogramado.Controllers
{
    public class LoginController : Controller
    {

        private LoginModel model;

        public LoginController (){
            LoginModel model = new LoginModel();
            this.set_model(model);
        }

        public void set_model(LoginModel model){
            this.model = model;
        }

        public bool login_access(string id, string password){
            bool result = model.check_user(id, password);
            return result; 
        }

        [HttpPost]
        public IActionResult Login(string id, string password)
        {
            TempData["id"] = id;
            TempData["password"] = password;
            bool result = login_access(id, password);
            if(result == true)
                return RedirectToAction("Perfil", "Login");
            else
                return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Perfil()
        {
            string param1 = TempData["id"].ToString();
            string param2 = TempData["password"].ToString();
            TempData["param1"] = param1;
            TempData["param2"] = param2;
            return View();
        }

    }
}