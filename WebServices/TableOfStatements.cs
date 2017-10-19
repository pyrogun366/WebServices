using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServices
{
    public class TableOfStatements
    {

        public int AccountNumber { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string TypeOfStatement { get; set; }
        public bool Verification { get; set; }
    }
}
