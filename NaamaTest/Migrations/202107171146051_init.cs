namespace NaamaTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepAndTeachModels",
                c => new
                    {
                        DepAndTeachModelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepartmentName = c.String(),
                        Address = c.String(),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.DepAndTeachModelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DepAndTeachModels");
        }
    }
}
