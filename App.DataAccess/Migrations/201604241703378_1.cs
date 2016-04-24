namespace App.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Landfills", "RegionId", "dbo.Regions");
            AddForeignKey("dbo.Landfills", "RegionId", "dbo.Regions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Landfills", "RegionId", "dbo.Regions");
            AddForeignKey("dbo.Landfills", "RegionId", "dbo.Regions", "Id", cascadeDelete: true);
        }
    }
}
