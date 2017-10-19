using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebServices
{
    public class UserTableContext:DbContext
    {
        public DbSet<UserTable> Users { get; set; }

        public UserTableContext(DbContextOptions<UserTableContext>options) : base(options)
        {

        }
        
    }
}
