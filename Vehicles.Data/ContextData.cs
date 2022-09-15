using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Data
{
    public class ContextData : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SERVER_DB_HOST;Initial Catalog=vehicle_database;Persist Security Info=True;User ID=SERVER_DB_USER;Password=SERVER_DB_PASS");
        }
    }
}
