namespace App.DataAccess
{
    using Data;
    using Data.Entity;
    using Maps;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext()
            :base("Name=eSWASContext")
        {
            base.Database.CommandTimeout = 360;
            base.Configuration.LazyLoadingEnabled = true;
            base.Configuration.UseDatabaseNullSemantics = true;
        }

        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Landfill> Landfills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new LandfillMap());
        }
    }
}
