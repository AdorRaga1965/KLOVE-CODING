using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KLOVE_ASSIGNMENT.Models;

namespace KLOVE_ASSIGNMENT.Models
{
    public class KLOVE_ASSIGNMENTContext : DbContext
    {
        public KLOVE_ASSIGNMENTContext (DbContextOptions<KLOVE_ASSIGNMENTContext> options)
            : base(options)
        {
        }

        public DbSet<KLOVE_ASSIGNMENT.Models.Department> Department { get; set; }

        public DbSet<KLOVE_ASSIGNMENT.Models.Employee> Employee { get; set; }

        public DbSet<KLOVE_ASSIGNMENT.Models.Employeedepartment> Employeedepartment { get; set; }
    }
}
