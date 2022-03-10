using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheWei_WAD_Task3.Models;

namespace CheWei_WAD_Task3.Data
{
    public class CheWei_WAD_Task3Context : DbContext
    {
        public CheWei_WAD_Task3Context (DbContextOptions<CheWei_WAD_Task3Context> options)
            : base(options)
        {
        }

        public DbSet<CheWei_WAD_Task3.Models.Course> Course { get; set; }

        public DbSet<CheWei_WAD_Task3.Models.Enrollment> Enrollment { get; set; }

        public DbSet<CheWei_WAD_Task3.Models.Student> Student { get; set; }
    }
}
