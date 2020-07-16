namespace LGCovid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expediente1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Expedientes", "FechaConsulta", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expedientes", "FechaConsulta", c => c.DateTime(nullable: false));
        }
    }
}
