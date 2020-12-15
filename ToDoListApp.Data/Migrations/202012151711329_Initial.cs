namespace ToDoListApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 500),
                        StartingDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        ComplationDate = c.DateTime(),
                        CreationDate = c.DateTime(nullable: false),
                        HasDone = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
