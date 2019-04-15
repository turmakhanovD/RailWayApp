namespace RailwayApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedFromToFromCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "FromCity", c => c.String());
            AddColumn("dbo.Tickets", "ToCity", c => c.String());
            DropColumn("dbo.Tickets", "From");
            DropColumn("dbo.Tickets", "To");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "To", c => c.String());
            AddColumn("dbo.Tickets", "From", c => c.String());
            DropColumn("dbo.Tickets", "ToCity");
            DropColumn("dbo.Tickets", "FromCity");
        }
    }
}
