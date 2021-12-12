using ApiConNetCore.ModelsTest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Test2> Test2 { get; set; }


    }
}
