namespace BookWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Authors");
        }
    }
}
