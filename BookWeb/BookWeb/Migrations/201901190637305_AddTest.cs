namespace BookWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Test", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Test");
        }
    }
}
