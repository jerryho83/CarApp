using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CarApp.Persistence
{
    public class CarAppDbContext : DbContext
    {
        public CarAppDbContext(DbContextOptions<CarAppDbContext> options):base(options)
        {
          
        }
        DbSet<Model> Models { get; set; }
        DbSet<Make> Makes { get; set; }
    }
}
