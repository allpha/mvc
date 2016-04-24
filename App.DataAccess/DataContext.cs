namespace App.DataAccess
{
    using Data;
    using System.Data.Entity;

    public class DaDataContext : DbContext
    {
        public DaDataContext()
            :base("Name=ContractDatebase")
        {

        }
    
        public DbSet<Person> Persions { get; set; }
        public DbSet<PersonalType> PersionTypes { get; set; }
        public DbSet<Company> Companyes{ get; set; }
        public DbSet<Adress> Addresses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonalTypeMap());
            modelBuilder.Configurations.Add(new AddressMap());
        }
    }
}
