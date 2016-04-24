using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class Person
    {
        public Person()
        {
            Address = new Adress();
        }

        public int PersonID { get; set; }

        public string Name { get; set; }

        public Adress Address { get; set; }

        public int PersionTypeId { get; set; }

        public virtual PersonalType PersonType { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

    }
}
