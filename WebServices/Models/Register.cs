using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServices.Models
{
    public class Register
    {
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  int AcountNumber { get; set; }
        public  string Email { get; set; }
        public  DateTime DOB { get; set; }
        public  string GroupName { get; set; }
        public  string Password { get; set; }
        public  string Login { get; set; }
    }
}
