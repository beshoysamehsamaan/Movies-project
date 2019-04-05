namespace Get_Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stablev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 50),
                        username = c.String(maxLength: 50),
                        password = c.String(),
                        fname = c.String(),
                        lname = c.String(),
                        profile_picture = c.String(),
                        verified = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.email, unique: true)
                .Index(t => t.username, unique: true);
            
            CreateTable(
                "dbo.AdRequests",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 50),
                        note = c.String(),
                        image = c.String(),
                        approved = c.Int(nullable: false),
                        start_date = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.email, unique: true);
            
            CreateTable(
                "dbo.Blacklists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        reason = c.String(),
                        end_date = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Casuals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.MoviePlaylists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        playlist_id = c.Int(nullable: false),
                        movie_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Movies", t => t.movie_id, cascadeDelete: true)
                .ForeignKey("dbo.Playlists", t => t.playlist_id, cascadeDelete: true)
                .Index(t => t.playlist_id)
                .Index(t => t.movie_id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        genre = c.String(),
                        director = c.String(),
                        poster = c.String(),
                        release_date = c.String(),
                        view_count = c.Int(nullable: false),
                        rating_count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        premium_id = c.Int(nullable: false),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Premiums", t => t.premium_id, cascadeDelete: true)
                .Index(t => t.premium_id);
            
            CreateTable(
                "dbo.Premiums",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.MovieRequests",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        premium_id = c.Int(nullable: false),
                        title = c.String(),
                        note = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Premiums", t => t.premium_id, cascadeDelete: true)
                .Index(t => t.premium_id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        movie_id = c.Int(nullable: false),
                        rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Movies", t => t.movie_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.movie_id);
            
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
            DropForeignKey("dbo.Ratings", "user_id", "dbo.Users");
            DropForeignKey("dbo.Ratings", "movie_id", "dbo.Movies");
            DropForeignKey("dbo.MovieRequests", "premium_id", "dbo.Premiums");
            DropForeignKey("dbo.MoviePlaylists", "playlist_id", "dbo.Playlists");
            DropForeignKey("dbo.MoviePlaylists", "movie_id", "dbo.Movies");
            DropForeignKey("dbo.Playlists", "premium_id", "dbo.Premiums");
            DropForeignKey("dbo.Premiums", "user_id", "dbo.Users");
            DropForeignKey("dbo.PlaylistMovies", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.PlaylistMovies", "Playlist_Id", "dbo.Playlists");
            DropForeignKey("dbo.Casuals", "user_id", "dbo.Users");
            DropForeignKey("dbo.Blacklists", "user_id", "dbo.Users");
            DropForeignKey("dbo.Admins", "user_id", "dbo.Users");
            DropIndex("dbo.PlaylistMovies", new[] { "Movie_Id" });
            DropIndex("dbo.PlaylistMovies", new[] { "Playlist_Id" });
            DropIndex("dbo.Ratings", new[] { "movie_id" });
            DropIndex("dbo.Ratings", new[] { "user_id" });
            DropIndex("dbo.MovieRequests", new[] { "premium_id" });
            DropIndex("dbo.Premiums", new[] { "user_id" });
            DropIndex("dbo.Playlists", new[] { "premium_id" });
            DropIndex("dbo.MoviePlaylists", new[] { "movie_id" });
            DropIndex("dbo.MoviePlaylists", new[] { "playlist_id" });
            DropIndex("dbo.Casuals", new[] { "user_id" });
            DropIndex("dbo.Blacklists", new[] { "user_id" });
            DropIndex("dbo.AdRequests", new[] { "email" });
            DropIndex("dbo.Users", new[] { "username" });
            DropIndex("dbo.Users", new[] { "email" });
            DropIndex("dbo.Admins", new[] { "user_id" });
            DropTable("dbo.PlaylistMovies");
            DropTable("dbo.Ratings");
            DropTable("dbo.MovieRequests");
            DropTable("dbo.Premiums");
            DropTable("dbo.Playlists");
            DropTable("dbo.Movies");
            DropTable("dbo.MoviePlaylists");
            DropTable("dbo.Casuals");
            DropTable("dbo.Blacklists");
            DropTable("dbo.AdRequests");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
