using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class Company
    {
        public Company()
        {
            Address = new Adress();
        }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public Adress Address { get; set; }

        public ICollection<Person> Persions { get; set; }
    }
}
