using MvcCups.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MvcCups.Models;

namespace MvcCups.Data
{
    public class MvcCupContext : DbContext
    {
        public MvcCupContext(DbContextOptions<MvcCupContext> options)
              : base(options)
        {
        }

        public DbSet<Cup> Movie { get; set; }
    }
}
