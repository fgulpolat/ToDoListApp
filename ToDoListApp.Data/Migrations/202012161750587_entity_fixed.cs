namespace ToDoListApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entity_fixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "StartingDate", c => c.DateTime());
            AlterColumn("dbo.Tasks", "DueDate", c => c.DateTime());
            AlterColumn("dbo.Tasks", "CreationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tasks", "DueDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tasks", "StartingDate", c => c.DateTime(nullable: false));
        }
    }
}
