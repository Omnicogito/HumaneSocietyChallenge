using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HumaneSociety.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
    }

    public class AnimalDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}