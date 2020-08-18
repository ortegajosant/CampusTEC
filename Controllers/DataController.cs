using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectoprogramado.Models;

namespace proyectoprogramado.Controllers
{
    [ApiController]
    [Route("datarequest")]
    public class DataController : Controller
    {

        private DataModel db = new DataModel(new DBTables.DBCampusContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DBTables.DBCampusContext>()));

        [HttpPost]
        public string insert_user()
        {
            string answer = db.insert_user("{'name':'TestName', 'lastname': 'TestLast', 'identifier':'11119999', 'pin': '1234','role':'E'}");
            return answer;
        }
    }
}