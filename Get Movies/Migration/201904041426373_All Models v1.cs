namespace Get_Movies.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllModelsv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.User",
               u => new
               {
                   id              = u.Int    (identity: true),
                   email           = u.String (nullable: false, maxLength: 50),
                   username        = u.String (nullable: false, maxLength: 50),
                   password        = u.String (nullable: false, maxLength: 50),
                   fname           = u.String (nullable: false, maxLength: 15),
                   lname           = u.String (nullable: false, maxLength: 15),
                   profile_picture = u.String (),
                   verified        = u.Int    (nullable: false),
               }
            )
            .PrimaryKey(u => u.id)
            .Index     (u=>u.email   , unique: true)
            .Index     (u=>u.username, unique: true);
            //---------------------------//
            CreateTable(
               "dbo.Blacklist",
               bl => new
               {
                   id       = bl.Int   (identity: true),
                   user_id  = bl.Int   (),
                   reason   = bl.String(nullable: false, maxLength: 50),
                   end_date = bl.String(nullable: false, maxLength: 10),
               }
            )
            .PrimaryKey(bl => bl.id)
            .ForeignKey("dbo.User", bl => bl.user_id,cascadeDelete:true)
            .Index     (bl => bl.user_id);
            //---------------------------//
            CreateTable(
               "dbo.Admin",
               a => new
               {
                   id      = a.Int(identity: true),
                   user_id = a.Int()
               }
            )
            .PrimaryKey(a => a.id)
            .ForeignKey("dbo.User", a => a.user_id, cascadeDelete: true)
            .Index     (a => a.user_id);
            //---------------------------//
            CreateTable(
               "dbo.Casual",
               c => new
               {
                   id      = c.Int(identity: true),
                   user_id = c.Int()
               }
            )
            .PrimaryKey(c => c.id)
            .ForeignKey("dbo.User", c => c.user_id,cascadeDelete:true)
            .Index(c => c.user_id);
            //---------------------------//
            CreateTable(
               "dbo.Premium",
               p => new
               {
                   id      = p.Int(nullable: false, identity: true),
                   user_id = p.Int()
               }
            )
            .PrimaryKey(p => p.id)
            .ForeignKey("dbo.User", p => p.user_id,cascadeDelete:true)
            .Index     (p => p.user_id);
            //---------------------------//
            CreateTable(
               "dbo.Playlist",
               p => new
               {
                   id         = p.Int   (nullable: false, identity: true),
                   premium_id = p.Int   (),
                   title      = p.String(nullable: false, maxLength: 50),
               }
            )
            .PrimaryKey(p => p.id)
            .ForeignKey("dbo.Premium", p => p.premium_id,cascadeDelete: true)
            .Index     (p => p.premium_id);
            //---------------------------//
            CreateTable(
               "dbo.MovieRequest",
               mr => new
               {
                   id         = mr.Int   (identity: true),
                   premium_id = mr.Int   (),
                   title      = mr.String(nullable: false, maxLength: 50),
                   note       = mr.String(maxLength: 100),
               }
            )
            .PrimaryKey(mr => mr.id)
            .ForeignKey("dbo.Premium", mr => mr.premium_id,cascadeDelete: true)
            .Index     (mr => mr.premium_id);
            //---------------------------//
            CreateTable(
               "dbo.Movie",
               m => new
               {
                   id           = m.Int   (identity: true),
                   title        = m.String(nullable: false, maxLength: 50),
                   genre        = m.String(nullable: false, maxLength: 15),
                   director     = m.String(nullable: false, maxLength: 20),
                   poster       = m.String(nullable: false),
                   release_date = m.String(nullable: false, maxLength: 10),
                   view_count   = m.Int(),
                   rating_count = m.Int()
               }
            )
            .PrimaryKey(m => m.id);
            //---------------------------//
            CreateTable(
               "dbo.Rating",
               r => new
               {
                   id       = r.Int(identity: true),
                   user_id  = r.Int(),
                   movie_id = r.Int(),
                   rating   = r.Int()
               }
            )
            .PrimaryKey(r => r.id)
            .ForeignKey("dbo.User", r => r.user_id, cascadeDelete: true)
            .Index     (r => r.user_id)
            .ForeignKey("dbo.Movie", r => r.movie_id, cascadeDelete: true)
            .Index     (r => r.movie_id);
            //---------------------------//
            CreateTable(
               "dbo.AdRequest",
               ar => new
               {
                   id         = ar.Int(identity: true),
                   email      = ar.String(nullable: false, maxLength: 50),
                   note       = ar.String(maxLength: 100),
                   image      = ar.String(),
                   approved   = ar.Int(),
                   start_date = ar.String(nullable: false, maxLength: 10),
               }
            )
            .PrimaryKey(ar => ar.id)
            .Index(ar => ar.email, unique: true);
        }

        public override void Down()
        {

        }
    }
}
