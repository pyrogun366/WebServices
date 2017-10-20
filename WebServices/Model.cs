using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServices
{
    public class Model:DbContext
    {
        public Model(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<TableOfStatements> TableOfStat { get; set; }


    }
}
