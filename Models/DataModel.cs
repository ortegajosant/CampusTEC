using System;
using Microsoft.Data.SqlClient;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using proyectoprogramado.DBTables;

namespace proyectoprogramado.Models
{
    public class DataModel
    {
        private readonly DBCampusContext context;

        public DataModel(DBCampusContext contextDB)
        {
            context = contextDB;
        }

        public string insert_user(string request)
        {
            JObject request_json = JObject.Parse(request);

            var user = new User();
            user.id = 1;
            user.name = request_json["name"].ToString();
            user.lastName = request_json["lastname"].ToString();
            user.pin = request_json["pin"].ToString();
            user.identifier = request_json["identifier"].ToString();
            user.role = request_json["role"].ToString();
            user.Active = true;

            context.Add(user);
            context.SaveChanges();


            return confirm_insert();

        }
        private string confirm_insert()
        {
            return "All is okay";
        }
    }
}