namespace Computony.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ffjghjhk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Content");
        }
    }
}
