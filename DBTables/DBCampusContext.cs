using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyectoprogramado.DBTables
{
    public class DBCampusContext : DbContext
    {

        public DBCampusContext(DbContextOptions<DBCampusContext> options)
        : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:campustec-server.database.windows.net,1433;Initial Catalog=campustec-db;Persist Security Info=False;User ID=specials-admin;Password=Spec123.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public DbSet<User> User
        {
            get;
            set;
        }
        
        public DbSet<Student> Student
        {
            get;
            set;
        }
    }
}