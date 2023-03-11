using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TQKho.Models;

namespace TQKho.Contexts
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Shelf> Shelfs { get; set; }
        public string dbPath { get; }

        public DataContext()
        {
            dbPath = "products.db";
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
}
