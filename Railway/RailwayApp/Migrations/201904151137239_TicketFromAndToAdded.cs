namespace RailwayApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketFromAndToAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "From", c => c.String());
            AddColumn("dbo.Tickets", "To", c => c.String());
            DropColumn("dbo.Tickets", "Path");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Path", c => c.String());
            DropColumn("dbo.Tickets", "To");
            DropColumn("dbo.Tickets", "From");
        }
    }
}
