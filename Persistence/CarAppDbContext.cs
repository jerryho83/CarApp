using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarApp.Models;
namespace CarApp.Persistence
{
    public class CarAppDbContext : DbContext
    {
        public CarAppDbContext(DbContextOptions<CarAppDbContext> options):base(options)
        {
          
        }
        DbSet<Model> Models { get; set; }
        DbSet<Makes> Makes { get; set; }
    }
}
