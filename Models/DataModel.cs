using System;
using Microsoft.Data.SqlClient;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using proyectoprogramado.DBTables;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace proyectoprogramado.Models
{
    public class DataModel
    {
        private DBCampusContext context;

        public DataModel(DBCampusContext contextDB)
        {
            context = contextDB;
        }

        private int insert_user(string request)
        {
            JObject request_json = JObject.Parse(request);

            var user = new User();
            user.name = request_json["name"].ToString();
            user.lastName = request_json["lastname"].ToString();
            user.pin = request_json["pin"].ToString();
            user.identifier = request_json["identifier"].ToString();
            user.role = request_json["role"].ToString();
            user.Active = true;

            context.Add(user);
            context.SaveChanges();


            return user.id;

        }

        public string insert_student(string request)
        {
            JObject request_json = JObject.Parse(request);

            var student = new Student();
            var id_user = insert_user(request);
            student.idUser = id_user;
            student.universidad = request_json["universidad"].ToString();
            student.sede = request_json["sede"].ToString();
            student.email1 = request_json["email1"].ToString();
            student.email2 = request_json["email2"].ToString();
            student.mobilePhone = request_json["mobilePhone"].ToString();
            student.amountOfTec_colones = Int32.Parse(request_json["amountOfTec_colones"].ToString());


            context.Add(student);
            context.SaveChanges();

            return confirm_insert();
        }


        private string confirm_insert()
        {
            return "All is okay";
        }
    }
}