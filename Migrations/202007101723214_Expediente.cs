namespace LGCovid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expediente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expedientes", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expedientes", "Status");
        }
    }
}
