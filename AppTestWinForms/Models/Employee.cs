using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinForms.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string iin { get; set; }
        public int companyId { get; set; }

        public override string ToString()
        {
            return $"{firstName},{lastName},{middleName},{iin},{companyId}";
        }
    }
}