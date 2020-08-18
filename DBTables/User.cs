using System;

namespace proyectoprogramado.DBTables
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string identifier { get; set; }
        public string pin { get; set; }
        public string role { get; set; }
        public bool Active { get; set; }
    }

}