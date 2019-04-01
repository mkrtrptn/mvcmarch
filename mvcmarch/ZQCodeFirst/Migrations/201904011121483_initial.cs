namespace ZQCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.products",
                c => new
                    {
                        prodid = c.Int(nullable: false, identity: true),
                        prodname = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.prodid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.products");
        }
    }
}
