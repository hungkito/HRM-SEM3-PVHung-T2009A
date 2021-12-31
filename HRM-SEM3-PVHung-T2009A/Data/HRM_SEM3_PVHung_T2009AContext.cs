#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRM_SEM3_PVHung_T2009A.Models;

namespace HRM_SEM3_PVHung_T2009A.Data
{
    public class HRM_SEM3_PVHung_T2009AContext : DbContext
    {
        public HRM_SEM3_PVHung_T2009AContext (DbContextOptions<HRM_SEM3_PVHung_T2009AContext> options)
            : base(options)
        {
        }

        public DbSet<HRM_SEM3_PVHung_T2009A.Models.Employee> Employee { get; set; }
    }
}
