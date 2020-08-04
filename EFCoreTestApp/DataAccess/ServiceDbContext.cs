using EFCoreTestApp.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTestApp.DataAccess
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ClassroomModel> VehicleMakes { get; set; }
        public DbSet<StudentModel> VehicleModels { get; set; }
    }
}
