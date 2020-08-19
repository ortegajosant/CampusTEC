using Newtonsoft.Json.Linq;

namespace proyectoprogramado.Models{
    public class InfoModel{

        private DataModel db;
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string carne {get; set;}
        public string email1 {get; set;}
        public string email2 {get; set;}
        public string telefono {get; set;}
        public string sede {get; set;}
        public string teccolones {get; set;}

        public InfoModel(string id){
            this.db = new DataModel(new DBTables.DBCampusContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DBTables.DBCampusContext>()));
            this.update(id);
        }

        public void update(string id){
            string[] data = db.getStudent(id);
            this.nombre = data[0];
            this.apellido = data[1];
            this.carne = id;
            this.email1 = data[4];
            this.email2 = data[5];
            this.sede = data[2];
            this.telefono = data[3];
            this.teccolones = data[6];
        }
    }
}