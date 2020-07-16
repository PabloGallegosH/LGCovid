namespace LGCovid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Expediente2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Expedientes", "CuandoSeRealizoTest", c => c.DateTime(nullable: true));
            AlterColumn("dbo.Expedientes", "FechaInicioIncapacidad", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expedientes", "FechaInicioIncapacidad", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Expedientes", "CuandoSeRealizoTest", c => c.DateTime(nullable: false));
        }
    }
}
