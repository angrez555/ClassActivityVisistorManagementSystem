using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisistorManagementSystem.Models;

namespace VisistorManagementSystem.Data
{
    public class VisistorManagementSystemContext : DbContext
    {
        public VisistorManagementSystemContext (DbContextOptions<VisistorManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<VisistorManagementSystem.Models.Visitors> Visitors { get; set; }

        public DbSet<VisistorManagementSystem.Models.StaffNames> StaffNames { get; set; }
    }
}
