﻿namespace App.DataAccess.Maps
{
    using Data.Entity;
    using System.Data.Entity.ModelConfiguration;

    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            HasKey(a => a.Id);
            Property(one => one.Name).HasMaxLength(30).IsRequired();
        }
    }
}
