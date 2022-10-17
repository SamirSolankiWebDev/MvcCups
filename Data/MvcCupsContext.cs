using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCups.Models;

namespace MvcCups.Data
{
    public class MvcCupsContext : DbContext
    {
        public MvcCupsContext(DbContextOptions<MvcCupsContext> options)
              : base(options)
        {
        }

        public DbSet<Cup> Cup { get; set; }
    }
}
