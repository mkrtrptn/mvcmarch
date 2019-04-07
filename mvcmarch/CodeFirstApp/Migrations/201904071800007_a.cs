namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.department",
                c => new
                    {
                        did = c.Int(nullable: false, identity: true),
                        dname = c.String(),
                    })
                .PrimaryKey(t => t.did);
            
            CreateTable(
                "dbo.employees",
                c => new
                    {
                        eid = c.Int(nullable: false, identity: true),
                        ename = c.String(),
                        email = c.String(),
                        address = c.String(),
                        mobile = c.String(),
                        did = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.eid)
                .ForeignKey("dbo.department", t => t.did, cascadeDelete: true)
                .Index(t => t.did);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.employees", "did", "dbo.department");
            DropIndex("dbo.employees", new[] { "did" });
            DropTable("dbo.employees");
            DropTable("dbo.department");
        }
    }
}
