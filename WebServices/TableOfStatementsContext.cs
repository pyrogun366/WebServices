using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebServices
{
    public class TableOfStatementsContext:DbContext
    {
        public DbSet<TableOfStatements> Tables { get; set; }

        public TableOfStatementsContext(DbContextOptions<TableOfStatementsContext> options) : base(options)
        {

        }

    }
}
