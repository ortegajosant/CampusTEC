using System;
using proyectoprogramado.Models;

namespace proyectoprogramado.Models
{

    public class LoginModel
    {

        private DataModel db;

        public LoginModel()
        {
            db = new DataModel(new DBTables.DBCampusContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DBTables.DBCampusContext>()));
        }

        public bool check_user(string id, string password)
        {

            bool creds = db.getAccess(id, password);

           return creds;
        }

    }
}

