namespace RailwayApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainIdAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Train_Id", "dbo.Trains");
            DropIndex("dbo.Tickets", new[] { "Train_Id" });
            RenameColumn(table: "dbo.Tickets", name: "Train_Id", newName: "TrainId");
            AlterColumn("dbo.Tickets", "TrainId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Tickets", "TrainId");
            AddForeignKey("dbo.Tickets", "TrainId", "dbo.Trains", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "TrainId", "dbo.Trains");
            DropIndex("dbo.Tickets", new[] { "TrainId" });
            AlterColumn("dbo.Tickets", "TrainId", c => c.Guid());
            RenameColumn(table: "dbo.Tickets", name: "TrainId", newName: "Train_Id");
            CreateIndex("dbo.Tickets", "Train_Id");
            AddForeignKey("dbo.Tickets", "Train_Id", "dbo.Trains", "Id");
        }
    }
}
