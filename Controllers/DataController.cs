using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectoprogramado.Models;
using proyectoprogramado.DBTables;

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
            string answer = db.insert_student(@"{'name':'TestStudent', 'lastname': 'TestStudent', 'identifier':'12345678', 'pin': '1234','role':'E',
                                            'universidad':'X-TEC', 'sede':'Central', 'email1':'student@test.test', 'email2': 'student2@test.test',
                                            'mobilePhone':'21123223', 'amountOfTec_colones':500}");
            return answer;
        }

        // [HttpGet("{id}")]
        // public string[] getStudent(string id){
        //     return db.getStudent("2");
        // }

    }
}