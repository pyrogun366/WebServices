using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebServices.Models
{
    public class ModelContext:DbContext
    {
        public DbSet<UserTable> UserTable { get; set; }
        public DbSet<TableOfStatements> TableOfStatements { get; set; }

        public ModelContext(DbContextOptions<ModelContext> options)
            :base(options)
        {

        }
        public ModelContext():base()
        {

        }
    }
}
