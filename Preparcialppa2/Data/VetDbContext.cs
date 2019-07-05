using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Preparcialppa2.Models;

namespace Preparcialppa2.Data
{
    public class VetDbContext : DbContext
    {
        public VetDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Room> Rooms { get; set; }
    }
}