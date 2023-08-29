using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinForms.Models.Context
{
    public class Context:DbContext
    {
        public Context()
        :base("name=Context"){ }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Company> companies { get; set; }
    }
}
