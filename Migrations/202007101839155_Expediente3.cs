namespace LGCovid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expediente3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Expedientes", "DiasIncapacidad", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expedientes", "DiasIncapacidad", c => c.Int(nullable: false));
        }
    }
}
