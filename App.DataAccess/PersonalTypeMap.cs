namespace App.DataAccess
{
    using App.Data;
    using System.Data.Entity.ModelConfiguration;

    public class PersonalTypeMap : EntityTypeConfiguration<PersonalType>
    {

        public PersonalTypeMap()
        {
            HasKey(one => one.PersonalTypeId);
            Property(one => one.Name).HasMaxLength(30).IsRequired();
        }
    }
}
