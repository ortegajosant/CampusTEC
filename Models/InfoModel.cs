namespace proyectoprogramado.Models{
    public class InfoModel{
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string carne {get; set;}
        public string email1 {get; set;}
        public string email2 {get; set;}
        public string telefono {get; set;}
        public string sede {get; set;}
        public string teccolones {get; set;}
        public string [] cursos {get; set;}
        public string foto {get; set;}

        public InfoModel(string id){
            this.nombre = "Esteban";
            this.apellido = "Campos";
            this.carne = id;
            this.email1 = "estebandcg1999";
            this.email2 = "este0111";
            this.telefono = "84473498";
            this.sede = "central";
            this.teccolones = "teccolones";
            string[] cursos = {"Arqui I - Grupo 2", "Espe - Grupo 1"};
            this.cursos = cursos;
            this.foto = "foto";
        }

        public void update(string id){
            this.nombre = "Esteban";
            this.apellido = "Campos";
            this.carne = id;
            this.email1 = "estebandcg1999";
            this.email2 = "este0111";
            this.telefono = "84473498";
            this.sede = "central";
            this.teccolones = "teccolones";
            string[] cursos = {"Arqui I - Grupo 2", "Espe - Grupo 1"};
            this.cursos = cursos;
            this.foto = "foto";
        }
    }
}