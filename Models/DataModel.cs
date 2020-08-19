using System;
using Microsoft.Data.SqlClient;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using proyectoprogramado.DBTables;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace proyectoprogramado.Models
{
    public class DataModel
    {
        private readonly DBCampusContext context;

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

        public string[] getStudent(string id)
        {
            var studne = from s in context.Student
                         join u in context.User on s.idUser equals u.id
                         where u.identifier == id
                         select new
                         {
                             name = u.name,
                             lastname = u.lastName,
                             email1 = s.email1,
                             email2 = s.email2,
                             phone = s.mobilePhone,
                             campus = s.sede,
                             tecColones = s.amountOfTec_colones
                         };
            //studne.First().ToString().Replace("=", ":")
            string[] result = new string[7];
            foreach (var item in studne)
            {
                result[0] = item.name;
                result[1] = item.lastname;
                result[2] = item.campus;
                result[3] = item.phone;
                result[4] = item.email1;
                result[5] = item.email2;
                result[6] = item.tecColones.ToString();
            }
            return result;
        }

        public bool getAccess(string id, string password)
        {

            var user = from s in context.User
                       where s.identifier == id
                       && s.pin == password
                       select s;

            if (user.Any())
            {
                return true;
            }

            return false;
        }

        private string confirm_insert()
        {
            return "All is okay";
        }
    }
}