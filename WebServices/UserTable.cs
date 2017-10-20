using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebServices
{
    public class UserTable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public int AcountNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string GroupName { get; set; }
    }
}
