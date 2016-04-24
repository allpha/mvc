namespace App.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using App.Data;
    using System.Data.Entity.ModelConfiguration;

    public class PersonMap : EntityTypeConfiguration<Person>
    {

        public PersonMap()
        {
            HasKey(one => one.PersonID);
            Property(one => one.Name).HasMaxLength(30).IsRequired();
            HasRequired(a => a.PersonType)
              .WithMany(a => a.Persons)
              .HasForeignKey(a => a.PersionTypeId);
        }
    }
}
