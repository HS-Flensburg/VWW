namespace VWW_EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monitor_hersteller_assoc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Monitors", "Hersteller_Id", c => c.Int());
            CreateIndex("dbo.Monitors", "Hersteller_Id");
            AddForeignKey("dbo.Monitors", "Hersteller_Id", "dbo.Herstellers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Monitors", "Hersteller_Id", "dbo.Herstellers");
            DropIndex("dbo.Monitors", new[] { "Hersteller_Id" });
            DropColumn("dbo.Monitors", "Hersteller_Id");
        }
    }
}
