using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectoprogramado.Models;

namespace proyectoprogramado.Controllers
{
    public class InfoController : Controller
    {               
        private InfoModel info;

        [HttpGet]
        public IActionResult Profile()
        {
            string id = TempData["id"].ToString();
            if(this.info == null)
                this.info = new InfoModel(id);
            else
                this.info.update(id);
            return View(this.info);
        }        
    }
}