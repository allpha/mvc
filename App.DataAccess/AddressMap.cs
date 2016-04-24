namespace App.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using App.Data;
    using System.Data.Entity.ModelConfiguration;

    public class AddressMap : EntityTypeConfiguration<Adress>
    {

        public AddressMap()
        {
            HasKey(one => one.Id);
            Property(a => a.State).HasMaxLength(2).HasColumnName("State");
        }
    }
}
