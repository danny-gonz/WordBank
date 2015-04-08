namespace WordBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Terms",
                c => new
                    {
                        TermId = c.Int(nullable: false, identity: true),
                        Word = c.String(nullable: false, maxLength: 30),
                        Definition = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.TermId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Terms");
        }
    }
}
