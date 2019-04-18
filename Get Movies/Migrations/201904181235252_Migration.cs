namespace Get_Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 50),
                        Username = c.String(maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 200),
                        First_Name = c.String(nullable: false, maxLength: 20),
                        Last_Name = c.String(nullable: false, maxLength: 20),
                        Profile_Picture = c.String(),
                        Verified = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.AdRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 50),
                        Note = c.String(maxLength: 200),
                        Image = c.String(nullable: false, maxLength: 100),
                        Approved = c.Int(nullable: false),
                        Start_Date = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Blacklists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                        Reason = c.String(maxLength: 50),
                        End_Date = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id, unique: true);
            
            CreateTable(
                "dbo.Casuals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id, unique: true);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre_ = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imdb_Id = c.String(maxLength: 100),
                        Title = c.String(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                        Director = c.String(nullable: false),
                        Poster = c.String(nullable: false),
                        Youtube_Trailer = c.String(),
                        Release_Year = c.Int(nullable: false),
                        Release_Date = c.DateTime(nullable: false),
                        Description = c.String(nullable: false),
                        Duration = c.Int(nullable: false),
                        Views_Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Imdb_Id, unique: true)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Premium_Id = c.Int(),
                        Title = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Premiums", t => t.Premium_Id)
                .Index(t => t.Premium_Id);
            
            CreateTable(
                "dbo.Premiums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id, unique: true);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                        Movie_Id = c.Int(),
                        Rating_ = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.MoviePlaylists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Playlist_Id = c.Int(),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .ForeignKey("dbo.Playlists", t => t.Playlist_Id)
                .Index(t => t.Playlist_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.MovieRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Premium_Id = c.Int(),
                        Title = c.String(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Premiums", t => t.Premium_Id)
                .Index(t => t.Premium_Id);
            
            CreateTable(
                "dbo.ViewLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(),
                        Movie_Id = c.Int(),
                        Time_Stamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id, unique: true)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.PlaylistMovies",
                c => new
                    {
                        Playlist_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Playlist_Id, t.Movie_Id })
                .ForeignKey("dbo.Playlists", t => t.Playlist_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Playlist_Id)
                .Index(t => t.Movie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ViewLogs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ViewLogs", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.MovieRequests", "Premium_Id", "dbo.Premiums");
            DropForeignKey("dbo.MoviePlaylists", "Playlist_Id", "dbo.Playlists");
            DropForeignKey("dbo.MoviePlaylists", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Ratings", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Ratings", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Playlists", "Premium_Id", "dbo.Premiums");
            DropForeignKey("dbo.Premiums", "User_Id", "dbo.Users");
            DropForeignKey("dbo.PlaylistMovies", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.PlaylistMovies", "Playlist_Id", "dbo.Playlists");
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Casuals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Blacklists", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Admins", "User_Id", "dbo.Users");
            DropIndex("dbo.PlaylistMovies", new[] { "Movie_Id" });
            DropIndex("dbo.PlaylistMovies", new[] { "Playlist_Id" });
            DropIndex("dbo.ViewLogs", new[] { "Movie_Id" });
            DropIndex("dbo.ViewLogs", new[] { "User_Id" });
            DropIndex("dbo.MovieRequests", new[] { "Premium_Id" });
            DropIndex("dbo.MoviePlaylists", new[] { "Movie_Id" });
            DropIndex("dbo.MoviePlaylists", new[] { "Playlist_Id" });
            DropIndex("dbo.Ratings", new[] { "Movie_Id" });
            DropIndex("dbo.Ratings", new[] { "User_Id" });
            DropIndex("dbo.Premiums", new[] { "User_Id" });
            DropIndex("dbo.Playlists", new[] { "Premium_Id" });
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.Movies", new[] { "Imdb_Id" });
            DropIndex("dbo.Casuals", new[] { "User_Id" });
            DropIndex("dbo.Blacklists", new[] { "User_Id" });
            DropIndex("dbo.AdRequests", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Admins", new[] { "User_Id" });
            DropTable("dbo.PlaylistMovies");
            DropTable("dbo.ViewLogs");
            DropTable("dbo.MovieRequests");
            DropTable("dbo.MoviePlaylists");
            DropTable("dbo.Ratings");
            DropTable("dbo.Premiums");
            DropTable("dbo.Playlists");
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
            DropTable("dbo.Casuals");
            DropTable("dbo.Blacklists");
            DropTable("dbo.AdRequests");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
