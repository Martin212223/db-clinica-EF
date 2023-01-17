namespace WindowsClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clasesCreadas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Habitaciones");
            DropTable("dbo.Clinicas");
        }
    }
}
