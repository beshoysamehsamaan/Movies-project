namespace Get_Movies.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    email = c.String(nullable: false),
                    username = c.String(nullable: false),
                    password = c.String(),
                    fname = c.String(),
                    lname = c.String(),
                    profile_picture = c.String(),
                    verified = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "username" });
            DropIndex("dbo.Users", new[] { "email" });
            DropTable("dbo.Users");
        }
    }
}
