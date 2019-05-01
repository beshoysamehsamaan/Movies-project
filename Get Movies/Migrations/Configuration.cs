namespace Get_Movies.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Get_Movies.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Get_Movies.Data.GetMoviesDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(Get_Movies.Data.GetMoviesDatabaseContext context)
        {
            User u1 = new User
            {
                Email = "user1@gmail.com",
                Username = "user1",
                Password = "12345678",
                First_Name = "user 1",
                Last_Name = "xxxx",
                Profile_Picture = "https://i.ibb.co/FX6z06g/A.png",
                Verified = 0
            };
            u1.Add();
            new Admin() { User_Id = u1.Id }.Add();

            User u2 = new User
            {
                Email = "user2@gmail.com",
                Username = "user2",
                Password = "12345678",
                First_Name = "user 2",
                Last_Name = "xxxx",
                Profile_Picture = "https://i.ibb.co/K6TM0xG/P.png",
                Verified = 0
            };
            u2.Add();
            Premium prem = new Premium() { User_Id = u2.Id }; prem.Add();

            User u3 = new User
            {
                Email = "user3@gmail.com",
                Username = "user3",
                Password = "12345678",
                First_Name = "user 3",
                Last_Name = "xxxx",
                Profile_Picture = "https://i.ibb.co/SxbQLpv/C.png",
                Verified = 0
            };
            u3.Add();
            new Casual() { User_Id = u3.Id }.Add();

            User u4 = new User
            {
                Email = "user4@gmail.com",
                Username = "user4",
                Password = "12345678",
                First_Name = "user 4",
                Last_Name = "xxxx",
                Profile_Picture = "https://i.ibb.co/jrxVvKy/B.png",
                Verified = 0
            };
            u4.Add();
            new Blacklist() { User_Id = u4.Id, Reason = "Ban Testing", End_Date = "04/12/2019" }.Add();

            Genre gen1 = new Genre() { Genre_ = "Action" }; gen1.Add();
            Genre gen2 = new Genre() { Genre_ = "Adventure" }; gen2.Add();
            Genre gen3 = new Genre() { Genre_ = "Animation" }; gen3.Add();
            Genre gen4 = new Genre() { Genre_ = "Biography" }; gen4.Add();
            Genre gen5 = new Genre() { Genre_ = "Comedy" }; gen5.Add();
            Genre gen6 = new Genre() { Genre_ = "Crime" }; gen6.Add();
            Genre gen7 = new Genre() { Genre_ = "Documentary" }; gen7.Add();
            Genre gen8 = new Genre() { Genre_ = "Drama" }; gen8.Add();
            Genre gen9 = new Genre() { Genre_ = "Family" }; gen9.Add();
            Genre gen10 = new Genre() { Genre_ = "Fantasy" }; gen10.Add();
            Genre gen11 = new Genre() { Genre_ = "Film-Noir" }; gen11.Add();
            Genre gen12 = new Genre() { Genre_ = "History" }; gen12.Add();
            Genre gen13 = new Genre() { Genre_ = "Horror" }; gen13.Add();
            Genre gen14 = new Genre() { Genre_ = "Music" }; gen14.Add();
            Genre gen15 = new Genre() { Genre_ = "Musical" }; gen15.Add();
            Genre gen16 = new Genre() { Genre_ = "Mystery" }; gen16.Add();
            Genre gen17 = new Genre() { Genre_ = "Romance" }; gen17.Add();
            Genre gen18 = new Genre() { Genre_ = "Sci-Fi" }; gen18.Add();
            Genre gen19 = new Genre() { Genre_ = "Sport" }; gen19.Add();
            Genre gen20 = new Genre() { Genre_ = "Thriller" }; gen20.Add();
            Genre gen21 = new Genre() { Genre_ = "War" }; gen21.Add();
            Genre gen22 = new Genre() { Genre_ = "Western" }; gen22.Add();

            Movie m1 = new Movie()
            {
                Imdb_Id = "tt3513498",
                Title = "The Lego Movie 2: The Second Part",
                Genre_Id = gen1.Id,
                Director = "Mike Mitchell",
                Poster = "http://image.tmdb.org/t/p/original//8kPozGb4BDrcWBSsGPrkULG2tP9.jpg",
                Youtube_Trailer = "XvHSlHhh1gk",
                Release_Date = DateTime.ParseExact("08/02/2019", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2019,
                Description = "It\'s been five years since everything was awesome and the citizens are facing a huge new threat: Lego Duplo invaders from outer space, wrecking everything faster than they can rebuild.",
                Duration = 107,
                Views_Count = 0
            };
            m1.Add();
            Movie m2 = new Movie()
            {
                Imdb_Id = "tt6878820",
                Title = "Z-O-M-B-I-E-S",
                Genre_Id = gen14.Id,
                Director = "Paul Hoen",
                Poster = "http://image.tmdb.org/t/p/original//qF1xJzdLOzwhizgOngwRI4sSrN7.jpg",
                Youtube_Trailer = "VSC7AjafRPA",
                Release_Date = DateTime.ParseExact("16/02/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "Students from Zombietown are transferred to a high school in a suburban town preoccupied with uniformity, traditions and pep rallies.",
                Duration = 94,
                Views_Count = 0
            };
            m2.Add();
            Movie m3 = new Movie()
            {
                Imdb_Id = "tt6791096",
                Title = "I Feel Pretty",
                Genre_Id = gen17.Id,
                Director = "Abby Kohn, Marc Silverstein",
                Poster = "http://image.tmdb.org/t/p/original//3Zb4Du20mvKl0jlOtQ6lCFhpiiT.jpg",
                Youtube_Trailer = "cVx9EFK3DWE",
                Release_Date = DateTime.ParseExact("20/04/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "Renee Bennett (Schumer) knows what it\'s like to be average in a world of the genetically blessed. After falling off an exercise bike and banging her head, she believes a spell has suddenly made her gorgeous. Except to everyone else, she looks exactly the same. Renee\'s new confidence suddenly sees her climbing the ranks at the cosmetics company she works for, getting the respect of her idol and boss, Avery LeClaire (Williams). Ultimately Renee realizes \'the spell\' has lifted, but through the process learns true beauty is not skin deep.",
                Duration = 110,
                Views_Count = 0
            };
            m3.Add();
            Movie m4 = new Movie()
            {
                Imdb_Id = "tt5709188",
                Title = "A-X-L",
                Genre_Id = gen2.Id,
                Director = "Oliver Daly",
                Poster = "http://image.tmdb.org/t/p/original//l1nYo0yzKjf84atnBDbx0do16vQ.jpg",
                Youtube_Trailer = "--8nr2kt4uk",
                Release_Date = DateTime.ParseExact("24/08/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "A.X.L. is a top-secret, robotic dog who develops a special friendship with Miles and will go to any length to protect his new companion.",
                Duration = 98,
                Views_Count = 0
            };
            m4.Add();
            Movie m5 = new Movie()
            {
                Imdb_Id = "tt5580266",
                Title = "The Hate U Give",
                Genre_Id = gen8.Id,
                Director = "George Tillman Jr.",
                Poster = "http://image.tmdb.org/t/p/original//5AijK8OxcTzuT8z6aEcc3kO96eG.jpg",
                Youtube_Trailer = "3MM8OkVT0hw",
                Release_Date = DateTime.ParseExact("19/10/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "Starr witnesses the fatal shooting of her childhood best friend Khalil at the hands of a police officer. Now, facing pressure from all sides of the community, Starr must find her voice and stand up for what\'s right.",
                Duration = 133,
                Views_Count = 0
            };
            m5.Add();
            Movie m6 = new Movie()
            {
                Imdb_Id = "tt9027304",
                Title = "X",
                Genre_Id = gen8.Id,
                Director = "Yara Shahidi",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/09/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "X, a young black kid, wanders through a day in Los Angeles facing the city\'s beauty and ugliness. As the day progresses, X stands in as the \"everyman\" while confronting the difficult realities of adolescence while black in America.",
                Duration = 115,
                Views_Count = 0
            };
            m6.Add();
            Movie m7 = new Movie()
            {
                Imdb_Id = "tt5618160",
                Title = "3",
                Genre_Id = gen16.Id,
                Director = "Lou Simon",
                Poster = "http://image.tmdb.org/t/p/original//plV29unthnG9nFtgwNzDD2chZtG.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("07/08/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "A man and a woman kidnap her rapist in order to extract a confession, come hell or - hell.",
                Duration = 80,
                Views_Count = 0
            };
            m7.Add();
            Movie m8 = new Movie()
            {
                Imdb_Id = "tt6142496",
                Title = "6 Balloons",
                Genre_Id = gen12.Id,
                Director = "Marja-Lewis Ryan",
                Poster = "http://image.tmdb.org/t/p/original//vfUsnZe5CK3SIqpJq1sA5rUJcRi.jpg",
                Youtube_Trailer = "9uF4XjvS_Z0",
                Release_Date = DateTime.ParseExact("06/04/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "A woman (Jacobson) learns her brother (Franco) has relapsed on heroin.",
                Duration = 74,
                Views_Count = 0
            };
            m8.Add();
            Movie m9 = new Movie()
            {
                Imdb_Id = "tt5580036",
                Title = "I, Tonya",
                Genre_Id = gen5.Id,
                Director = "Craig Gillespie",
                Poster = "http://image.tmdb.org/t/p/original//cW2tkTM1RoCTE4Orbx5ELNThlvq.jpg",
                Youtube_Trailer = "iY2NLPKpK1Q",
                Release_Date = DateTime.ParseExact("19/01/2018", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2018,
                Description = "Competitive ice skater Tonya Harding rises amongst the ranks at the U.S. Figure Skating Championships, but her future in the activity is thrown into doubt when her ex-husband intervenes.",
                Duration = 120,
                Views_Count = 0
            };
            m9.Add();
            Movie m10 = new Movie()
            {
                Imdb_Id = "tt5233558",
                Title = "The Death and Life of Marsha P. Johnson",
                Genre_Id = gen17.Id,
                Director = "David France",
                Poster = "http://image.tmdb.org/t/p/original//fA16bfUd00jNbcdqheUTVnqcFBL.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("06/10/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "Victoria Cruz investigates the mysterious 1992 death of black gay rights activist and Stonewall veteran, Marsha P. Johnson. Using archival interviews with Johnson, and new interviews with Johnson\'s family, friends and fellow activists.",
                Duration = 105,
                Views_Count = 0
            };
            m10.Add();
            Movie m11 = new Movie()
            {
                Imdb_Id = "tt6155194",
                Title = "Best F(r)iends: Volume 1",
                Genre_Id = gen8.Id,
                Director = "Justin MacGregor",
                Poster = "http://image.tmdb.org/t/p/original//tdCHGB6Syji3xg8LRvv5tmvPtRY.jpg",
                Youtube_Trailer = "ZLSgfjKbYCc",
                Release_Date = DateTime.ParseExact("30/09/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "When a drifter (Greg Sestero) is taken in by a peculiar mortician (Tommy Wiseau), the two hatch an underground enterprise off the back of the mortician\'s old habits. But greed, hatred, and jealousy soon come in turn, and their efforts unravel, causing the drifter to run off with the spoils and leaving the mortician adrift. An expedition across the South West introduces wild and crazy characters through a series of twisted and dark foibles as both men learn a valuable lesson about friendship and loyalty.",
                Duration = 108,
                Views_Count = 0
            };
            m11.Add();
            Movie m12 = new Movie()
            {
                Imdb_Id = "tt4279116",
                Title = "Alien Invasion: S.U.M.1",
                Genre_Id = gen18.Id,
                Director = "Christian Pasquariello",
                Poster = "http://image.tmdb.org/t/p/original//bZCjHladJ7miq1TlHb4MR0FQh0n.jpg",
                Youtube_Trailer = "fteYxvnznaw",
                Release_Date = DateTime.ParseExact("01/12/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "An aggressive race of aliens took over Planet Earth and humanity\'s at its end, living in giant bunkers below ground. Young Military rookie S.U.M.1 (Iwan Rheon) is sent to the surface to save a group of unprotected survivors.",
                Duration = 92,
                Views_Count = 0
            };
            m12.Add();
            Movie m13 = new Movie()
            {
                Imdb_Id = "tt4685428",
                Title = "1 Buck",
                Genre_Id = gen20.Id,
                Director = "Fabien Dufils",
                Poster = "http://image.tmdb.org/t/p/original//C0A1A9J1asbc8GNc6ww8ISuihi.jpg",
                Youtube_Trailer = "lH3Cu85t114",
                Release_Date = DateTime.ParseExact("22/09/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "Shifting from one pocket to another, from one man\'s drama to another, a lowly dollar bill, \'one buck\' takes us on an odyssey through the heart of a forgotten town in Louisiana.",
                Duration = 90,
                Views_Count = 0
            };
            m13.Add();
            Movie m14 = new Movie()
            {
                Imdb_Id = "tt3896198",
                Title = "Guardians of the Galaxy Vol. 2",
                Genre_Id = gen2.Id,
                Director = "James Gunn",
                Poster = "http://image.tmdb.org/t/p/original//aJn9XeesqsrSLKcHfHP4u5985hn.jpg",
                Youtube_Trailer = "dW1BIid8Osg",
                Release_Date = DateTime.ParseExact("05/05/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "After saving Xandar from Ronan\'s wrath, the Guardians are now recognized as heroes. Now the team must help their leader Star Lord (Chris Pratt) uncover the truth behind his true heritage. Along the way, old foes turn to allies and betrayal is blooming. And the Guardians find that they are up against a devastating new menace who is out to rule the galaxy.",
                Duration = 136,
                Views_Count = 0
            };
            m14.Add();
            Movie m15 = new Movie()
            {
                Imdb_Id = "tt3469046",
                Title = "Despicable Me 3",
                Genre_Id = gen1.Id,
                Director = "Kyle Balda, Pierre Coffin, Eric Guillon(co-director)",
                Poster = "http://image.tmdb.org/t/p/original//ftRkFtAGuHngHnLiOxktq0aCVMF.jpg",
                Youtube_Trailer = "euz-KBBfAAo",
                Release_Date = DateTime.ParseExact("30/06/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "After he is fired from the Anti-Villain League for failing to take down the latest bad guy to threaten humanity, Gru finds himself in the midst of a major identity crisis. But when a mysterious stranger shows up to inform Gru that he has a long-lost twin brother-a brother who desperately wishes to follow in his twin\'s despicable footsteps-one former super-villain will rediscover just how good it feels to be bad.",
                Duration = 89,
                Views_Count = 0
            };
            m15.Add();
            Movie m16 = new Movie()
            {
                Imdb_Id = "tt4703048",
                Title = "6 Days",
                Genre_Id = gen8.Id,
                Director = "Toa Fraser",
                Poster = "http://image.tmdb.org/t/p/original//qk8iVAEHdx4Rd6hnB7PyVrbvmRS.jpg",
                Youtube_Trailer = "OcGUIEz6SHA",
                Release_Date = DateTime.ParseExact("18/08/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "In April 1980, armed gunmen stormed the Iranian Embassy in Princes Gate, London and took all inside hostage. Over the next six days a tense standoff took place, all the while a group of highly trained soldiers from the SAS prepared for a raid the world had never seen the likes of.",
                Duration = 94,
                Views_Count = 0
            };
            m16.Add();
            Movie m17 = new Movie()
            {
                Imdb_Id = "tt3748528",
                Title = "Rogue One: A Star Wars Story",
                Genre_Id = gen2.Id,
                Director = "Gareth Edwards",
                Poster = "http://image.tmdb.org/t/p/original//tZjVVIYXACV4IIIhXeIM59ytqwS.jpg",
                Youtube_Trailer = "MaYv3Y8tyoQ",
                Release_Date = DateTime.ParseExact("16/12/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "All looks lost for the Rebellion against the Empire as they learn of the existence of a new super weapon, the Death Star. Once a possible weakness in its construction is uncovered, the Rebel Alliance must set out on a desperate mission to steal the plans for the Death Star. The future of the entire galaxy now rests upon its success.",
                Duration = 133,
                Views_Count = 0
            };
            m17.Add();
            Movie m18 = new Movie()
            {
                Imdb_Id = "tt5168192",
                Title = "I, Daniel Blake",
                Genre_Id = gen7.Id,
                Director = "Ken Loach, Laura Obiols",
                Poster = "http://image.tmdb.org/t/p/original//l3NbEqQ9i5mkyVAxEYZU0mdYXow.jpg",
                Youtube_Trailer = "zZ-rBLtP1Ow",
                Release_Date = DateTime.ParseExact("09/06/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "A 59 year old carpenter recovering from a heart attack befriends a single mother and her two kids as they navigate their way through the impersonal, Kafkaesque benefits system. With equal amounts of humor, warmth and despair, the journey is heartfelt and emotional until the end.",
                Duration = 100,
                Views_Count = 0
            };
            m18.Add();
            Movie m19 = new Movie()
            {
                Imdb_Id = "tt5262198",
                Title = "J. Cole Forest Hills Drive Homecoming",
                Genre_Id = gen6.Id,
                Director = "Scott Lazer",
                Poster = "http://image.tmdb.org/t/p/original//qbiWaNPnAGUP0qyNKKS5jDjSBPw.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("09/01/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "Hip-hop superstar J. Cole returns to his hometown of Fayetteville, North Carolina for an endearing performance of his platinum selling album 2014 Forest Hills Drive. Interspersed with concert footage and interviews, this insightful music special is a must-see for any J. Cole fan.",
                Duration = 84,
                Views_Count = 0
            };
            m19.Add();
            Movie m20 = new Movie()
            {
                Imdb_Id = "tt3704298",
                Title = "Vincent N Roxxy",
                Genre_Id = gen8.Id,
                Director = "Gary Michael Schultz",
                Poster = "http://image.tmdb.org/t/p/original//n3guCVACMbY3YZ0hLQaBx4JNgsd.jpg",
                Youtube_Trailer = "ZE0NhS0mmW4",
                Release_Date = DateTime.ParseExact("02/06/2017", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2017,
                Description = "A small town loner and a rebellious punk rocker unexpectedly fall in love as they are forced on the run and soon discover violence follows them everywhere.",
                Duration = 102,
                Views_Count = 0
            };
            m20.Add();
            Movie m21 = new Movie()
            {
                Imdb_Id = "tt2975590",
                Title = "Batman v Superman: Dawn of Justice",
                Genre_Id = gen2.Id,
                Director = "Zack Snyder",
                Poster = "http://image.tmdb.org/t/p/original//vsjBeMPZtyB7yNsYY56XYxifaQZ.jpg",
                Youtube_Trailer = "fis-9Zqu2Ro",
                Release_Date = DateTime.ParseExact("25/03/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "The general public is concerned over having Superman on their planet and letting the \"Dark Knight\" - Batman - pursue the streets of Gotham. While this is happening, a power-phobic Batman tries to attack Superman.,Meanwhile Superman tries to settle on a decision, and Lex Luthor, the criminal mastermind and millionaire, tries to use his own advantages to fight the \"Man of Steel\".",
                Duration = 151,
                Views_Count = 0
            };
            m21.Add();
            Movie m22 = new Movie()
            {
                Imdb_Id = "tt2267968",
                Title = "Kung Fu Panda 3",
                Genre_Id = gen1.Id,
                Director = "Alessandro Carloni, Jennifer Yuh Nelson",
                Poster = "http://image.tmdb.org/t/p/original//eHWmEUP4fa7h1Fe7TXfTL7ncDl8.jpg",
                Youtube_Trailer = "10r9ozshGVE",
                Release_Date = DateTime.ParseExact("29/01/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "When Po\'s long-lost panda father suddenly reappears, the reunited duo travels to a secret panda paradise to meet scores of hilarious new panda characters. But when the supernatural villain Kai begins to sweep across China defeating all the kung fu masters, Po must do the impossible-learn to train a village full of his fun-loving, clumsy brethren to become the ultimate band of Kung Fu Pandas.",
                Duration = 95,
                Views_Count = 0
            };
            m22.Add();
            Movie m23 = new Movie()
            {
                Imdb_Id = "tt4831420",
                Title = "Sharknado 4: The 4th Awakens",
                Genre_Id = gen2.Id,
                Director = "Anthony C. Ferrante",
                Poster = "http://image.tmdb.org/t/p/original//7w0YVYdMulaekQMyDLZ8dg3gdNV.jpg",
                Youtube_Trailer = "hYypNJN17YI",
                Release_Date = DateTime.ParseExact("31/07/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "It\'s been five years since the last Sharknado that devastated Washington, D.C. and the world is benefiting from this hard-earned peace. Aston Reynolds\' tech company Astro-X with their revolutionary atmosphere stabilizers called Astro-Pods, managed to eradicate all possible Sharknado formations, before they could get the chance to grow in magnitude. Fin, is heading to Vegas for a family reunion, some fun and relaxation, but before long, menacing clouds are forming once again and a brand new Sharknado is at hand.",
                Duration = 95,
                Views_Count = 0
            };
            m23.Add();
            Movie m24 = new Movie()
            {
                Imdb_Id = "tt5574166",
                Title = "Code 8",
                Genre_Id = gen1.Id,
                Director = "Jeff Chan",
                Poster = "http://image.tmdb.org/t/p/original//pYMVfsr1pisfod96Ry5C2iqZg5d.jpg",
                Youtube_Trailer = "DqO90q0WZ0M",
                Release_Date = DateTime.ParseExact("22/03/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "In an alternate reality, 4% of the world\'s population is born with special abilities. Most of these \"specials\" live under poverty line. Taylor, a \"special\" living way under the poverty line takes different construction jobs in order to support his family. One day after work, over payment issues, Taylor intentionally damages his employer\'s property. The police goes after Taylor and his friend, and just when the police is about to arrest Taylor, a fight erupts.",
                Duration = 10,
                Views_Count = 0
            };
            m24.Add();
            Movie m25 = new Movie()
            {
                Imdb_Id = "tt3568218",
                Title = "The C Word",
                Genre_Id = gen7.Id,
                Director = "Tim Kirkby",
                Poster = "http://image.tmdb.org/t/p/original//zDuF8fTbrASrkHf9UYOxbAgeTgX.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("03/05/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "A woman writes a blog about her experience with terminal cancer.",
                Duration = 90,
                Views_Count = 0
            };
            m25.Add();
            Movie m26 = new Movie()
            {
                Imdb_Id = "tt2690138",
                Title = "The D Train",
                Genre_Id = gen8.Id,
                Director = "Andrew Mogel, Jarrad Paul",
                Poster = "http://image.tmdb.org/t/p/original//8I546Tt3BKp30SeLTjojUGHoxxM.jpg",
                Youtube_Trailer = "3PzB1Feeocw",
                Release_Date = DateTime.ParseExact("08/05/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "The head of a high school reunion committee tries to get the most popular guy in school to attend their class\' upcoming 20-year reunion.",
                Duration = 101,
                Views_Count = 0
            };
            m26.Add();
            Movie m27 = new Movie()
            {
                Imdb_Id = "tt4955162",
                Title = "Barbie in Rock 'N Royals",
                Genre_Id = gen9.Id,
                Director = "Michael Goguen, Karen J. Lloyd",
                Poster = "http://image.tmdb.org/t/p/original//m7MyzQhcM2qVbPW5uxcOi1bfDMX.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/09/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "Get ready to rock! In this upbeat musical, Barbie stars as Courtney, a princess whose world is turned upside down when she switches places with Erika, a famous rockstar.",
                Duration = 84,
                Views_Count = 0
            };
            m27.Add();
            Movie m28 = new Movie()
            {
                Imdb_Id = "tt4576034",
                Title = "U.F.Oh Yeah",
                Genre_Id = gen5.Id,
                Director = "Ryan Connolly",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("02/04/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "Ned Deedry, a conspiracy theorist and Extra-Terrestrial enthusiast, had always dreamed of making contact with other-worldly visitors. But, when that day finally arrived, things don\'t play out the way he\'d hoped.",
                Duration = 5,
                Views_Count = 0
            };
            m28.Add();
            Movie m29 = new Movie()
            {
                Imdb_Id = "tt4050596",
                Title = "North v South",
                Genre_Id = gen2.Id,
                Director = "Steven Nesbit",
                Poster = "http://image.tmdb.org/t/p/original//oxVCvkl52DbymfcEWPTeLmX3Ec9.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/10/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "Two star-crossed lovers navigate through all-out war between the North and South criminal underworlds",
                Duration = 96,
                Views_Count = 0
            };
            m29.Add();
            Movie m30 = new Movie()
            {
                Imdb_Id = "tt1951266",
                Title = "The Hunger Games: Mockingjay - Part 2",
                Genre_Id = gen2.Id,
                Director = "Francis Lawrence",
                Poster = "http://image.tmdb.org/t/p/original//qjn3fzCAHGfl0CzeUlFbjrsmu4c.jpg",
                Youtube_Trailer = "YddkQoxkZMQ",
                Release_Date = DateTime.ParseExact("20/11/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "After young Katniss Everdeen agrees to be the symbol of rebellion, the Mockingjay, she tries to return Peeta to his normal state, tries to get to the Capitol, and tries to deal with the battles coming her way...but all for her main goal: assassinating President Snow and returning peace to the Districts of Panem. As her squad starts to get smaller and smaller, will she make it to the Capitol? Will she get revenge on Snow or will her target change? Will she be with her \"Star-Crossed Lover,\" Peeta, or her long-time friend, Gale? Deaths, bombs, bow and arrows, a love triangle, hope... What will happen?",
                Duration = 137,
                Views_Count = 0
            };
            m30.Add();
            Movie m31 = new Movie()
            {
                Imdb_Id = "tt3195644",
                Title = "Insidious: Chapter 3",
                Genre_Id = gen16.Id,
                Director = "Leigh Whannell",
                Poster = "http://image.tmdb.org/t/p/original//fkUAz8gKVzH8OoEEcHf9MJpO1wu.jpg",
                Youtube_Trailer = "3HxEXnVSr1w",
                Release_Date = DateTime.ParseExact("05/06/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "After trying to connect with her dead mother, teenager Quinn Brenner, asks psychic Elise Rainier to help her, she refuses due to negotiate events in her childhood. Quinn starts noticing paranormal events happen in her house. After a vicious attack from a demon her father goes back and begs Elise Rainier to use her abilities to contact the other side in hope to stop these attacks by this furious demon content for a body.",
                Duration = 97,
                Views_Count = 0
            };
            m31.Add();
            Movie m32 = new Movie()
            {
                Imdb_Id = "tt3321300",
                Title = "MI-5",
                Genre_Id = gen8.Id,
                Director = "Bharat Nalluri",
                Poster = "http://image.tmdb.org/t/p/original//7qSldyO9zJl0NIFJBdLzTxRh53E.jpg",
                Youtube_Trailer = "smidRILQBuk",
                Release_Date = DateTime.ParseExact("04/12/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "MI5 personnel are caught up in a traffic jam in London while escorting the CIA\'s most wanted terrorist to an arranged CIA handover point, when he is suddenly rescued by armed men on motorbikes. Harry Pearce, the head of Counter-Terrorism at MI5 is blamed for the terrorist escaping. Especially as Harry disappeared shortly after the incident. An ex-agent, Will Holloway, and protégé of Harry\'s is recalled by MI5 to assist in finding and bringing Harry in. However Harry has disappeared for a reason. Certain that there is a traitor in a senior position in MI5, he enlists the somewhat reluctant Will to help him in uncovering the rat or rats concerned.",
                Duration = 104,
                Views_Count = 0
            };
            m32.Add();
            Movie m33 = new Movie()
            {
                Imdb_Id = "tt2479478",
                Title = "The Ridiculous 6",
                Genre_Id = gen22.Id,
                Director = "Frank Coraci",
                Poster = "http://image.tmdb.org/t/p/original//jrEbYGtEEv981chqVvYyIU9ni6K.jpg",
                Youtube_Trailer = "qUp7Qgimn38",
                Release_Date = DateTime.ParseExact("11/12/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "A white man, Tommy, raised by Indians is approached by his long lost father who tells him he needs $50,000 or he\'ll die at the hands of his former gang. Tommy goes on an incredible and ridiculous journey picking up his other 5 new brothers on the way in a race to save their dad.",
                Duration = 119,
                Views_Count = 0
            };
            m33.Add();
            Movie m34 = new Movie()
            {
                Imdb_Id = "tt2014319",
                Title = "Plan 9",
                Genre_Id = gen13.Id,
                Director = "John Johnson",
                Poster = "http://image.tmdb.org/t/p/original//w5SchITJaO2kGdGGZM60Zj6Sop9.jpg",
                Youtube_Trailer = "eJh-gdpJxJo",
                Release_Date = DateTime.ParseExact("16/02/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "Plan 9 is the story of Nilbog, a small town with a big story. The beginningof an invasion! These aliens have a different plan for the inhabitants of Earth. To resurrect their dead as their own army set with but one goal: to wipe out all mankind! This night will decide the fates of all who walk the planet and thought they were the top of the food chain.",
                Duration = 103,
                Views_Count = 0
            };
            m34.Add();
            Movie m35 = new Movie()
            {
                Imdb_Id = "tt3674412",
                Title = "Subject 0: Shattered Memories",
                Genre_Id = gen6.Id,
                Director = "Tiziano Cella",
                Poster = "http://image.tmdb.org/t/p/original//6gl8DOewMoWzJdT12OBZCFEvj3M.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/05/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "Robert Williams is called by the police during a business meeting. His wife Lauren is in shock, after finding a dead man in her home. More dead bodies are found in the city the day after. The modus operandi looks the same but there\'s something not quite right. Is it the same killer or a copycat? Police start investigating the mysterious murders.",
                Duration = 80,
                Views_Count = 0
            };
            m35.Add();
            Movie m36 = new Movie()
            {
                Imdb_Id = "tt3984320",
                Title = "Capital C",
                Genre_Id = gen8.Id,
                Director = "Timon Birkhofer, Jørg M. Kundinger",
                Poster = "http://image.tmdb.org/t/p/original//3RCb9VQnesDMsr4zhVnuDBayrwS.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/07/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "In just a few years, crowdfunding has empowered a whole new generation of artists to create things in a way that\'s never been done before. CAPITAL C is the first feature length documentary dedicated to crowdfunding, focusing on the hopes and dreams as well as the fears and pitfalls of independent creators in the wake of the digital age. Over a period of three years, the film is following the endeavors of poker card designer JACKSON ROBINSON, hippie ZACH CRAIN, and video game veteran BRIAN FARGO, all of whom reach out to the crowd in order to change their lives forever: With the unforeseen crowdfunding success of his hand-drawn poker card deck, JACKSON ROBINSON is facing the opportunity to make himself visible as an artist. Soon he has to learn that the fruition of his dream is coming at a price for him and his young family. From the get-go, ZACH CRAIN and his team rely on the crowd to create knitted bottle koozies. However, the hippie attitude of their crowdfunding campaign not only draws the attention of their ever-growing community. Competitors and business sharks are seeking their share of the pie as well. After 20 years, video game veteran BRIAN FARGO finally finds a way to reboot his classic Wasteland through a multi-million dollar crowdfunding campaign. Now the eyes of more than 60,000 supporters are on him to deliver on his promises for Wasteland II. In addition, renowned crowdfunding experts such as Scott Thomas (design director Obama campaign), Seth Godin (best selling author) or Molly Crabapple (political artist) share their insights on the topic. Production note: In 2012, CAPITAL C was funded by 586 people from 24 countries through a crowdfunding campaign on Kickstarter. CAPITAL C is an independently produced debut film that will be in cinemas April 2015 in Germany, Switzerland, Austria, and Japan.",
                Duration = 87,
                Views_Count = 0
            };
            m36.Add();
            Movie m37 = new Movie()
            {
                Imdb_Id = "tt3433074",
                Title = "D' Mrs. Brown's Boys Movie",
                Genre_Id = gen19.Id,
                Director = "Ben Kellett",
                Poster = "http://image.tmdb.org/t/p/original//mTowJZIDlaOz7K7QudpF49KwqHf.jpg",
                Youtube_Trailer = "ODn6o4yGUdM",
                Release_Date = DateTime.ParseExact("27/06/2014", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2014,
                Description = "When Moore Street market-trader Agnes Brown finds her livelihood under threat from a ruthless developer, she and her family embark on a campaign to save her stall, aided as only the Browns will be by a motley troop of blind trainee Ninjas, an alcoholic solicitor, and a barrister with Tourettes Syndrome.",
                Duration = 94,
                Views_Count = 0
            };
            m37.Add();
            Movie m38 = new Movie()
            {
                Imdb_Id = "tt3580052",
                Title = "Trailer Park Boys: Live in F**kin' Dublin",
                Genre_Id = gen3.Id,
                Director = "Jeremy Chipper, Mike Smith, John Paul Tremblay, Robb Wells",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/06/2014", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2014,
                Description = "The boys head to Ireland after winning a contest to see Rush but are arrested by immigration and must perform a community service puppet show.",
                Duration = 81,
                Views_Count = 0
            };
            m38.Add();
            Movie m39 = new Movie()
            {
                Imdb_Id = "tt1355630",
                Title = "If I Stay",
                Genre_Id = gen10.Id,
                Director = "R.J. Cutler",
                Poster = "http://image.tmdb.org/t/p/original//3pUd5uJgBEKkTR38fmd0omepqXf.jpg",
                Youtube_Trailer = "m9hZ40TJ0zs",
                Release_Date = DateTime.ParseExact("22/08/2014", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2014,
                Description = "Mia Hall thought the hardest decision she would ever face would be whether to pursue her musical dreams at Juilliard or follow a different path to be with the love of her life, Adam. But what should have been a carefree family drive changes everything in an instant, and now her own life hangs in the balance. Caught between life and death for one revealing day, Mia has only one decision left, which will not only decide her future but her ultimate fate.",
                Duration = 107,
                Views_Count = 0
            };
            m39.Add();
            Movie m40 = new Movie()
            {
                Imdb_Id = "tt1951265",
                Title = "The Hunger Games: Mockingjay - Part 1",
                Genre_Id = gen2.Id,
                Director = "Francis Lawrence",
                Poster = "http://image.tmdb.org/t/p/original//4PwyB0ErucIANzW24Kori71J6gU.jpg",
                Youtube_Trailer = "C_Tsj_wTJkQ",
                Release_Date = DateTime.ParseExact("21/11/2014", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2014,
                Description = "With the Games destroyed, Katniss Everdeen, along with Gale, Finnick and Beetee, end up in the so thought \"destroyed\" District 13. Under the leadership of President Coin and the advice of her friends, Katniss becomes the \"Mockingjay\", the symbol of rebellion for the districts of Panem.",
                Duration = 123,
                Views_Count = 0
            };
            m40.Add();
            Movie m41 = new Movie()
            {
                Imdb_Id = "tt1872181",
                Title = "The Amazing Spider-Man 2",
                Genre_Id = gen2.Id,
                Director = "Marc Webb",
                Poster = "http://image.tmdb.org/t/p/original//tmFDgDmrdp5DYezwpL0ymQKIbnV.jpg",
                Youtube_Trailer = "DlM2CWNTQ84",
                Release_Date = DateTime.ParseExact("02/05/2014", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2014,
                Description = "We\'ve always known that Spider-Man\'s most important conflict has been within himself: the struggle between the ordinary obligations of Peter Parker and the extraordinary responsibilities of Spider-Man. But in The Amazing Spider-Man 2, Peter Parker finds that his greatest battle is about to begin. It\'s great to be Spider-Man. For Peter Parker, there\'s no feeling quite like swinging between skyscrapers, embracing being the hero, and spending time with Gwen. But being Spider-Man comes at a price: only Spider-Man can protect his fellow New Yorkers from the formidable villains that threaten the city. With the emergence of Electro, Peter must confront a foe far more powerful than he. And as his old friend, Harry Osborn, returns, Peter comes to realize that all of his enemies have one thing in common: Oscorp.",
                Duration = 142,
                Views_Count = 0
            };
            m41.Add();
            Movie m42 = new Movie()
            {
                Imdb_Id = "tt2245084",
                Title = "Big Hero 6",
                Genre_Id = gen1.Id,
                Director = "Don Hall, Chris Williams",
                Poster = "http://image.tmdb.org/t/p/original//lv3NrraY2VRK6ImwNU3vfOPZyTi.jpg",
                Youtube_Trailer = "OvgyXKDXdZY",
                Release_Date = DateTime.ParseExact("07/11/2014", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2014,
                Description = "When a devastating event befalls the city of San Fransokyo and catapults Hiro into the midst of danger, he turns to Baymax and his close friends adrenaline junkie Go Go Tomago, neatnik Wasabi, chemistry whiz Honey Lemon and fanboy Fred. Determined to uncover the mystery, Hiro transforms his friends into a band of high-tech heroes called \"Big Hero 6.\"",
                Duration = 102,
                Views_Count = 0
            };
            m42.Add();
            Movie m43 = new Movie()
            {
                Imdb_Id = "tt2024544",
                Title = "12 Years a Slave",
                Genre_Id = gen8.Id,
                Director = "Steve McQueen",
                Poster = "http://image.tmdb.org/t/p/original//3BY2I6iLunYRkkl8Hb3hZl8O9MQ.jpg",
                Youtube_Trailer = "z02Ie8wKKRg",
                Release_Date = DateTime.ParseExact("08/11/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "Based on an incredible true story of one man\'s fight for survival and freedom. In the pre-Civil War United States, Solomon Northup, a free black man from upstate New York, is abducted and sold into slavery. Facing cruelty personified by a malevolent slave owner, as well as unexpected kindnesses, Solomon struggles not only to stay alive, but to retain his dignity. In the twelfth year of his unforgettable odyssey, Solomon\'s chance meeting with a Canadian abolitionist will forever alter his life.",
                Duration = 134,
                Views_Count = 0
            };
            m43.Add();
            Movie m44 = new Movie()
            {
                Imdb_Id = "tt3479180",
                Title = "Who the F**K Is Arthur Fogel",
                Genre_Id = gen11.Id,
                Director = "Ron Chapman",
                Poster = "http://image.tmdb.org/t/p/original//nS4BQrjQBDcPmd2DTYth3FqD2f5.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("05/03/2016", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2016,
                Description = "A look at the high-octane global live music industry and the quiet man at its center, featuring interviews, performances and appearances by a who\'s who of stars and insiders; with U2, Madonna, The Police, Lady Gaga, Rush and more.",
                Duration = 93,
                Views_Count = 0
            };
            m44.Add();
            Movie m45 = new Movie()
            {
                Imdb_Id = "tt1937390",
                Title = "Nymphomaniac: Vol. I",
                Genre_Id = gen22.Id,
                Director = "Lars von Trier",
                Poster = "http://image.tmdb.org/t/p/original//t9MElpSTsqNBttwntdevOgQuJDe.jpg",
                Youtube_Trailer = "w7-UH6d_Oyo",
                Release_Date = DateTime.ParseExact("06/03/2014", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2014,
                Description = "A man named Seligman finds a fainted wounded woman in an alley and he brings her home. She tells him that her name is Joe and that she is nymphomaniac. Joe tells her life and sexual experiences with hundreds of men since she was a young teenager while Seligman tells about his hobbies, such as fly fishing, reading about Fibonacci numbers or listening to organ music.",
                Duration = 117,
                Views_Count = 0
            };
            m45.Add();
            Movie m46 = new Movie()
            {
                Imdb_Id = "tt3250118",
                Title = "Everything Is Samuel L. Jackson's Fault",
                Genre_Id = gen5.Id,
                Director = "Zoe Jackson",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("17/09/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "Parents blame Samuel L. Jackson for their children\'s mishaps after seeing a movie with him in it.",
                Duration = 3,
                Views_Count = 0
            };
            m46.Add();
            Movie m47 = new Movie()
            {
                Imdb_Id = "tt2210834",
                Title = "Jimmy P.",
                Genre_Id = gen8.Id,
                Director = "Arnaud Desplechin",
                Poster = "http://image.tmdb.org/t/p/original//1qM4tqW8EAlxUbWGHdqXnvOiU1P.jpg",
                Youtube_Trailer = "JpThmmshJ-M",
                Release_Date = DateTime.ParseExact("11/09/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "A troubled Native American veteran forms an extraordinary friendship with his maverick French psychoanalyst as they try to find a cure to his suffering.",
                Duration = 117,
                Views_Count = 0
            };
            m47.Add();
            Movie m48 = new Movie()
            {
                Imdb_Id = "tt1833835",
                Title = "White T",
                Genre_Id = gen12.Id,
                Director = "Lance Frank",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("14/05/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "Herbert & Henry (Jerod and Jamal Mixon) are twin brothers with dreams to become the biggest rap stars in the game. Their chance at super-stardom comes after they buy a T-shirt with a winning golden tag allowing them to perform with Real Deal, the most legendary rapper in the World. The only problem is, Kevin, an equally sized Jewish kid with dreams of singing and blinging, manages to steal the prized White T and has his own plans to perform at the concert. With the help of a gypsy, a goat, and cast of characters as big as Herbert and Henry\'s appetites, White T is a feel good urban adventure reminiscent of Dude Where\'s My Car, Harold and Kumar Go to White Castle, and Willy Wonka and the Chocolate Factory.",
                Duration = 94,
                Views_Count = 0
            };
            m48.Add();
            Movie m49 = new Movie()
            {
                Imdb_Id = "tt0485061",
                Title = "U Want Me 2 Kill Him?",
                Genre_Id = gen20.Id,
                Director = "Andrew Douglas",
                Poster = "http://image.tmdb.org/t/p/original//xk1StHuS4FFa8GbBGPiCxdtWo6N.jpg",
                Youtube_Trailer = "LgDXXtDNJkY",
                Release_Date = DateTime.ParseExact("23/04/2015", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2015,
                Description = "A teenage boy\'s descent into the dangerous world of the Internet and the harrowing consequences of his actions. A true story.",
                Duration = 92,
                Views_Count = 0
            };
            m49.Add();
            Movie m50 = new Movie()
            {
                Imdb_Id = "tt2518788",
                Title = "1",
                Genre_Id = gen12.Id,
                Director = "Paul Crowder",
                Poster = "http://image.tmdb.org/t/p/original//h8LLsdZGqcMkvouEZbpKKBbbCU6.jpg",
                Youtube_Trailer = "k59zcs00k0A",
                Release_Date = DateTime.ParseExact("01/10/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "Set in the golden era of Grand Prix Racing \'1\' tells the story of a generation of charismatic drivers who raced on the edge, risking their lives during Formula 1\'s deadliest period, and the men who stood up and changed the sport forever.",
                Duration = 112,
                Views_Count = 0
            };
            m50.Add();
            Movie m51 = new Movie()
            {
                Imdb_Id = "tt1300854",
                Title = "Iron Man 3",
                Genre_Id = gen2.Id,
                Director = "Shane Black",
                Poster = "http://image.tmdb.org/t/p/original//n9X2DKItL3V0yq1q1jrk8z5UAki.jpg",
                Youtube_Trailer = "YLorLVa95Xo",
                Release_Date = DateTime.ParseExact("03/05/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "Marvel\'s \"Iron Man 3\" pits brash-but-brilliant industrialist Tony Stark/Iron Man against an enemy whose reach knows no bounds. When Stark finds his personal world destroyed at his enemy\'s hands, he embarks on a harrowing quest to find those responsible. This journey, at every turn, will test his mettle. With his back against the wall, Stark is left to survive by his own devices, relying on his ingenuity and instincts to protect those closest to him. As he fights his way back, Stark discovers the answer to the question that has secretly haunted him: does the man make the suit or does the suit make the man?",
                Duration = 130,
                Views_Count = 0
            };
            m51.Add();
            Movie m52 = new Movie()
            {
                Imdb_Id = "tt1659337",
                Title = "The Perks of Being a Wallflower",
                Genre_Id = gen17.Id,
                Director = "Stephen Chbosky",
                Poster = "http://image.tmdb.org/t/p/original//uhLcaTPeBpUNgYhZXhDWkj7gMkp.jpg",
                Youtube_Trailer = "QE7CGX1d6LU",
                Release_Date = DateTime.ParseExact("12/10/2012", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2012,
                Description = "Based on the novel written by Stephen Chbosky, this is about 15-year-old Charlie (Logan Lerman), an endearing and naive outsider, coping with first love (Emma Watson), the suicide of his best friend, and his own mental illness while struggling to find a group of people with whom he belongs. The introvert freshman is taken under the wings of two seniors, Sam and Patrick, who welcome him to the real world.",
                Duration = 103,
                Views_Count = 0
            };
            m52.Add();
            Movie m53 = new Movie()
            {
                Imdb_Id = "tt2105044",
                Title = "V/H/S",
                Genre_Id = gen20.Id,
                Director = "Matt Bettinelli-Olpin, David Bruckner, Tyler Gillett, Justin Martinez, Glenn McQuaid, Radio Silence, Joe Swanberg, Chad Villella, Ti West, Adam Wingard",
                Poster = "http://image.tmdb.org/t/p/original//xAC9kXLxUHpdCkISgYcLzYrxIQR.jpg",
                Youtube_Trailer = "-uOISibzrUI",
                Release_Date = DateTime.ParseExact("06/09/2012", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2012,
                Description = "A POV, found footage horror film from the perspective of America\'s top genre filmmakers. A group of misfits are hired by an unknown third party to burglarize a desolate house in the countryside and acquire a rare tape. Upon searching the house, the guys are confronted with a dead body, a hub of old televisions and an endless supply of cryptic footage, each video stranger than the last.",
                Duration = 116,
                Views_Count = 0
            };
            m53.Add();
            Movie m54 = new Movie()
            {
                Imdb_Id = "tt2276071",
                Title = "What's the T?",
                Genre_Id = gen4.Id,
                Director = "Cecilio Asuncion",
                Poster = "http://image.tmdb.org/t/p/original//BQ5jArrCXzevsCVUng4FEOnLyF.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("21/06/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "What\'s the T is a documentary that explores the challenges, successes and lives of five trans gender women. These five women represent normality and abnormality, seamlessly in their daily efforts to achieve a balance of feminine and masculine as the day may require. These women are prime examples of reality and self-identity.",
                Duration = 65,
                Views_Count = 0
            };
            m54.Add();
            Movie m55 = new Movie()
            {
                Imdb_Id = "tt2081311",
                Title = "May I Kill U?",
                Genre_Id = gen13.Id,
                Director = "Stuart Urban",
                Poster = "http://image.tmdb.org/t/p/original//jqvqeCMignWx33TT0h7IfXigibA.jpg",
                Youtube_Trailer = "SiFH4QxE1w0",
                Release_Date = DateTime.ParseExact("11/01/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "Baz is one of Britain\'s new bicycle police, a figure of fun.Â But soon he will turn from cycle cop to psycho-path.Â As riots break out in London, a head injury skews Baz into a vigilante, offering criminals the choice of arrest or death. Baz sees his campaign as lawful killing. Lowlifes who are too stunned, confused, or drunk to argue when he politely asks, \"May I kill you?\" are merrily dispatched. All filmed on the helmet-cam and posted on social networks!Â Using the alter ego @N4cethelaw, Baz acquires thousands more fans with each killing, dispensing justice to scumbags, cleaning up society. In a sudden reversal, Baz is captured by an enraged relative of one of his presumed \"kills\", and faces slaughter or -Â even worse - exposure.",
                Duration = 87,
                Views_Count = 0
            };
            m55.Add();
            Movie m56 = new Movie()
            {
                Imdb_Id = "tt2313197",
                Title = "Batman: The Dark Knight Returns, Part 1",
                Genre_Id = gen1.Id,
                Director = "Jay Oliva",
                Poster = "http://image.tmdb.org/t/p/original//a6pB1w4lwp0WeTRQk9Q2K1F9W34.jpg",
                Youtube_Trailer = "0osGZGwFNkk",
                Release_Date = DateTime.ParseExact("25/09/2012", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2012,
                Description = "Batman has not been seen for ten years. A new breed of criminal ravages Gotham City, forcing 55-year-old Bruce Wayne back into the cape and cowl. But, does he still have what it takes to fight crime in a new era?",
                Duration = 76,
                Views_Count = 0
            };
            m56.Add();
            Movie m57 = new Movie()
            {
                Imdb_Id = "tt1764651",
                Title = "The Expendables 2",
                Genre_Id = gen2.Id,
                Director = "Simon West",
                Poster = "http://image.tmdb.org/t/p/original//pIjnoUnXdLpROFzIRPNziPzgBUp.jpg",
                Youtube_Trailer = "ip_CYHdyUBs",
                Release_Date = DateTime.ParseExact("17/08/2012", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2012,
                Description = "Barney Ross is approached by CIA man Church, who wants him and his guns for hire to go to the former Soviet Union to retrieve something that was on a plane that crashed. Church doesn\'t tell him what he is getting. And Church sends a woman, Maggie with him to make sure he gets it. They find the plane and get the thing but some men take one of Barney\'s people hostage and the leader tells him to give him what they got or he\'ll kill his hostage. They give it to him but he kills his hostage anyway. Barney asks Maggie what was so important about that thing. She says that it showed the location of a Russian plutonium storage mine. Barney decides to track the man down and deal with him. They track them down and discover that the man they seek is Vilain who leads a group known as The Sangs and that they have taken all the men from the surrounding villages to work the mine.",
                Duration = 103,
                Views_Count = 0
            };
            m57.Add();
            Movie m58 = new Movie()
            {
                Imdb_Id = "tt2375779",
                Title = "Wrong Turn 5: Bloodlines",
                Genre_Id = gen2.Id,
                Director = "Declan O'Brien",
                Poster = "http://image.tmdb.org/t/p/original//euv2zu83YBRQDOjcsPy3vWkyO5n.jpg",
                Youtube_Trailer = "5yi0aIRi3eg",
                Release_Date = DateTime.ParseExact("22/02/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "A small West Virginia town is hosting the legendary Mountain Man Festival on Halloween, where throngs of costumed party goers gather for a wild night of music and mischief. But an inbred family of hillbilly cannibals kill the fun when they trick and treat themselves to a group of visiting college students.",
                Duration = 91,
                Views_Count = 0
            };
            m58.Add();
            Movie m59 = new Movie()
            {
                Imdb_Id = "tt1975249",
                Title = "6 Bullets",
                Genre_Id = gen6.Id,
                Director = "Ernie Barbarash",
                Poster = "http://image.tmdb.org/t/p/original//4vfUnguh7zmRZqglyb9lI7mNfqV.jpg",
                Youtube_Trailer = "F0kRbWYyHP8",
                Release_Date = DateTime.ParseExact("17/11/2012", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2012,
                Description = "Veteran mercenary Samson Gaul (Jean-Claude Van Damme) knows that in the heat of battle, every bullet counts. He retired from combat when his actions resulted in the deaths of helpless victims, but now he\'s the last hope for a desperate father. Mixed Martial Artist, Andrew Fayden (Joe Flanigan, Stargate: Atlantis) knows how to fight, but alone he\'s unprepared to navigate the corrupt streets of a foreign city to find his kidnapped daughter. Together, these warriors will stop at nothing to tear apart a vile network of criminals that prey upon the innocent.",
                Duration = 115,
                Views_Count = 0
            };
            m59.Add();
            Movie m60 = new Movie()
            {
                Imdb_Id = "tt2290075",
                Title = "8",
                Genre_Id = gen12.Id,
                Director = "Rob Reiner",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "qlUG8F9uVgM",
                Release_Date = DateTime.ParseExact("03/03/2012", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2012,
                Description = "Live chronicle of the landmark federal trial of California\'s Prop. 8 using the actual court transcripts and first-hand interviews.",
                Duration = 91,
                Views_Count = 0
            };
            m60.Add();
            Movie m61 = new Movie()
            {
                Imdb_Id = "tt2382017",
                Title = "Undertaker: The Streak - 20-0",
                Genre_Id = gen1.Id,
                Director = "Kevin Dunn",
                Poster = "http://image.tmdb.org/t/p/original//bWWnYZuwg3QvuA6puuaRsxG7WKW.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/07/2012", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2012,
                Description = "Undertaker: The Streak includes a never-before-seen documentary featuring Superstars and rivals who marvel at the longevity and sheer magnitude of the Deadman\'s dominance on the Grandest Stage. Hear from Shawn Michaels, Triple H, Batista, Big Show, Randy Orton and others on their experience staring across the ring into the eyes of The Phenom.",
                Duration = 38,
                Views_Count = 0
            };
            m61.Add();
            Movie m62 = new Movie()
            {
                Imdb_Id = "tt1795588",
                Title = "Doggie B",
                Genre_Id = gen9.Id,
                Director = "Romanus Wolter",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("11/04/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "Doggie Boogie dances into the hearts of its family audience as they cheer for a devoted Bichon pup, Pijo, who helps his owner and her dog dancing uncle achieve their dreams. Cassie\'s wish to become a Vet is crushed by her mother, who has become a slave to the world of personal injury law and is forcing Cassie to follow in the family legacy. Peter Wolfe, her dog-dancing Uncle, dreams of winning a national dog dance championship but is blocked by his guilt over a tragic dance accident. Gertrude Spinner, a ten-time dog dance champion and keeper of the legendary Dog Dance Bible, will do anything to stop them. Supported by a colorful cast and enchanting dogs, Pijo uses the lessons of Barkananda (\"healing bliss\") to provide Cassie and Peter with a fresh start as they dance through life\'s twists and turns. He breathes life into everyone\'s dreams as he dances away with their hearts.",
                Duration = 88,
                Views_Count = 0
            };
            m62.Add();
            Movie m63 = new Movie()
            {
                Imdb_Id = "tt1616195",
                Title = "J. Edgar",
                Genre_Id = gen6.Id,
                Director = "Clint Eastwood",
                Poster = "http://image.tmdb.org/t/p/original//8VHxc79a8wZRM6jfw2yhXtZkn1.jpg",
                Youtube_Trailer = "vD99zwj-ZUg",
                Release_Date = DateTime.ParseExact("11/11/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2011,
                Description = "Biopic of J. Edgar Hoover told by Hoover as he recalls his career for a biography. Early in his career, Hoover fixated on Communists, anarchists and any other revolutionary taking action against the U.S. government. He slowly builds the agency\'s reputation, becoming the sole arbiter of who gets hired and fired. One of his hires is Clyde Tolson who is quickly promoted to Assistant Director and would be Hoover\'s confidant and companion for the rest of Hoover\'s life. Hoover\'s memories have him playing a greater role in the many high profile cases the FBI was involved in - the Lindbergh baby kidnapping, the arrest of bank robbers like John Dillinger - and also show him to be quite adept at manipulating the various politicians he\'s worked with over his career, thanks in large part to his secret files.",
                Duration = 137,
                Views_Count = 0
            };
            m63.Add();
            Movie m64 = new Movie()
            {
                Imdb_Id = "tt1201607",
                Title = "Harry Potter and the Deathly Hallows: Part 2",
                Genre_Id = gen8.Id,
                Director = "David Yates",
                Poster = "http://image.tmdb.org/t/p/original//n5A7brJCjejceZmHyujwUTVgQNC.jpg",
                Youtube_Trailer = "mObK5XD8udk",
                Release_Date = DateTime.ParseExact("15/07/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2011,
                Description = "Harry, Ron, and Hermione continue their quest of finding and destroying the Dark Lord\'s three remaining Horcruxes, the magical items responsible for his immortality. But as the mystical Deathly Hallows are uncovered, and Voldemort finds out about their mission, the biggest battle begins and life as they know it will never be the same again.",
                Duration = 130,
                Views_Count = 0
            };
            m64.Add();
            Movie m65 = new Movie()
            {
                Imdb_Id = "tt1778304",
                Title = "Paranormal Activity 3",
                Genre_Id = gen16.Id,
                Director = "Henry Joost, Ariel Schulman",
                Poster = "http://image.tmdb.org/t/p/original//7b0ksqDWSZzmfOLSOok7Hh8eKqk.jpg",
                Youtube_Trailer = "GuPCP7yzqc8",
                Release_Date = DateTime.ParseExact("21/10/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2011,
                Description = "In 1988, in California, cinematographer Dennis moves to the house of his girlfriend Julie to raise a family with her daughters Katie and Kristi. Little Kristi has an imaginary friend named Toby while weird things happen in the house. Dennis decides to place cameras in the house to capture images during the night and soon he finds that there is an entity in the house. Dennis\'s friend Randy Rosen (Dustin Ingram) researches the events and learns that his house might be a coven of witches and the children may be in danger.",
                Duration = 83,
                Views_Count = 0
            };
            m65.Add();
            Movie m66 = new Movie()
            {
                Imdb_Id = "tt1262416",
                Title = "Scream 4",
                Genre_Id = gen16.Id,
                Director = "Wes Craven",
                Poster = "http://image.tmdb.org/t/p/original//5VqyrIpMbnwXdZFcISmtKr3n75A.jpg",
                Youtube_Trailer = "rdF6JTrTQsg",
                Release_Date = DateTime.ParseExact("15/04/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2011,
                Description = "Sidney Prescott, now the author of a self-help book, returns home to Woodsboro on the last stop of her book tour. There she reconnects with Sheriff Dewey and Gale, who are now married, as well as her cousin Jill and her Aunt Kate. Unfortunately, Sidney\'s appearance also brings about the return of Ghostface, putting Sidney, Gale, and Dewey, along with Jill, her friends, and the whole town of Woodsboro in danger.",
                Duration = 111,
                Views_Count = 0
            };
            m66.Add();
            Movie m67 = new Movie()
            {
                Imdb_Id = "tt2076781",
                Title = "6 Days to Air: The Making of South Park",
                Genre_Id = gen5.Id,
                Director = "Arthur Bradford",
                Poster = "http://image.tmdb.org/t/p/original//xCoTZQHBYKQtPKELV028BN9njTf.jpg",
                Youtube_Trailer = "Ur7v_wJ7Nrw",
                Release_Date = DateTime.ParseExact("09/10/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2011,
                Description = "A look at the making of South Park: HUMANCENTiPAD (2011).",
                Duration = 42,
                Views_Count = 0
            };
            m67.Add();
            Movie m68 = new Movie()
            {
                Imdb_Id = "tt1282140",
                Title = "Easy A",
                Genre_Id = gen8.Id,
                Director = "Will Gluck",
                Poster = "http://image.tmdb.org/t/p/original//wu4tawMznxUvqP21lUH6RKrv3LQ.jpg",
                Youtube_Trailer = "KNbPnqyvItk",
                Release_Date = DateTime.ParseExact("17/09/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "After a little white lie about losing her virginity gets out, a clean cut high school girl sees her life paralleling Hester Prynne\'s in \"The Scarlet Letter,\" which she is currently studying in school - until she decides to use the rumor mill to advance her social and financial standing.",
                Duration = 92,
                Views_Count = 0
            };
            m68.Add();
            Movie m69 = new Movie()
            {
                Imdb_Id = "tt1572507",
                Title = "The Simpsons 20th Anniversary Special: In 3-D! On Ice!",
                Genre_Id = gen21.Id,
                Director = "Morgan Spurlock",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("10/01/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "Morgan Spurlock examines the cultural phenomenon of \"The Simpsons\".",
                Duration = 42,
                Views_Count = 0
            };
            m69.Add();
            Movie m70 = new Movie()
            {
                Imdb_Id = "tt1486670",
                Title = "F",
                Genre_Id = gen16.Id,
                Director = "Johannes Roberts",
                Poster = "http://image.tmdb.org/t/p/original//dzdw6smYHCljNx3NWoNw2RPtuIa.jpg",
                Youtube_Trailer = "JO1gGmcXQa8",
                Release_Date = DateTime.ParseExact("09/07/2013", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2013,
                Description = "In England, the teacher of the Wittering College Robert Anderson is hit in the face by a student and is forced to take three months vacation to avoid being sued by the parents of the student. Robert is affected by the incident and a couple of months later, he is emotionally disturbed, alcoholic and separated of his wife Helen. Their daughter Kate lives with her mother and has classes with Robert, but she does not respect her father. The principal of Wittering College, Sarah Balham (Ruth Gemmell), loathes Robert and wants to get rid of him, but the Union does not allow her to fire him. When Robert reads about violence in another school, he sends a memo advising the employees of the school and he is considered paranoid and delusional by everybody. One day after hours, Robert notes some strange movements outside the school and he advises the security guard James that does not give much attention to the discredited Robert. But sooner Robert realizes that the Wittering College is under siege of a gang of hooligans and he needs to find Kate to protect his daughter.",
                Duration = 79,
                Views_Count = 0
            };
            m70.Add();
            Movie m71 = new Movie()
            {
                Imdb_Id = "tt1613088",
                Title = "G.",
                Genre_Id = gen10.Id,
                Director = "J. Xavier Velasco",
                Poster = "http://image.tmdb.org/t/p/original//n9Y0zVqy3EFKjPQGQlm0lxXODA2.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("07/08/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "G. remembers how he came up with an idea, and devoted his life to make it happen. Now he is making progress and achieves an extraordinary act, only with the power of his mind.",
                Duration = 6,
                Views_Count = 0
            };
            m71.Add();
            Movie m72 = new Movie()
            {
                Imdb_Id = "tt1106860",
                Title = "Ca$h",
                Genre_Id = gen6.Id,
                Director = "Stephen Milburn Anderson",
                Poster = "http://image.tmdb.org/t/p/original//6Y3L1a2fG838z3OeELzl9JOX5XB.jpg",
                Youtube_Trailer = "AzWQBq_Xltk",
                Release_Date = DateTime.ParseExact("26/03/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "A stroke of good luck turns lethal for Sam Phelan and his wife Leslie when they are faced with a life-changing decision that brings strange and sinister Pyke Kubic to their doorstep. As Pyke leads Sam and Leslie on a tumultuous adventure through the streets of Chicago, each are pulled deeper and deeper into a desperate spiral of deception and violence... All in the name of money.",
                Duration = 108,
                Views_Count = 0
            };
            m72.Add();
            Movie m73 = new Movie()
            {
                Imdb_Id = "tt1655419",
                Title = "Morgan M. Morgansen's Date with Destiny",
                Genre_Id = gen17.Id,
                Director = "Joseph Gordon-Levitt",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/01/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "Morgan M. Morgensen nervously survives his first date with the love of his life, Destiny.",
                Duration = 6,
                Views_Count = 0
            };
            m73.Add();
            Movie m74 = new Movie()
            {
                Imdb_Id = "tt1289419",
                Title = "N-Secure",
                Genre_Id = gen8.Id,
                Director = "David M. Matthews",
                Poster = "http://image.tmdb.org/t/p/original//3NsPJPB0RvywmUFbUkwJkq6UBfW.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/10/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "N-Secure is a no holds-barred thrilling drama mixed with murder, mayhem, and manipulation among affluent professionals. This film sheds light on a man\'s downfall from the pinnacles of success into the depths of his damaged character. His insecurities lead him into a series of troubled romantic relationships and eventually a web of events that include betrayal and murder.",
                Duration = 105,
                Views_Count = 0
            };
            m74.Add();
            Movie m75 = new Movie()
            {
                Imdb_Id = "tt1781798",
                Title = "Dara O Briain: This Is the Show",
                Genre_Id = gen5.Id,
                Director = "Paul Wheeler",
                Poster = "http://image.tmdb.org/t/p/original//xnnU7MYJ0jkh6jrqVXUH8tgCUBt.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("22/11/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "\'Dara O Briain\' - This Is the Show was recorded in front of a sell-out crowd on the final date of his record-breaking nine nights at the world famous Hammersmith Apollo. Dara is on top form as he effortlessly mixes off the cuff audience interaction with razor sharp material and a star studded finale that almost puts Hollywood to shame.",
                Duration = 102,
                Views_Count = 0
            };
            m75.Add();
            Movie m76 = new Movie()
            {
                Imdb_Id = "tt1466072",
                Title = "William S. Burroughs: A Man Within",
                Genre_Id = gen6.Id,
                Director = "Yony Leyser",
                Poster = "http://image.tmdb.org/t/p/original//2I6PqbEyBswzxszEB3OqbMSMvUS.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("12/12/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "William S. Burroughs: featuring never before seen footage as well as exclusive interviews with his closest friends and colleagues. Born the heir of the Burroughs\' adding machine estate, he struggled throughout his life with addiction, control systems, and self. He was forced to deal with the tragedy of killing his wife and the repercussions of neglecting his son. His novel, Naked Lunch, was one of the last books to be banned by the U.S. government. Allen Ginsberg and Norman Mailer testified on behalf of the book. The courts eventually overturned their decision in 1966, ruling that the book had an important social value. It remains one of the most recognized literary works of the 20th century. William Burroughs was one of the first to cross the dangerous boundaries of queer and drug culture in the 1950s, and write about his experiences. Eventually he was hailed the godfather of the beat generation and influenced artists for generations to come. However, his friends were left wondering, did William ever find happiness? This extremely personal documentary breaks the surface of the troubled and brilliant world of one of the greatest authors of all time. \"William S. Burroughs: A Man Within\" is the first and only posthumous documentary about this legendary figure.",
                Duration = 87,
                Views_Count = 0
            };
            m76.Add();
            Movie m77 = new Movie()
            {
                Imdb_Id = "tt0926084",
                Title = "Harry Potter and the Deathly Hallows: Part 1",
                Genre_Id = gen10.Id,
                Director = "David Yates",
                Poster = "http://image.tmdb.org/t/p/original//8YA36faYlkpfp6aozcGsqq68pZ9.jpg",
                Youtube_Trailer = "9hXH0Ackz6w",
                Release_Date = DateTime.ParseExact("19/11/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "Voldemort\'s power is growing stronger. He now has control over the Ministry of Magic and Hogwarts. Harry, Ron, and Hermione decide to finish Dumbledore\'s work and find the rest of the Horcruxes to defeat the Dark Lord. But little hope remains for the Trio, and the rest of the Wizarding World, so everything they do must go as planned.",
                Duration = 146,
                Views_Count = 0
            };
            m77.Add();
            Movie m78 = new Movie()
            {
                Imdb_Id = "tt1514041",
                Title = "4.3.2.1.",
                Genre_Id = gen20.Id,
                Director = "Noel Clarke, Mark Davis",
                Poster = "http://image.tmdb.org/t/p/original//tzze4v69mJGV1xcqSsOoh4ASoVL.jpg",
                Youtube_Trailer = "pXG7TJ6aPnM",
                Release_Date = DateTime.ParseExact("02/06/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2010,
                Description = "While Jo (Roberts) is chained down in a dead end supermarket job, her friends are all out on their own separate adventures: Cassandra (Egerton) is jetting off to New York to meet her Internet boyfriend; Kerrys (Warren-Markland) is on a one woman crusade fighting for female liberation and Shannon (Lovibond) is on a one way trip to meet her maker. But a chance encounter with some diamond thieves sends their separate worlds on a collision course with not only each other, but fate itself. These 4 girls are about to have 3 days they will never forget, spanning to 2 cities. That is ... if they survive.",
                Duration = 117,
                Views_Count = 0
            };
            m78.Add();
            Movie m79 = new Movie()
            {
                Imdb_Id = "tt1325743",
                Title = "5 Star Day",
                Genre_Id = gen17.Id,
                Director = "Danny Buday",
                Poster = "http://image.tmdb.org/t/p/original//jwiV1mM5InPwWkXONrlUZm9nktp.jpg",
                Youtube_Trailer = "89RRssIOsvk",
                Release_Date = DateTime.ParseExact("04/11/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2011,
                Description = "Four People. One Horoscope. Infinite Possibilities. Jake Gibson\'s (Cam Gigandet) horoscope forecasts a perfect FIVE STAR DAY the morning of his birthday, but what\'s foretold as a flawless day unfolds to be far less than stellar. Jake\'s world turns upside down when all that could go wrong ... does. Determined that Astrology has no legitimacy, Jake embarks on a journey to test the theory of Astrology by finding the three people born the same time and place as himself - Sarah Reynolds (Jena Malone), Yvette Montgomery (Brooklyn Sudano) and Wesley Henderson (Max Hartman). The journey quickly uproots Jake from the small college town of Berkeley, California, to downtown Chicago where he sets out to find and interview Sarah, Yvette and Wesley to see if their birthdays proved to be as deplorable as his own. Jake\'s pursuit in finding his three Astrological matches (or Zodiac twins) will not only test his convictions, but validate how life\'s unexpected twists of fate can deliver much more than the anticipated. The unforeseen takes Jake from the Windy City, to the boardwalk of New Jersey\'s Atlantic City, to the bustling streets of New York. What Jake learns along the way is an important lesson about life, love, fate and destiny that will unexpectedly change his life forever.",
                Duration = 97,
                Views_Count = 0
            };
            m79.Add();
            Movie m80 = new Movie()
            {
                Imdb_Id = "tt1638362",
                Title = "Client 9: The Rise and Fall of Eliot Spitzer",
                Genre_Id = gen8.Id,
                Director = "Alex Gibney",
                Poster = "http://image.tmdb.org/t/p/original//7E70z4D5cCsgQOd0xcYXOJWLNGp.jpg",
                Youtube_Trailer = "0ieJ_8HMV_s",
                Release_Date = DateTime.ParseExact("04/03/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2011,
                Description = "Documentary on the rise of Eliot Spitzer, first as Attorney General and then Governor of New York and his subsequent downfall due to a sex scandal. Spitzer had a hard driving, take no prisoners approach to prosecuting criminals. When he focused his efforts on Wall Street, he came up against some very powerful men. The chink in his armor was an escort whom he met regularly. When the fact that he spent time with a prostitute became public the knives came out so to speak, and Spitzer found himself isolated, resigning the Governorship. At one point, Spitzer recounts the story of a friend who gave him a t-shirt with \'Hubris is Terminal\' printed on the front. A fitting epitaph somehow for his political career.",
                Duration = 117,
                Views_Count = 0
            };
            m80.Add();
            Movie m81 = new Movie()
            {
                Imdb_Id = "tt1314645",
                Title = "C Me Dance",
                Genre_Id = gen20.Id,
                Director = "Greg Robbins",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "n-7TM3Udip4",
                Release_Date = DateTime.ParseExact("03/04/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "A drama centered on a teenage girl who has trained her entire life to dance for the Pittsburgh Ballet.",
                Duration = 89,
                Views_Count = 0
            };
            m81.Add();
            Movie m82 = new Movie()
            {
                Imdb_Id = "tt0436339",
                Title = "G-Force",
                Genre_Id = gen1.Id,
                Director = "Hoyt Yeatman",
                Poster = "http://image.tmdb.org/t/p/original//dnBiiPKJnIKb1e8BcDo3cicdjFG.jpg",
                Youtube_Trailer = "7GaEZ2e9Ijs",
                Release_Date = DateTime.ParseExact("24/07/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "The story is about a team of trained secret agent flies and a mole that takes on a mission for the US government. A specially trained squad of not guinea pigs is dispatched to stop a diabolical billionaire, who plans to taking over the world with household appliances.",
                Duration = 88,
                Views_Count = 0
            };
            m82.Add();
            Movie m83 = new Movie()
            {
                Imdb_Id = "tt1155056",
                Title = "I Love You, Man",
                Genre_Id = gen17.Id,
                Director = "John Hamburg",
                Poster = "http://image.tmdb.org/t/p/original//A3D37AUJvB2wFGFtAxJlwUsoIgz.jpg",
                Youtube_Trailer = "um5DuTLzw-I",
                Release_Date = DateTime.ParseExact("20/03/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "Peter Klaven\'s world revolves around his real estate work and Zooey, his soon-to-be fiancée. After he pops the question, she calls her best friends and they go into wedding planning mode. Peter has no male friends and that poses problems: will he turn out to be a clingy guy, and who will be his best man? Zooey, her friends, and Peter\'s brother Robbie offer help that results in awkward moments. Then, at an open house Peter\'s hosting, he meets Sydney, an amiable, low-key guy. They trade business cards, and Peter calls him to meet for drinks. A friendship develops that\'s great at first but then threatens Peter\'s engagement and career. Can guys be friends and couples be in love?",
                Duration = 105,
                Views_Count = 0
            };
            m83.Add();
            Movie m84 = new Movie()
            {
                Imdb_Id = "tt1232047",
                Title = "Ed, Edd n Eddy's Big Picture Show",
                Genre_Id = gen2.Id,
                Director = "Danny Antonucci",
                Poster = "http://image.tmdb.org/t/p/original//sbtZxBLF2jhDjDYEBVwYtaK9FlY.jpg",
                Youtube_Trailer = "a-rHWZdbFQw",
                Release_Date = DateTime.ParseExact("08/11/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "When a scam goes horribly wrong and leaves the neighborhood kids furious, the Eds embark on a journey to find Eddy\'s brother in the \"Ed, Edd, n Eddy\" series finale.",
                Duration = 87,
                Views_Count = 0
            };
            m84.Add();
            Movie m85 = new Movie()
            {
                Imdb_Id = "tt1293813",
                Title = "P-Star Rising",
                Genre_Id = gen14.Id,
                Director = "Gabriel Noble",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/10/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "At age 9, Priscilla, an adorable yet precocious little girl, tells her single-father, Jesse,: \"I am going to become a rapper and fulfill your dreams of succeeding in the music business.\" Moved by Priscilla\'s passion and impressed with her natural talent and undeniable charisma, he begins to teach her all he knows about rapping. In the four years that follow there is no question that rapping has brought Priscilla closer to her estranged father, and that her success has made him proud. Before our eyes, this father-daughter duo go from a one-bedroom shelter in Harlem to a 4 bedroom apartment, from food stamps to shopping sprees, from rapping on street corners to sold out night clubs, and from sneaking under train turnstiles without the $2 fare to spare to being driven around in tinted SUV\'s. It is further undeniable that Jesse has been reborn, from looking at old photos and bitterly reflecting on how he never was given the respect he deserved in the music business as a rapper himself to finding his own voice and self-respect as his daughter\'s overzealous manager. But in the efforts to make her dad proud, Priscilla struggles to remain a child and finds herself trapped in a world of people twice her size and four times her age and doesn\'t know who to trust. Jesse himself is caught between wanting to protect his daughter\' innocence and exploiting her raw talent to fulfill his deferred dream. All they know is that the ride has just begun.",
                Duration = 84,
                Views_Count = 0
            };
            m85.Add();
            Movie m86 = new Movie()
            {
                Imdb_Id = "tt1404702",
                Title = "Naked Ambition: An R Rated Look at an X Rated Industry",
                Genre_Id = gen20.Id,
                Director = "Michael Grecco",
                Poster = "http://image.tmdb.org/t/p/original//lZ7a2OfaIChu50QlJc0x8jyLulH.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("30/04/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "Noted Celebrity Photographer, Michael Grecco, sets out to capture the essence of the AVN Awards and Convention where the best in American Pornography is displayed, celebrated and honored.",
                Duration = 81,
                Views_Count = 0
            };
            m86.Add();
            Movie m87 = new Movie()
            {
                Imdb_Id = "tt1231277",
                Title = "S. Darko",
                Genre_Id = gen18.Id,
                Director = "Chris Fisher",
                Poster = "http://image.tmdb.org/t/p/original//scVLRx5GWyznYoBMUo8aXxgLot9.jpg",
                Youtube_Trailer = "uxSewEtDtkw",
                Release_Date = DateTime.ParseExact("21/08/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "July, 1995, the time is out of joint. Two teen girls, Sam and Corey, have left Virginia for L.A. to start over. Sam\'s brother has died and her family\'s shattered; Corey\'s too wild. They have car trouble in a small desert town, where Corey immediately starts her partying ways, where a meteorite strikes a windmill, and where a burned-out Desert Storm vet predicts the end of the world in four days. Sam hallucinates while sleepwalking, young men have disappeared from town, and cars come out of nowhere to cause accidents. Time travel may be possible, but it takes courage and resolve. Is the addled war veteran right? If he is, can Corey or Sam make things right?",
                Duration = 103,
                Views_Count = 0
            };
            m87.Add();
            Movie m88 = new Movie()
            {
                Imdb_Id = "tt1386011",
                Title = "You're Welcome America: A Final Night With George W. Bush",
                Genre_Id = gen8.Id,
                Director = "Marty Callner",
                Poster = "http://image.tmdb.org/t/p/original//bid5C8jipcsircj7EWdeApKEcRH.jpg",
                Youtube_Trailer = "zESzzOAoyDA",
                Release_Date = DateTime.ParseExact("08/05/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "It\'s time for change in America--but not without a few parting words from former President George W Bush. Here\'s your chance to discover the man behind the myth as HBO presents Will Ferrell in a performance of his heralded one-man Broadway show.",
                Duration = 115,
                Views_Count = 0
            };
            m88.Add();
            Movie m89 = new Movie()
            {
                Imdb_Id = "tt0458525",
                Title = "X-Men Origins: Wolverine",
                Genre_Id = gen2.Id,
                Director = "Gavin Hood",
                Poster = "http://image.tmdb.org/t/p/original//mEuDxpLNBCarVgXRqDznHT7bdS8.jpg",
                Youtube_Trailer = "Diqtd1gTUEc",
                Release_Date = DateTime.ParseExact("01/05/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "Two mutant brothers, Logan and Victor, born 200 years ago, suffer childhood trauma and have only each other to depend on. Basically, they\'re fighters and killers, living from war to war through U.S. history. In modern times, a U.S. colonel, Stryker, recruits them and other mutants as commandos. Logan quits and becomes a logger, falling in love with a local teacher. When Logan refuses to rejoin Stryker\'s crew, the colonel sends the murderous Victor. Logan now wants revenge.",
                Duration = 107,
                Views_Count = 0
            };
            m89.Add();
            Movie m90 = new Movie()
            {
                Imdb_Id = "tt0472033",
                Title = "9",
                Genre_Id = gen1.Id,
                Director = "Shane Acker",
                Poster = "http://image.tmdb.org/t/p/original//yvrcEy8RUqHpM6mlZSM9ejRAh8Z.jpg",
                Youtube_Trailer = "_qApXdc1WPY",
                Release_Date = DateTime.ParseExact("09/09/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "In a world destroyed in a war between man and machine, a hand-stitched doll with the number 9 written on its back comes to life. The world he has awakened in is frightening, but he quickly learns that he is not alone and that there are others like him, also with a single digit written on their back. The first one he encounters is 2 who tells him something of what happened to the world. 2 is also thrilled with the disk 9 is carrying, one with three unique symbols on the front. 9 soon learns that the disk and some of the other dolls who are prepared to die for the good of humankind may be the last hope for man\'s salvation.",
                Duration = 79,
                Views_Count = 0
            };
            m90.Add();
            Movie m91 = new Movie()
            {
                Imdb_Id = "tt1007028",
                Title = "Zack and Miri Make a Porno",
                Genre_Id = gen17.Id,
                Director = "Kevin Smith",
                Poster = "http://image.tmdb.org/t/p/original//kKoVVOd3HBDz9EVarFEGl6xU7r6.jpg",
                Youtube_Trailer = "u2Y3cCOkz8o",
                Release_Date = DateTime.ParseExact("31/10/2008", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2008,
                Description = "Zack and Miri are two lifelong platonic friends who make an adult film to pay the rent of their apartment. With their friend Delaney, the couple set out for auditionees for their porn film, but in the process of filming, they realize they feel more for each other than they had before.",
                Duration = 101,
                Views_Count = 0
            };
            m91.Add();
            Movie m92 = new Movie()
            {
                Imdb_Id = "tt0910970",
                Title = "WALL·E",
                Genre_Id = gen2.Id,
                Director = "Andrew Stanton",
                Poster = "http://image.tmdb.org/t/p/original//2nFyTvssbtJMLC6eyYwwZ88gALD.jpg",
                Youtube_Trailer = "8-_9n5DtKOc",
                Release_Date = DateTime.ParseExact("27/06/2008", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2008,
                Description = "In a distant, but not so unrealistic, future where mankind has abandoned earth because it has become covered with trash from products sold by the powerful multi-national Buy N Large corporation, WALL-E, a garbage collecting robot has been left to clean up the mess. Mesmerized with trinkets of Earth\'s history and show tunes, WALL-E is alone on Earth except for a sprightly pet cockroach. One day, EVE, a sleek (and dangerous) reconnaissance robot, is sent to Earth to find proof that life is once again sustainable. WALL-E falls in love with EVE. WALL-E rescues EVE from a dust storm and shows her a living plant he found amongst the rubble. Consistent with her \"directive\", EVE takes the plant and automatically enters a deactivated state except for a blinking green beacon. WALL-E, doesn\'t understand what has happened to his new friend, but, true to his love, he protects her from wind, rain, and lightning, even as she is unresponsive. One day a massive ship comes to reclaim EVE, but WALL-E, out of love or loneliness, hitches a ride on the outside of the ship to rescue EVE. The ship arrives back at a large space cruise ship, which is carrying all of the humans who evacuated Earth 700 years earlier. The people of Earth ride around this space resort on hovering chairs which give them a constant feed of TV and video chatting. They drink all of their meals through a straw out of laziness and/or bone loss, and are all so fat that they can barely move. When the auto-pilot computer, acting on hastily-given instructions sent many centuries before, tries to prevent the people of Earth from returning by stealing the plant, WALL-E, EVE, the portly captain, and a band of broken robots stage a mutiny.",
                Duration = 98,
                Views_Count = 0
            };
            m92.Add();
            Movie m93 = new Movie()
            {
                Imdb_Id = "tt1087828",
                Title = "Aces 'N' Eights",
                Genre_Id = gen2.Id,
                Director = "Craig R. Baxley",
                Poster = "http://image.tmdb.org/t/p/original//cJFnvyjVZqt53vafDP0HxvGglsH.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/03/2008", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2008,
                Description = "Already taking a gamble settling in the uncharted west, the peaceful settlers of a town destined for railroad greatness suddenly find themselves being ruthlessly gunned down. With no law and order to be found, justice falls onto the shoulders of an elderly rancher and an accomplished, but retired, gunslinger.",
                Duration = 87,
                Views_Count = 0
            };
            m93.Add();
            Movie m94 = new Movie()
            {
                Imdb_Id = "tt0795368",
                Title = "Death at a Funeral",
                Genre_Id = gen14.Id,
                Director = "Frank Oz",
                Poster = "http://image.tmdb.org/t/p/original//ffXvlcmRhl0F9gyNdvTpFFa4ybt.jpg",
                Youtube_Trailer = "neCY4hh1wJg",
                Release_Date = DateTime.ParseExact("07/09/2007", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2007,
                Description = "Daniel is a decent young man, married to Jane, still living at his father\'s home. When his father dies, it is up to him to organize his funeral. On this painful morning, the suitable grave expression on his face, Daniel is ready to welcome his father\'s friends and relatives. But preserving the dignity inherent in such circumstances will be a hard task. Particularly with an undertaker who botches his work, the return from the USA of his famous but selfish brother, his cousin\'s fiancé who has accidentally ingested drugs, the presence a moron who takes advantage of the sad event to win back the heart (or rather the body) of a woman who is about to marry another, of a handicapped old uncle who is also the most unbearable pain in the neck. To cap it all, Daniel notices the presence among the mourners of a mysterious dwarf nobody else seems to know...",
                Duration = 90,
                Views_Count = 0
            };
            m94.Add();
            Movie m95 = new Movie()
            {
                Imdb_Id = "tt0480249",
                Title = "I Am Legend",
                Genre_Id = gen13.Id,
                Director = "Francis Lawrence",
                Poster = "http://image.tmdb.org/t/p/original//u6Qg7TH7Oh1IFWCQSRr4htFFt0A.jpg",
                Youtube_Trailer = "sFNPNT_4Qww",
                Release_Date = DateTime.ParseExact("14/12/2007", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2007,
                Description = "Robert Neville is a scientist who was unable to stop the spread of the terrible virus that was incurable and man-made. Immune, Neville is now the last human survivor in what is left of New York City and perhaps the world. For three years, Neville has faithfully sent out daily radio messages, desperate to find any other survivors who might be out there. But he is not alone. Mutant victims of the plague -- The Infected -- lurk in the shadows... watching Neville\'s every move... waiting for him to make a fatal mistake. Perhaps mankind\'s last, best hope, Neville is driven by only one remaining mission: to find a way to reverse the effects of the virus using his own immune blood. But he knows he is outnumbered... and quickly running out of time.",
                Duration = 101,
                Views_Count = 0
            };
            m95.Add();
            Movie m96 = new Movie()
            {
                Imdb_Id = "tt0862856",
                Title = "Trick 'r Treat",
                Genre_Id = gen13.Id,
                Director = "Michael Dougherty",
                Poster = "http://image.tmdb.org/t/p/original//oFxeGxRjlwzf0qct3g1HGBujGqH.jpg",
                Youtube_Trailer = "wUqsXvBAqRY",
                Release_Date = DateTime.ParseExact("09/12/2007", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2007,
                Description = "Five interwoven stories that occur on the same block, on the same night. A couple finds what happens when they blow a jack o\' lantern out before midnight, a high school principal has a secret life as a serial killer, a college virgin might have met the right guy for her, a group of mean teens play a prank that they take too far, and a hermit is visited by a special trick or treater.",
                Duration = 82,
                Views_Count = 0
            };
            m96.Add();
            Movie m97 = new Movie()
            {
                Imdb_Id = "tt1104686",
                Title = "Boys Life 6",
                Genre_Id = gen17.Id,
                Director = "Soman Chainani, Mark Christopher, Etienne Kallos, Carter Smith",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("27/11/2007", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2007,
                Description = "Anthology of four gay-themed stories of diverse natures and development - an outline, a thriller, an interlude and an idea. In \'Bugcrush\': Sex, danger, fascination and uncertainty draw small town gay high schooler Ben toward mysterious newcomer Grant. Inch-worming his way closer, Ben succeeds in gaining passage into Grant\'s rough-edged and foreboding inner circle for an experience he hardly could\'ve imagined. In \'Doorman\': A front desk manager has a highly uneven intimate encounter with a jaded hotel guest. In \'Davey & Stu\': Two Scottish boys meet near a bog to enjoy each other\'s company. In \'Heartland\": A non-native New York collegian heads back to his family\'s Iowa farm where he\'s needed but where his heart does not reside.",
                Duration = 80,
                Views_Count = 0
            };
            m97.Add();
            Movie m98 = new Movie()
            {
                Imdb_Id = "tt0972353",
                Title = "The Conspiracy Files: 9/11",
                Genre_Id = gen17.Id,
                Director = "Guy Smith",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("18/02/2007", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2007,
                Description = "This should be essential viewing for all 9/11 conspiracy theorists. It examines all the conspiracies circulating on the Internet and elsewhere, and neatly demolishes them with the truth. ...",
                Duration = 72,
                Views_Count = 0
            };
            m98.Add();
            Movie m99 = new Movie()
            {
                Imdb_Id = "tt0396171",
                Title = "Perfume: The Story of a Murderer",
                Genre_Id = gen8.Id,
                Director = "Tom Tykwer",
                Poster = "http://image.tmdb.org/t/p/original//3i8bJa5yvLZW2k4sg2Cd1Yy0a1x.jpg",
                Youtube_Trailer = "zutiIw_2e2g",
                Release_Date = DateTime.ParseExact("05/01/2007", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2007,
                Description = "Jean-Baptiste Grenouille came into the world unwanted, expected to die, yet born with an unnerving sense of smell that created alienation as well as talent. Of all the smells around him, Grenouille is beckoned to the scent of a woman\'s soul, and spends the rest of his life attempting to smell her essence again by becoming a perfumer, and creating the essence of an innocence lost.",
                Duration = 147,
                Views_Count = 0
            };
            m99.Add();
            Movie m100 = new Movie()
            {
                Imdb_Id = "tt0365830",
                Title = "Tenacious D in The Pick of Destiny",
                Genre_Id = gen5.Id,
                Director = "Liam Lynch",
                Poster = "http://image.tmdb.org/t/p/original//9mVTP2P5yvW4MgygJQMI7WA6B6h.jpg",
                Youtube_Trailer = "TXxQFMG86HA",
                Release_Date = DateTime.ParseExact("22/11/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "This is the story of a friendship that changes the course of rock history forever, of the fateful collision of minds between JB and KG that led to the creation of the precedent-shattering band Tenacious D, and of the two heroes\' quest to find the fabled Guitar Pick Of Destiny...",
                Duration = 93,
                Views_Count = 0
            };
            m100.Add();
            Movie m101 = new Movie()
            {
                Imdb_Id = "tt0479874",
                Title = "Bullets, Blood & a Fistful of Ca$h",
                Genre_Id = gen6.Id,
                Director = "Sam Akina",
                Poster = "http://image.tmdb.org/t/p/original//8rBRv543BrtM1A4ioUDHmiftHl.jpg",
                Youtube_Trailer = "B7jDR5tc2Jw",
                Release_Date = DateTime.ParseExact("02/05/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "A hard boiled tale of bloody revenge that interweaves the stories of nine criminals. Hector Gonzales, a ruthless kingpin who has risen through the ranks over the last ten years and now stands on the verge of ruling the city; Bill Nguyen, a Vietnamese mafia boss; Abe Shanks, a black market organ dealer; Johnny Tran, a young Dai Ca within Nguyen\'s Viet mafia; Tommy Two Toes, a hot tempered Sicilian Capo; Lenny, a brutal mercenary working for the highest bidder; Pablo Valdez, a flamboyant Columbian drug lord; Donnie Edwards, a drug dealing Vice cop with aspirations to escape the undertow of the cities criminal milieu; and, at the center of this dark yarn, Cash, a gunslinging ex-convict on a death quest to find the man who raped and murdered his wife over a decade ago, Hector Gonzales. The story takes place in one day, on the eve of an all out syndicate war. Through a twisted series of events, the interweaving narratives are put on an ultra-violent collision course that will determine, once and for all, who owns the streets.",
                Duration = 115,
                Views_Count = 0
            };
            m101.Add();
            Movie m102 = new Movie()
            {
                Imdb_Id = "tt0478090",
                Title = "A/k/a Tommy Chong",
                Genre_Id = gen18.Id,
                Director = "Josh Gilbert",
                Poster = "http://image.tmdb.org/t/p/original//pxGez4ZTnkZTSeGJNtVoq7R1c7p.jpg",
                Youtube_Trailer = "wQy-SjnxeCY",
                Release_Date = DateTime.ParseExact("01/03/2008", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2008,
                Description = "At the height of popularity of the Bush administration -- the federal government entrapped and subsequently imprisoned Tommy Chong. Josh Gilbert began documenting the federal case against his long time friend and counter-culture icon for the terrible crime of selling bongs. This film examines the personal effects on Tommy, the motivations and tactics of the politicized Justice Department under George Bush, set against the back drop of the War on Drugs and the legal issues involved.",
                Duration = 80,
                Views_Count = 0
            };
            m102.Add();
            Movie m103 = new Movie()
            {
                Imdb_Id = "tt0775438",
                Title = "Buy the Ticket, Take the Ride: Hunter S. Thompson on Film",
                Genre_Id = gen9.Id,
                Director = "Tom Thurman",
                Poster = "http://image.tmdb.org/t/p/original//k5rhGLUxMr7tBNX7e9CbmTsN9E0.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("12/12/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "\"Buy The Ticket, Take The Ride: Hunter S. Thompson On Film is a personal, intimate look at Thompson with a special emphasis on his Hollywood relationships. It captures the legacy and \"gonzo\" spirit of one of this century\'s most notorious figures - a man whose life and work regularly intersected with some of the biggest names in the world of film, politics, journalism and sports. The documentary features interviews with Hunter\'s inner circle of family and friends, but the thrust of the film is focused on the manner in which his life often overlapped with numerous Hollywood celebrities who became his close friends, such as Johnny Depp and Benicio Del Toro (Fear and Loathing in Las Vegas); Bill Murray (Where the Buffalo Roam); Sean Penn, John Cusack, Hunter\'s wife Anita, son Juan, former Senators George McGovern and Gary Hart, Tom Wolfe, William F. Buckley, Gary Busey, Harry Dean Stanton, Ralph Steadman and others.",
                Duration = 73,
                Views_Count = 0
            };
            m103.Add();
            Movie m104 = new Movie()
            {
                Imdb_Id = "tt0376994",
                Title = "X-Men: The Last Stand",
                Genre_Id = gen2.Id,
                Director = "Brett Ratner",
                Poster = "http://image.tmdb.org/t/p/original//w3Yc8wi2jYLaOyCW6b6svf1B0MG.jpg",
                Youtube_Trailer = "yaqeXXuoD7I",
                Release_Date = DateTime.ParseExact("26/05/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "When a cure is created, which apparently can turn any mutant into a normal human being, there is outrage amongst the mutant community. Whilst some mutants do like the idea of a cure, including Rogue, many mutants find that there shouldn\'t be a cure. Magneto, who still believes a war is coming, recruits a large team of mutants to take down Warren Worthington II and his cure. Might seem easy for the X-Men to stop, but Magneto has a big advantage, which Wolverine doesn\'t have. Jean Grey has returned, and joined with Magneto. The Phoenix has woken within her, which has the ability to destroy anything in her way, even if that \'anything\' is a X-Men.",
                Duration = 104,
                Views_Count = 0
            };
            m104.Add();
            Movie m105 = new Movie()
            {
                Imdb_Id = "tt0865482",
                Title = "Katt Williams: The Pimp Chronicles Pt. 1",
                Genre_Id = gen5.Id,
                Director = "Anthony Anderson, Gary Binkow",
                Poster = "http://image.tmdb.org/t/p/original//2bo5YyzpsPSlZ5pyY167gAz5ub3.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/09/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "In-demand comedian Katt Williams offers up The Pimp Chronicles courtesy of HBO. Williams shares his thoughts on such topics as drugs, politics and pop culture in this special event.",
                Duration = 45,
                Views_Count = 0
            };
            m105.Add();
            Movie m106 = new Movie()
            {
                Imdb_Id = "tt0451187",
                Title = "Room 6",
                Genre_Id = gen16.Id,
                Director = "Michael Hurst",
                Poster = "http://image.tmdb.org/t/p/original//znFf9HmT5CIXV7U4IGmEzCBkEAo.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("13/06/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "The school teacher Amy has been proposed by her boyfriend Nick early in the morning and she promises her answer later in the afternoon. After her class, while coming back home, Nick has a car accident in a crossroad with a truck driven by Lucas Dylan. He breaks his leg and an ambulance takes him to the hospital. Amy has a phobia about hospitals, but she gets a taxi and goes to the nearest hospital. However, Nick is not there, and she meets Lucas, who is also looking for his sister that has disappeared in the same weird circumstance. They decide to team up and search together where the victims might have been interned, while Amy experiences the most bizarre and scary situations.",
                Duration = 94,
                Views_Count = 0
            };
            m106.Add();
            Movie m107 = new Movie()
            {
                Imdb_Id = "tt0493386",
                Title = "8 of Diamonds",
                Genre_Id = gen18.Id,
                Director = "Scott Prestin",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/02/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "Three thieves scheme to steal a flawless 20-carate diamond worth $2 million. But as their plan unfolds, everything begins to fall apart. The rock is swallowed by a man who then dies, leading to a gruesome amateur autopsy. Also, significant others and fellow criminals resort to blackmail to get a piece of the action, and all three men fall victim to rampant paranoia.",
                Duration = 89,
                Views_Count = 0
            };
            m107.Add();
            Movie m108 = new Movie()
            {
                Imdb_Id = "tt0417003",
                Title = "The N Word",
                Genre_Id = gen5.Id,
                Director = "Todd Williams",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "uhtKsgYZorg",
                Release_Date = DateTime.ParseExact("26/06/2004", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2004,
                Description = "A documentary looking at the N word.",
                Duration = 86,
                Views_Count = 0
            };
            m108.Add();
            Movie m109 = new Movie()
            {
                Imdb_Id = "tt0317042",
                Title = "One Point O",
                Genre_Id = gen13.Id,
                Director = "Jeff Renfroe, Marteinn Thorsson",
                Poster = "http://image.tmdb.org/t/p/original//S41EVQBY7uUGnGio26Fc8Z1cg1.jpg",
                Youtube_Trailer = "rw3V_VnRoaA",
                Release_Date = DateTime.ParseExact("21/01/2005", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2005,
                Description = "After receiving mysterious empty packages inside his apartment, a young computer-programmer begins a personal investigation into their origins.",
                Duration = 92,
                Views_Count = 0
            };
            m109.Add();
            Movie m110 = new Movie()
            {
                Imdb_Id = "tt0405496",
                Title = "Z Channel: A Magnificent Obsession",
                Genre_Id = gen12.Id,
                Director = "Xan Cassavetes",
                Poster = "http://image.tmdb.org/t/p/original//1eW9nK3T3ZEYtU4UUCVpyaYcA4e.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/08/2007", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2007,
                Description = "A documentary on the Z Channel, one of the first pay cable stations in the US, and its programming chief, Jerry Harvey. Debuting in 1974, the LA-based channel\'s eclectic slate of movies became a prime example of the untapped power of cable television.",
                Duration = 120,
                Views_Count = 0
            };
            m110.Add();
            Movie m111 = new Movie()
            {
                Imdb_Id = "tt0428144",
                Title = "Category 6: Day of Destruction",
                Genre_Id = gen2.Id,
                Director = "Dick Lowry",
                Poster = "http://image.tmdb.org/t/p/original//m05khhqm20R73Gy6QOsUP9HG4Og.jpg",
                Youtube_Trailer = "23ukVzItvno",
                Release_Date = DateTime.ParseExact("14/11/2004", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2004,
                Description = "Tornado in Las Vegas. Heat in Chicago. Hail in Illinois. A snowfall and a storm force flows towards Chicago. It\'s just the beginning of a series of weather anomalies. The lights go off. People panic. A few courageous people are trying to solve the riddle of the infuriated nature and prevent mass destruction.",
                Duration = 175,
                Views_Count = 0
            };
            m111.Add();
            Movie m112 = new Movie()
            {
                Imdb_Id = "tt0433737",
                Title = "Straight 8",
                Genre_Id = gen8.Id,
                Director = "Shane Davey, Ben Gregor, Nick Rutter, Ed Sayers, Edgar Wright",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("04/11/2004", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2004,
                Description = "Ed Sayers and Ben Gregor came up with a novel idea for making films and engaging the film community. They bought a load of old super 8 film cartridges and sent them up to various filmmakers. The challenge to each was to make a 3-minute film without any edits or post-production and not to see that film until it is shown in front of a live audience and on television. Attracting well-known directors and students alike, the project spawned quite a following as well as this short television series, showcasing about 10 of the shorts over two episodes.",
                Duration = 60,
                Views_Count = 0
            };
            m112.Add();
            Movie m113 = new Movie()
            {
                Imdb_Id = "tt0315775",
                Title = "Anne B. Real",
                Genre_Id = gen5.Id,
                Director = "Lisa France",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("14/06/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "The coming of age story of a young female rapper, who finds her inspiration by reading the Diary of Anne Frank.",
                Duration = 91,
                Views_Count = 0
            };
            m113.Add();
            Movie m114 = new Movie()
            {
                Imdb_Id = "tt0338459",
                Title = "Spy Kids 3-D: Game Over",
                Genre_Id = gen2.Id,
                Director = "Robert Rodriguez",
                Poster = "http://image.tmdb.org/t/p/original//bmuTrxbPcr1nKCsV5YWWJi73PGR.jpg",
                Youtube_Trailer = "mx0lo-xCljA",
                Release_Date = DateTime.ParseExact("25/07/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "Under-age agents Juni and Carmen Cortez set out on their newest most mind-blowing mission yet: journeying inside the virtual reality world of a 3-D video game designed to outsmart them, as the awe-inspiring graphics and creatures of gaming come to real life. Relying on humor, gadgetry, bravery, family bonds and lightning-quick reflexes, the Spy Kids must battle through tougher and tougher levels of the game, facing challenges that include racing against road warriors and surfing on boiling lava, in order to save the world from a power hungry villain.",
                Duration = 84,
                Views_Count = 0
            };
            m114.Add();
            Movie m115 = new Movie()
            {
                Imdb_Id = "tt0326814",
                Title = "The Crooked E: The Unshredded Truth About Enron",
                Genre_Id = gen7.Id,
                Director = "Penelope Spheeris",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("05/01/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "Brian Cruver, an ambitious 26-year-old lands a job at Enron. As he assimilates to the company\'s get-rich-quick mantra, spending sprees and wild corporate \"gatherings\" become the norm. But when Enron files for bankruptcy, Cruver discovers he\'s just a pawn in a failing game of corporate greed--one that made the rich richer...while the rest lost everything.",
                Duration = 100,
                Views_Count = 0
            };
            m115.Add();
            Movie m116 = new Movie()
            {
                Imdb_Id = "tt0346504",
                Title = "America's Prince: The John F. Kennedy Jr. Story",
                Genre_Id = gen8.Id,
                Director = "Eric Laneuville",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("12/01/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "It may sound like a fairy tale, being born as son of the murdered JFK, the most \'regal\' US President ever, but for John \'John-John\' Kennedy, it\'s a burden. When he becomes an Assistant D.A., the press is all over him, flunking one exam gets smeared all over the national press, wherever he goes people point at him, recognizing face and/or name, but hardly notice what he actually does. His mediatic mother Jacqueline Kennedy-Onassis pushes him, stifles him, forbids him to become an actor or won\'t hear of him dating an actress, then dies herself. Finally the legendary Kennedy curse, which never skipped a generation, chooses him to be the victim of an airplane accident...",
                Duration = 100,
                Views_Count = 0
            };
            m116.Add();
            Movie m117 = new Movie()
            {
                Imdb_Id = "tt0359203",
                Title = "Easy Riders, Raging Bulls: How the Sex, Drugs and Rock 'N' Roll Generation Saved Hollywood",
                Genre_Id = gen19.Id,
                Director = "Kenneth Bowser",
                Poster = "http://image.tmdb.org/t/p/original//dnNgmpMUy2QFOoLTwtNjLZkuEvv.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("09/03/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "Based upon Peter Biskind\'s book of the same name, this BBC-produced documentary traces the rise of a generation of Hollywood filmmakers who briefly changed the face of movies with a more personal approach that pushed the boundaries of what was acceptable on-screen. Influential directors who appear include Arthur Penn (\"Bonnie and Clyde\"), Dennis Hopper (\"Easy Rider\"), Francis Ford Coppola (\"The Godfather\"), John Schlesinger (\"Midnight Cowboy\"), Bob Rafelson (\"Five Easy Pieces\") Martin Scorsese (\"Taxi Driver\"), Peter Bogdanovich (\"The Last Picture Show\"), and Jonathan Demme (\"Crazy Mama\"). Narrated by William H. Macy, the documentary features vintage clips of Coppola, Scorsese, Beatty, George Lucas, Sam Peckinpah, Roman Polanski, Robert Altman, and Pauline Kael. It also includes original interview material with Penn; Roger Corman; Bogdanovich; Hopper; David Picker; writer/directors John Milius and Paul Schrader; actresses Karen Black, Cybill Shepherd, Margot Kidder, and Jennifer Salt; actors Peter Fonda, Kris Kristofferson, and Richard Dreyfuss; producers Jerome Hellman, Michael Phillips, and Jonathan Taplin; editor Dede Allen; production designer Polly Platt; writers David Newman, Joan Tewksbury, Gloria Katz, and Willard Huyck; cinematographers Laszlo Kovacs and Vilmos Zsigmond; agent Mike Medavoy; and former production executive Peter Bart. Among the films discussed are \"Rosemary\'s Baby,\" \"The Wild Bunch,\" \"Mean Streets,\" \"American Graffiti,\" \"The Rain People,\" \"Midnight Cowboy,\" \"M*A*S*H,\" \"McCabe and Mrs. Miller,\" \"The Last Picture Show,\" \"Shampoo,\" and \"Taxi Driver.\"",
                Duration = 119,
                Views_Count = 0
            };
            m117.Add();
            Movie m118 = new Movie()
            {
                Imdb_Id = "tt0317910",
                Title = "The Fog of War: Eleven Lessons from the Life of Robert S. McNamara",
                Genre_Id = gen4.Id,
                Director = "Errol Morris",
                Poster = "http://image.tmdb.org/t/p/original//5Jsgx8bQ5430kshplPqhX7CYqmc.jpg",
                Youtube_Trailer = "VgA98V1Ubk8",
                Release_Date = DateTime.ParseExact("05/03/2004", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2004,
                Description = "Former corporate whiz kid Robert McNamara was the controversial Secretary of Defense in the Kennedy and Johnson administrations, during the height of the Vietnam War. This Academy Award-winning documentary, augmented by archival footage, gives the conflicted McNamara a platform on which he attempts to confront his and the U.S. government\'s actions in Southeast Asia in light of the horrors of modern warfare, the end of ideology and the punitive judgment of history.",
                Duration = 107,
                Views_Count = 0
            };
            m118.Add();
            Movie m119 = new Movie()
            {
                Imdb_Id = "tt0387887",
                Title = "Bottom Live 2003: Weapons Grade Y-Fronts Tour",
                Genre_Id = gen14.Id,
                Director = "Dewi Humphreys",
                Poster = "http://image.tmdb.org/t/p/original//812TARhbdo2q3Ymni1BpG45H2db.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/11/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "Eddie has locked himself away in the toilet and Richie finds he\'s been inventing gadgets and only to find himself joining Eddie on a adventure through time and space on-board Eddie\'s time machine \"The Turdis\" which is a toilet cubicle.",
                Duration = 93,
                Views_Count = 0
            };
            m119.Add();
            Movie m120 = new Movie()
            {
                Imdb_Id = "tt0181852",
                Title = "Terminator 3: Rise of the Machines",
                Genre_Id = gen18.Id,
                Director = "Jonathan Mostow",
                Poster = "http://image.tmdb.org/t/p/original//8ZuMyOjFpwq1tNU9MAFN836Wb1b.jpg",
                Youtube_Trailer = "kQkud3NfvMo",
                Release_Date = DateTime.ParseExact("02/07/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "More than 10 years after \'Terminator 2\', John Connor now exists only as a drifter - living \'off the grid\', so no more Terminators from the future can hunt him down. Unfortunately, SkyNet does send another one back - and this one is called the T-X, even more powerful & advanced than the dreaded T-1000. However, another CSM-101 Terminator is also sent back to protect John against the T-X. Now, Skynet is patiently assuming control of civilian computer systems, under the guise of a computer virus. John has also met his future wife, Kate Brewster, whose father - a U.S. Air Force General - is in charge of the military computer systems & is leery of up linking SkyNet. However, when the SkyNet virus infects the U.S military computers & leaves the country open to attack, the machines begin their horrific takeover. Soon a nuclear war will result - and the war against the machines will begin. Can the outdated CSM-101 Terminator eliminate the highly advanced T-X - or will a darker future await man following the nuclear attack?",
                Duration = 109,
                Views_Count = 0
            };
            m120.Add();
            Movie m121 = new Movie()
            {
                Imdb_Id = "tt0360985",
                Title = "Shrek 4-D",
                Genre_Id = gen2.Id,
                Director = "Simon J. Smith",
                Poster = "http://image.tmdb.org/t/p/original//xpQ2LmhlY5ds1fSlCEwPfAN0vrm.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/09/2009", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2009,
                Description = "Shrek, Fiona, and Donkey are on their way to the hotel where Shrek and Fiona will spend their honeymoon when they encounter Lord Farquaad\'s ghost! Farquaad sends his henchman, Thelonious, to bring Princess Fiona to him where he will force her to become the queen of the ghostly world. Now, Shrek and Donkey must save the princess in this timeless tale that\'s filled with spooky-good fun",
                Duration = 13,
                Views_Count = 0
            };
            m121.Add();
            Movie m122 = new Movie()
            {
                Imdb_Id = "tt0370904",
                Title = "Lucky 7",
                Genre_Id = gen17.Id,
                Director = "Harry Winer",
                Poster = "http://image.tmdb.org/t/p/original//ynG0a4AQI8D5L9iaL5On9lhOQhE.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("20/07/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "Instead of really living her life, since losing her mother at age seven, Seattle lawyer Amy Myer sticks to a ridiculously detailed time-line mother drew as a guideline in all walks of life, even love in search of marriage with \'number 7\'. Despite good advice from father Bernie, aunt Rachel and uncle ray, she refuses to contemplate going steady with any of the six first steady boyfriends, even apparently perfect businessman Daniel McCandles. She initially declines accompanying a good friend, bagel shop manager Connor, to a family wedding as his pretend-fiancée, but changes her mind so Daniel can be lucky seven afterward. However, Peter proves a perfect match, and able to make her reconsider the blind life schedule.",
                Duration = 95,
                Views_Count = 0
            };
            m122.Add();
            Movie m123 = new Movie()
            {
                Imdb_Id = "tt0281358",
                Title = "A Walk to Remember",
                Genre_Id = gen17.Id,
                Director = "Adam Shankman",
                Poster = "http://image.tmdb.org/t/p/original//nKHwNmUGe002ayPlfwG9CVTIXC2.jpg",
                Youtube_Trailer = "Kq02sBe5xko",
                Release_Date = DateTime.ParseExact("25/01/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "In North Carolina especially in Beaufort a prank on a girl goes wrong and puts the student in the clinic. Carter, a famous student with no plans for the future, is held responsible and forced to join in after-school community service activities as consequence, which include starring as the lead in the play. And participating in these activities is Jamie Sullivan, the reverend\'s daughter who has great ambitions and nothing in common with Landon. When Landon decides he wants to take his activities seriously, he asks Jamie for help and begins to spend most of his time with her. But he starts to like her, that he did not expect to do. They relationship, much to the chagrin of Landon\'s old popular friends and Jamie\'s strict reverend father. But when a heart-breaking secret becomes known that puts their relationship to the test, it is then that Landon and Jamie realize the true meaning of love and fate.",
                Duration = 101,
                Views_Count = 0
            };
            m123.Add();
            Movie m124 = new Movie()
            {
                Imdb_Id = "tt0291928",
                Title = "G",
                Genre_Id = gen17.Id,
                Director = "Christopher Scott Cherot",
                Poster = "http://image.tmdb.org/t/p/original//eYTpDFknXbGi4CnPBgLR9nKUqlY.jpg",
                Youtube_Trailer = "n-uvPeKVOVw",
                Release_Date = DateTime.ParseExact("28/10/2005", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2005,
                Description = "A young Great Gatsbyish Hip Hopper named Summer G falls for a middle to upper class sister while in college. After she rejects him for a fellow social climber, Summer G spends ten years building a Hip Hop empire, then moves to the Hamptons where he finds the object of his affections.",
                Duration = 97,
                Views_Count = 0
            };
            m124.Add();
            Movie m125 = new Movie()
            {
                Imdb_Id = "tt0333694",
                Title = "K",
                Genre_Id = gen10.Id,
                Director = "Shoja Azari",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("31/08/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "Three stories. We see, but little is explained. In \"The Married Couple,\" a salesman pays a call on an old customer who is with his wife in the upstairs bedroom of their ill adult son. Another salesman may beat him to the punch, but not before disorienting changes. A maid scrubs the floor. \"In the Penal Colony\": a man arrives at a penal colony where an officer demonstrates a bizarre apparatus, one that punches a message into the skin of a prisoner strapped beneath it. Who will be punished? In \"Fratricide,\" a man is murdered at night by someone he knows well. A woman grieves.",
                Duration = 85,
                Views_Count = 0
            };
            m125.Add();
            Movie m126 = new Movie()
            {
                Imdb_Id = "tt0282386",
                Title = "Blood Feast 2: All U Can Eat",
                Genre_Id = gen13.Id,
                Director = "Herschell Gordon Lewis",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "3pzZcJQUxpo",
                Release_Date = DateTime.ParseExact("29/07/2003", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2003,
                Description = "A cannibal caterer kills various young women in preparation for a ritual feast for a long-dormant Egyptian goddess that has him under its control.",
                Duration = 92,
                Views_Count = 0
            };
            m126.Add();
            Movie m127 = new Movie()
            {
                Imdb_Id = "tt0287717",
                Title = "Spy Kids 2: Island of Lost Dreams",
                Genre_Id = gen2.Id,
                Director = "Robert Rodriguez",
                Poster = "http://image.tmdb.org/t/p/original//5rKa5UKXnTdLsgY0mJbjAEQX3gB.jpg",
                Youtube_Trailer = "RLkRbj8sv8E",
                Release_Date = DateTime.ParseExact("07/08/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "Exploring the further adventures of Carmen and Juni Cortez, who have now joined the family spy business as Level 2 OSS agents. Their new mission is to save the world from a mad scientist living on a volcanic island populated by an imaginative menagerie of creatures. On this bizarre island, none of the Cortez\'s gadgets work and they must rely on their wits--and each other--to survive and save the day.",
                Duration = 100,
                Views_Count = 0
            };
            m127.Add();
            Movie m128 = new Movie()
            {
                Imdb_Id = "tt0313597",
                Title = "Shark Attack 3: Megalodon",
                Genre_Id = gen2.Id,
                Director = "David Worth",
                Poster = "http://image.tmdb.org/t/p/original//8P5ZqlmV3hrqjlXXeoMTaj4Hdch.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("20/10/2004", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2004,
                Description = "Twenty-four million years ago, Megalodon was a 20 tonne killing machine with a 10 foot gaping bite. When two researchers discover a colossal shark\'s tooth off the Mexican coast their worst fears surface - the most menacing beast to ever rule the waters is still alive and mercilessly feeding on anything that crosses its path. Now they must hunt the fierce killer and destroy it... before there is no one left to stop its reign of terror!",
                Duration = 99,
                Views_Count = 0
            };
            m128.Add();
            Movie m129 = new Movie()
            {
                Imdb_Id = "tt0295732",
                Title = "Trancers 6",
                Genre_Id = gen13.Id,
                Director = "Jay Woelfel",
                Poster = "http://image.tmdb.org/t/p/original//tJJLluylmHwHdzMKTHXDNWp05gb.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("23/07/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "In a return to the groundbreaking original film\'s premise, Jack Deth is back - traveling back in time and into the body of his own daughter, Josephine, on a mission to save her life and save the world from the most lethal Trancers yet. Jack/Jo must adapt and survive being a girl while avoiding many assassination attempts by more powerful and dangerous zombie-like Trancers than he\'s ever faced before in the series. With his new friends, his new enemies and a new female hero are set to take Trancers into the next century for both the planet and Full Moon Pictures.",
                Duration = 88,
                Views_Count = 0
            };
            m129.Add();
            Movie m130 = new Movie()
            {
                Imdb_Id = "tt0298203",
                Title = "8 Mile",
                Genre_Id = gen14.Id,
                Director = "Curtis Hanson",
                Poster = "http://image.tmdb.org/t/p/original//jq4dyVYsCGQRTXKDLoqZwg4tbIr.jpg",
                Youtube_Trailer = "bhXKfqqcfiY",
                Release_Date = DateTime.ParseExact("08/11/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "This is the inspiring captivating story of the legendary rapper Eminem. The troubled young aspiring rapper from a ghetto in Michigan must exert his last chances to become successful while dealing with his life in ruins. All is seemingly lost. He is now single, has only a few friends, an insane/alcoholic mother, and is dealt with poverty and living in a violent city on 8 mile. His only way out of the ghetto and torturous life he\'s living in is with his talent in rapping. Will B-Rabbit prevail and seize the shot he\'s given or will he let it slip?",
                Duration = 110,
                Views_Count = 0
            };
            m130.Add();
            Movie m131 = new Movie()
            {
                Imdb_Id = "tt0268978",
                Title = "A Beautiful Mind",
                Genre_Id = gen8.Id,
                Director = "Ron Howard",
                Poster = "http://image.tmdb.org/t/p/original//9PwUQZDHGPKsgbnoBl1Ah9zXWjk.jpg",
                Youtube_Trailer = "WFJgUm7iOKw",
                Release_Date = DateTime.ParseExact("04/01/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "From the heights of notoriety to the depths of depravity, John Forbes Nash, Jr. experienced it all. A mathematical genius, he made an astonishing discovery early in his career and stood on the brink of international acclaim. But the handsome and arrogant Nash soon found himself on a painful and harrowing journey of self-discovery. After many years of struggle, he eventually triumphed over his tragedy, and finally - late in life - received the Nobel Prize.",
                Duration = 135,
                Views_Count = 0
            };
            m131.Add();
            Movie m132 = new Movie()
            {
                Imdb_Id = "tt0303621",
                Title = "Ali G: Bling Bling",
                Genre_Id = gen13.Id,
                Director = "James Bobin",
                Poster = "http://image.tmdb.org/t/p/original//y7gilTOKhCY6Vmihz2OQiPFHFgW.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/11/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Clips from the Da Ali G Show, plus unaired segments and an interview with David and Victoria Beckham from a Comic Relief special.",
                Duration = 142,
                Views_Count = 0
            };
            m132.Add();
            Movie m133 = new Movie()
            {
                Imdb_Id = "tt0277027",
                Title = "I Am Sam",
                Genre_Id = gen5.Id,
                Director = "Jessie Nelson",
                Poster = "http://image.tmdb.org/t/p/original//klGmW0KLTVfkben5dmmbot1QvDC.jpg",
                Youtube_Trailer = "z_AguDqCBvo",
                Release_Date = DateTime.ParseExact("25/01/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "Sam Dawson has the mental capacity of a 7-year-old. He works at a Starbucks and is obsessed with the Beatles. He has a daughter with a homeless woman; she abandons them as soon as they leave the hospital. He names his daughter Lucy Diamond (after the Beatles song), and raises her. But as she reaches age 7 herself, Sam\'s limitations start to become a problem at school; she\'s intentionally holding back to avoid looking smarter than him. The authorities take her away, and Sam shames high-priced lawyer Rita Harrison into taking his case pro bono. In the process, he teaches her a great deal about love, and whether it\'s really all you need.",
                Duration = 132,
                Views_Count = 0
            };
            m133.Add();
            Movie m134 = new Movie()
            {
                Imdb_Id = "tt0272152",
                Title = "K-PAX",
                Genre_Id = gen18.Id,
                Director = "Iain Softley",
                Poster = "http://image.tmdb.org/t/p/original//yrPhUxZcTo68CFjsVCdHXYm8emP.jpg",
                Youtube_Trailer = "YV5s07zI-Bg",
                Release_Date = DateTime.ParseExact("26/10/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "PROT is a patient at a mental hospital who claims to be from a far away planet. His psychiatrist tries to help him, only to begin to doubt his own explanations.",
                Duration = 120,
                Views_Count = 0
            };
            m134.Add();
            Movie m135 = new Movie()
            {
                Imdb_Id = "tt0281365",
                Title = "We Sold Our Souls for Rock 'n Roll",
                Genre_Id = gen14.Id,
                Director = "Penelope Spheeris",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("19/01/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Documentary following the Ozzfest Tour in 1999, with live music and interviews interspersed. Featuring the band members from Black Sabath, Primus, Slayer, Rob Zombie, Buckethead, System of a Down and others.",
                Duration = 90,
                Views_Count = 0
            };
            m135.Add();
            Movie m136 = new Movie()
            {
                Imdb_Id = "tt0184791",
                Title = "O",
                Genre_Id = gen17.Id,
                Director = "Tim Blake Nelson",
                Poster = "http://image.tmdb.org/t/p/original//fc2mifxyCXyr66FMSmsfUXVREEg.jpg",
                Youtube_Trailer = "Bz1NIOjkJi0",
                Release_Date = DateTime.ParseExact("31/08/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Tough Coach Duke Goulding leaves nothing untried to lead his almost exclusively white boarding school basketball team, the Hawks, to victory after victory, but his own son Hugo feels his polyvalent technical excellence and tireless efforts -which require using stimulants- are not getting anything like the recognition he deserves, especially when coach gives the best player award to Odin James, the only black teammate, even saying he loves Odin like his own son, who in turn only calls super-rich Michael Cassio to share in the honor. So Hugo, who is liked by everyone, decides to set up the boys who stole his glory, and he knows a cocky adolescent\'s weak points are his pride and his girl. This Dixie Jago schemes to bring down a black Othello and his Cassio, playing into the poisonous power of jealousy, however badly this also hurts their loved ones and the whole team...",
                Duration = 95,
                Views_Count = 0
            };
            m136.Add();
            Movie m137 = new Movie()
            {
                Imdb_Id = "tt0278490",
                Title = "A Huey P. Newton Story",
                Genre_Id = gen4.Id,
                Director = "Spike Lee",
                Poster = "http://image.tmdb.org/t/p/original//sfQ7KhlUoXNKx6LgliPtiikluFk.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("18/06/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "The story of how the radical Huey P. Newton developed the Black Panther Party based on his 10-point program for social reform.",
                Duration = 86,
                Views_Count = 0
            };
            m137.Add();
            Movie m138 = new Movie()
            {
                Imdb_Id = "tt0275309",
                Title = "Dogtown and Z-Boys",
                Genre_Id = gen19.Id,
                Director = "Stacy Peralta",
                Poster = "http://image.tmdb.org/t/p/original//t9bySuObZWDH0JPMMt5kbdnhMh6.jpg",
                Youtube_Trailer = "C78BQFDq6hM",
                Release_Date = DateTime.ParseExact("10/05/2002", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2002,
                Description = "Sub-titled \"The Birth of Extreme\", this documetary takes a look at the transformation of skateboarding from its former image as a land-bound pastime for surfers to its status today as an extreme and acrobatic sport in its own right. Starting from the California surf community of Dogtown, the film follows the evolution of modern skateboarding through it\'s 70\'s heyday, its decline during the 80\'s, and its eventual (and highly lucrative) return in the 90\'s.",
                Duration = 91,
                Views_Count = 0
            };
            m138.Add();
            Movie m139 = new Movie()
            {
                Imdb_Id = "tt0274659",
                Title = "Mermaid Chronicles Part 1: She Creature",
                Genre_Id = gen13.Id,
                Director = "Sebastian Gutierrez",
                Poster = "http://image.tmdb.org/t/p/original//xVdXOqYIOstA7RWRmwdCpRXYAlW.jpg",
                Youtube_Trailer = "WUgNerSNKcs",
                Release_Date = DateTime.ParseExact("04/10/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Two carnies (Sewell and Gugino) abduct a mermaid in Ireland, circa 1900, and decide to transport her to America. As their ship loses its way and heads towards the mythical Forbidden Islands, the mermaid begins to display its deadly side.",
                Duration = 91,
                Views_Count = 0
            };
            m139.Add();
            Movie m140 = new Movie()
            {
                Imdb_Id = "tt0252866",
                Title = "American Pie 2",
                Genre_Id = gen16.Id,
                Director = "J.B. Rogers",
                Poster = "http://image.tmdb.org/t/p/original//1C1d3Tpesm8Vn3BRqsQZt0LfZcG.jpg",
                Youtube_Trailer = "ntxIBzJ0tU8",
                Release_Date = DateTime.ParseExact("10/08/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "The whole gang are back and as close as ever. They decide to get even closer by spending the summer together at a beach house. They decide to hold the biggest party ever to be seen, even if the preparation doesn\'t always go to plan. Especially when Stifler, Finch and Jim become more close to each other than they ever want to be and when Jim mistakes super glue for lubricant.",
                Duration = 108,
                Views_Count = 0
            };
            m140.Add();
            Movie m141 = new Movie()
            {
                Imdb_Id = "tt0259685",
                Title = "Tremors 3: Back to Perfection",
                Genre_Id = gen5.Id,
                Director = "Brent Maddock",
                Poster = "http://image.tmdb.org/t/p/original//dPGIIakcRuuPVRrnFFwzwKdeREu.jpg",
                Youtube_Trailer = "jw0qzPAQW3w",
                Release_Date = DateTime.ParseExact("02/10/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Third Tremors movie takes us back to the small Nevada town of Perfection where local resident and adventurer Burt Grummer returns after traveling abroad and killing carnivorous worms called \"Graboids\" (introduced in the first movie) and their offspring \"Shriekers\" (introduced in the second movie) to life in his home town and must deal with some crooked land developers, a thrill-seeking guy named Jack Sawyer looking for wealth in this potential tourist town, and eventually dealing with a new strain of Graboid worms that metamorph into their second Shrieker phase, and whom unexpectedly morph into their third stage for another harrowing battle against Burt and Jack in the desert surrounding the town.",
                Duration = 104,
                Views_Count = 0
            };
            m141.Add();
            Movie m142 = new Movie()
            {
                Imdb_Id = "tt0368342",
                Title = "Three 6 Mafia: Choices - The Movie",
                Genre_Id = gen8.Id,
                Director = "Gil Green",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("06/11/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Shot largely in Three 6 Mafia\'s hometown of Memphis, TN, Choices examines the conflict between right and wrong and is based on the life of an ex-convict and the choices that he makes trying to get his life on the right track.",
                Duration = 90,
                Views_Count = 0
            };
            m142.Add();
            Movie m143 = new Movie()
            {
                Imdb_Id = "tt0251031",
                Title = "Series 7: The Contenders",
                Genre_Id = gen20.Id,
                Director = "Daniel Minahan",
                Poster = "http://image.tmdb.org/t/p/original//7tgaUc5OzT75h5Vb8mOBnJGwiR4.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("25/05/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Ever seen the show \"Survivor\" and wished they would just start killing each other?? Series 7 literally gives its contestants the guns. The film is not merely a satire on reality TV. It is an example of just how far people will shamelessly go for fame. 6 contenders are pitted against each other in a no holds barred, kill or be killed contest. The reigning champ is Dawn, a hard-nosed, mother-to-be. We go back and forth between Dawn and the other 5 contenders to see if someone can dethrone Dawn and become the new Champion. What is the prize? How are the contestants picked? These questions are not as important as asking yourself how shameless has our society become?",
                Duration = 86,
                Views_Count = 0
            };
            m143.Add();
            Movie m144 = new Movie()
            {
                Imdb_Id = "tt0261983",
                Title = "Session 9",
                Genre_Id = gen16.Id,
                Director = "Brad Anderson",
                Poster = "http://image.tmdb.org/t/p/original//d5tK8tUD4qhtfupIEaIGnnMSLiB.jpg",
                Youtube_Trailer = "LsxkRNvEbhM",
                Release_Date = DateTime.ParseExact("14/09/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "An asbestos abatement crew wins the bid for an abandoned insane asylum. What should be a straightforward, if rather rushed, job, is complicated by the personal histories of the crew. In particular, Hank is dating Phil\'s old girlfriend, and Gordon\'s new baby seems to be unnerving him more than should be expected. Things get more complicated as would-be lawyer Mike plays the tapes from a former patient with multiple personalities, including the mysterious Simon who does not appear until Session 9, and as Hank disappears after finding some old coins.",
                Duration = 97,
                Views_Count = 0
            };
            m144.Add();
            Movie m145 = new Movie()
            {
                Imdb_Id = "tt0180093",
                Title = "Requiem for a Dream",
                Genre_Id = gen18.Id,
                Director = "Darren Aronofsky",
                Poster = "http://image.tmdb.org/t/p/original//c5g1Dn1tF22CS2oOvHDNKr1Ve2U.jpg",
                Youtube_Trailer = "lgo3Hb5vWLE",
                Release_Date = DateTime.ParseExact("15/12/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "Sara Goldfarb (Ellen Burstyn) is a retired widow, living in a small apartment. She spends most of her time watching TV, especially a particular self-help show. She has delusions of rising above her current dull existence by being a guest on that show. Her son, Harry (Jared Leto) is a junkie but along with his friend Tyrone (Marlon Wayans) has visions of making it big by becoming a drug dealer. Harry\'s girlfriend Marion (Jennifer Connelly) could be fashion designer or artist but is swept along in Harry\'s drug-centric world. Meanwhile Sara has developed an addiction of her own. She desperately wants to lose weight and so goes on a crash course involving popping pills, pills which turn out to be very addictive and harmful to her mental state.",
                Duration = 102,
                Views_Count = 0
            };
            m145.Add();
            Movie m146 = new Movie()
            {
                Imdb_Id = "tt0173716",
                Title = "Cecil B. DeMented",
                Genre_Id = gen6.Id,
                Director = "John Waters",
                Poster = "http://image.tmdb.org/t/p/original//ifvxndcgjoSBw4pg54R8mI3fvDb.jpg",
                Youtube_Trailer = "LMmKfKCZoTk",
                Release_Date = DateTime.ParseExact("01/09/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "In Baltimore, guerrilla filmmaker Cecil B. Demented leads a band of cinema revolutionaries who kidnap Honey Whitlock, a bitchy and aging movie star of big-budget froth. Cecil wants her in his movie, a screed against Hollywood they film during blitzkrieg attacks on a multiplex, a Maryland Film Commission press conference, and the set of a \"Forrest Gump\" sequel. He insists on celibacy; the cast and crew channel sexual energy into the production. With a family-values coalition, aggrieved Teamsters, and the police on their trail, Cecil needs help from porno, kung-fu, and drive-in audiences. What about Honey? Will she bolt or refuse to act? Or will she hit her marks and light up the screen?",
                Duration = 87,
                Views_Count = 0
            };
            m146.Add();
            Movie m147 = new Movie()
            {
                Imdb_Id = "tt0462272",
                Title = "Eminem: E",
                Genre_Id = gen4.Id,
                Director = "Philip G. Atwell, Dr. Dre, Paul Hunter, Darren Lavett",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("19/12/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "A collection of Eminem\'s music videos.",
                Duration = 77,
                Views_Count = 0
            };
            m147.Add();
            Movie m148 = new Movie()
            {
                Imdb_Id = "tt0212235",
                Title = "Shriek If You Know What I Did Last Friday the Thirteenth",
                Genre_Id = gen1.Id,
                Director = "John Blanchard",
                Poster = "http://image.tmdb.org/t/p/original//9VUlMPdmue4lQTcxuApcxnEmHTn.jpg",
                Youtube_Trailer = "-v5fu76_Jng",
                Release_Date = DateTime.ParseExact("21/02/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Another spoof of the Scream/I Know What You Did Last Summer horror gene involving a group of popular high school students stalked by a bumbling masked killer while a dogged reporter named Hagitha Utslay covers the story and of the plight of the prime suspect and transfer student Dawson.",
                Duration = 86,
                Views_Count = 0
            };
            m148.Add();
            Movie m149 = new Movie()
            {
                Imdb_Id = "tt0286958",
                Title = "The Shield Around the K",
                Genre_Id = gen14.Id,
                Director = "Heather Rose Dominic",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("23/07/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "The Shield Around the K, profiles the birth and growth of the punk rock DIY record label, K Records, based in Olympia, Washington. Co-Founders, Calvin Johnson and Candice Pedersen are interviewed along with over 20 K artists and peers including Mecca Normal, Lois, Rose Melberg, Ian MacKaye, Slim Moon, Dean Wareham and more. The Shield Around the K features performances by Calvin Johnson\'s legendary Beat Happening. International Pop Underground Festival footage features Fugazi, Beat Happening, Mecca Normal and others. The Shield Around the K portrays an independent record label whose lo-fi credibility has never been compromised.",
                Duration = 85,
                Views_Count = 0
            };
            m149.Add();
            Movie m150 = new Movie()
            {
                Imdb_Id = "tt0253056",
                Title = "Down 'n Dirty",
                Genre_Id = gen8.Id,
                Director = "Fred Williamson",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("27/10/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "Dakota Smith is an experienced policeman with a problem: his partner was shot dead, and corrupt cops are responsible. Dak\'s investigation leads him to widespread corruption in the department, as well as a corrupt district attorney. Smith finds an unlikely ally in timid photographer Nick Gleem. While Gleem unearths clues about the bad guys, Dak fends off attacks on his own life. While he\'s not in gun battles with these local villains, divorced father Dak has no shortage of lady friends to keep him happy.",
                Duration = 102,
                Views_Count = 0
            };
            m150.Add();
            Movie m151 = new Movie()
            {
                Imdb_Id = "tt0190590",
                Title = "O Brother, Where Art Thou?",
                Genre_Id = gen5.Id,
                Director = "Joel Coen, Ethan Coen",
                Poster = "http://image.tmdb.org/t/p/original//s4SmtlX13p1E2laSQqmVZQ8sYbe.jpg",
                Youtube_Trailer = "G7nNDKrTrag",
                Release_Date = DateTime.ParseExact("02/02/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Loosely based on Homer\'s \"Odyssey,\" the movie deals with the picaresque adventures of Ulysses Everett McGill and his companions Delmar and Pete in 1930s Mississipi. Sprung from a chain gang and trying to reach Everett\'s home to recover the buried loot of a bank heist they are confronted by a series of strange characters--among them sirens, a cyclops, bank robber George \"Baby Face\" Nelson (very annoyed by that nickname), a campaigning governor and his opponent, a KKK lynch mob, and a blind prophet who warns the trio that \"the treasure you seek shall not be the treasure you find.\"",
                Duration = 107,
                Views_Count = 0
            };
            m151.Add();
            Movie m152 = new Movie()
            {
                Imdb_Id = "tt0120903",
                Title = "X-Men",
                Genre_Id = gen2.Id,
                Director = "Bryan Singer",
                Poster = "http://image.tmdb.org/t/p/original//xm75A18CE7Wc6J9k2ZidFyqJ6rX.jpg",
                Youtube_Trailer = "nbNcULQFojc",
                Release_Date = DateTime.ParseExact("14/07/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "In a world where both Mutants and Humans fear each other, Marie, better known as Rogue, runs away from home and hitches a ride with another mutant, known as Logan, a.k.a. Wolverine. Charles Xavier, who owns a school for young mutants, sends Storm and Cyclops to bring them back before it is too late. Magneto, who believes a war is approaching, has an evil plan in mind, and needs young Rogue to help him.",
                Duration = 104,
                Views_Count = 0
            };
            m152.Add();
            Movie m153 = new Movie()
            {
                Imdb_Id = "tt0210065",
                Title = "Gangster No. 1",
                Genre_Id = gen8.Id,
                Director = "Paul McGuigan",
                Poster = "http://image.tmdb.org/t/p/original//bXJDSfNyC8J4yxaVCLMUMueVPMo.jpg",
                Youtube_Trailer = "GHH7Mm6xviE",
                Release_Date = DateTime.ParseExact("09/06/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "A middle-aged crime boss smugly reflects back from 1999, narrating the brutality which made him triumphant - and feared. As an unnamed young hood in Swinging 60\'s London, he aped his mod boss Freddie Mays, and seemed to do anything for him. But his narration exposes all-consuming envy: of Freddie\'s supremacy, and especially his tall bird. The baby shark develops his viciousness and backstabbing, scheming to be Gangster No. 1.",
                Duration = 103,
                Views_Count = 0
            };
            m153.Add();
            Movie m154 = new Movie()
            {
                Imdb_Id = "tt0134084",
                Title = "Scream 3",
                Genre_Id = gen16.Id,
                Director = "Wes Craven",
                Poster = "http://image.tmdb.org/t/p/original//frxiigkZplwaXnJYVA2rEYHqWeN.jpg",
                Youtube_Trailer = "bYi-rmHfrP8",
                Release_Date = DateTime.ParseExact("04/02/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "A new film is currently in production, and a killer is on the loose. The murders draw a reporter, ex-cop, and young woman to the set of the movie inspired by their life. They soon find out that they are dealing with a trilogy, and in a trilogy...anything can happen.",
                Duration = 116,
                Views_Count = 0
            };
            m154.Add();
            Movie m155 = new Movie()
            {
                Imdb_Id = "tt0216930",
                Title = "My 5 Wives",
                Genre_Id = gen20.Id,
                Director = "Sidney J. Furie",
                Poster = "http://image.tmdb.org/t/p/original//pWQs16DogBekycvE2stoOsXyWzm.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("08/09/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "Monte Peterson, a rich real-estate developer, is going through his third divorce. His friend Ray has found a good site for a ski resort in Utah, and Monte comes to bid on the land, competing with local banker Preston Gates. Monte knew that, in order to take possession of the land, he would have to convert to the local religion, a sort of cross between Mormonism and Amish (no smoking, no drinking, bigamy and simple living/dressing encouraged). What he didn\'t know was that the deed to the land also included the three wives of the deceased former owner. He also buys another plot, and the two wives that come with it, in part because they are much better cooks. Gates, meanwhile, wants the land to build an Indian casino, and is mixed up with some mobsters. There\'s a trip to Las Vegas, a female-empowerment seminar, a jailbreak, and other complications too absurd to mention.",
                Duration = 100,
                Views_Count = 0
            };
            m155.Add();
            Movie m156 = new Movie()
            {
                Imdb_Id = "tt0156020",
                Title = "Ricky 6",
                Genre_Id = gen6.Id,
                Director = "Peter Filardi",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("07/10/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "Based on the true story of drugs, satanism, and murder in the upper class town of Northport, Long Island in 1984.",
                Duration = 111,
                Views_Count = 0
            };
            m156.Add();
            Movie m157 = new Movie()
            {
                Imdb_Id = "tt0139462",
                Title = "Message in a Bottle",
                Genre_Id = gen17.Id,
                Director = "Luis Mandoki",
                Poster = "http://image.tmdb.org/t/p/original//nIZMk567n7DztnRFkL2y1RXFqo4.jpg",
                Youtube_Trailer = "Wpb616fwYMk",
                Release_Date = DateTime.ParseExact("12/02/1999", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1999,
                Description = "A woman finds a romantic letter in a bottle washed ashore and tracks down the author, a widowed shipbuilder whose wife died tragically early. As a deep and mutual attraction blossoms, the man struggles to make peace with his past so that he can move on and find happiness.",
                Duration = 126,
                Views_Count = 0
            };
            m157.Add();
            Movie m158 = new Movie()
            {
                Imdb_Id = "tt0150488",
                Title = "B.U.S.T.E.D",
                Genre_Id = gen8.Id,
                Director = "Andrew Goth",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("20/03/1999", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1999,
                Description = "In the Pepperhill Estate of Manchester, an ongoing battle rages between Triad gangs and street gangs. Gang leaders Ray (Andrew Goth) and Terry (Goldie), who are cousins and lifelong friends, always trusting and relying on each other, have been in prison. Ray doesn\'t want to be a gangster anymore, having also fallen for Clare (Rachel Shelley). but Terry, driven by an obsession beyond friendship, is determined to make sure that Ray never leaves the gang. During their time in prison, the local Chinese Triad gang have grown stronger and more daring, eventually killing a member of Terry and Ray\'s gang. Revenge is called for and the gang turns to them for direction. Bernie (David Bowie) is the aging gangster who struggles to keep the peace.",
                Duration = 97,
                Views_Count = 0
            };
            m158.Add();
            Movie m159 = new Movie()
            {
                Imdb_Id = "tt0207195",
                Title = "Wadd: The Life & Times of John C. Holmes",
                Genre_Id = gen4.Id,
                Director = "Wesley Emerson",
                Poster = "http://image.tmdb.org/t/p/original//6mCTaWP8xuMKvDUHPoMq6iW43Cz.jpg",
                Youtube_Trailer = "BDdr45wrW7Y",
                Release_Date = DateTime.ParseExact("12/01/2001", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2001,
                Description = "Friends, enemies, acquaintances, and family of porn star John Holmes recall their experiences with him, from his childhood to his eventual death from AIDS in 1988.",
                Duration = 105,
                Views_Count = 0
            };
            m159.Add();
            Movie m160 = new Movie()
            {
                Imdb_Id = "tt0195761",
                Title = "H-E Double Hockey Sticks",
                Genre_Id = gen9.Id,
                Director = "Randall Miller",
                Poster = "http://image.tmdb.org/t/p/original//2OD2CiFEQ9rMBGi1L838D6WPCGv.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("03/10/1999", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1999,
                Description = "Satan herself as Ms. Beezlebub sends an apprentice demon to steal the soul of a talented young hockey player.",
                Duration = 96,
                Views_Count = 0
            };
            m160.Add();
            Movie m161 = new Movie()
            {
                Imdb_Id = "tt0120915",
                Title = "Star Wars: Episode I - The Phantom Menace",
                Genre_Id = gen2.Id,
                Director = "George Lucas",
                Poster = "http://image.tmdb.org/t/p/original//v6lRzOActebITc9rizhNAdwQR1O.jpg",
                Youtube_Trailer = "bD7bpG-zDJQ",
                Release_Date = DateTime.ParseExact("19/05/1999", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1999,
                Description = "The evil Trade Federation, led by Nute Gunray is planning to take over the peaceful world of Naboo. Jedi Knights Qui-Gon Jinn and Obi-Wan Kenobi are sent to confront the leaders. But not everything goes to plan. The two Jedi escape, and along with their new Gungan friend, Jar Jar Binks head to Naboo to warn Queen Amidala, but droids have already started to capture Naboo and the Queen is not safe there. Eventually, they land on Tatooine, where they become friends with a young boy known as Anakin Skywalker. Qui-Gon is curious about the boy, and sees a bright future for him. The group must now find a way of getting to Coruscant and to finally solve this trade dispute, but there is someone else hiding in the shadows. Are the Sith really extinct? Is the Queen really who she says she is? And what\'s so special about this young boy?",
                Duration = 136,
                Views_Count = 0
            };
            m161.Add();
            Movie m162 = new Movie()
            {
                Imdb_Id = "tt0177876",
                Title = "K-911",
                Genre_Id = gen5.Id,
                Director = "Charles T. Kanganis",
                Poster = "http://image.tmdb.org/t/p/original//vOgNxS7AG1qGaJvNRBnPTGm2uYh.jpg",
                Youtube_Trailer = "sO2fdu2vACs",
                Release_Date = DateTime.ParseExact("12/12/1999", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1999,
                Description = "Mike Dooley has been teamed up with Jerry Lee, a German Shepherd dog, for nearly ten years, but Jerry Lee isn\'t as young as he once was, and Dooley\'s superiors suggest that maybe it\'s time that Jerry Lee was retired from the force. But there is a stalker who wants Dooley dead. The stalker, disgruntled crime novelist Devon Lane, became obsessed with Dooley\'s wife after she rejected his book, and he blames Dooley for her death. When Jerry Lee can\'t keep up with chasing Devon during a shootout, Captain Byers teams Dooley and Jerry Lee with a younger K9 team -- aggressive female detective Welles and her dog Zeus, a young, strong Doberman Pincher. After Dooley futilely investigates a convict he once busted, the dogs get him back on track by sniffing out Devon\'s storage locker. The room reveals Devon\'s identity to Dooley, and one of Devon\'s manuscripts reveals that he intends to make Dooley suffer for his words. When Devon makes a bold move by invading the precinct and taking Welles hostage, it\'s Dooley and Jerry Lee to the rescue. But can Jerry Lee pull off this rescue?",
                Duration = 91,
                Views_Count = 0
            };
            m162.Add();
            Movie m163 = new Movie()
            {
                Imdb_Id = "tt0120695",
                Title = "From Dusk Till Dawn 3: The Hangman's Daughter",
                Genre_Id = gen20.Id,
                Director = "P.J. Pesce",
                Poster = "http://image.tmdb.org/t/p/original//kqoveKOYJ8ZNvUuf88FWjtm01cC.jpg",
                Youtube_Trailer = "GQPEUOVUJIQ",
                Release_Date = DateTime.ParseExact("18/01/2000", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2000,
                Description = "\"Prequel\" to the first From Dusk Till Dawn is set in Mexico in the early 1900\'s which begins with the escape of Johnny Madrid, a dangerous local outlaw, from the gallows who then kidnaps his hangman\'s beautiful daughter, Esmeralda, with a little help from Reece, a female outlaw from the U.S. With the hangman and a local posse on their trail, Johnny meets with his gang who all rob a stagecoach which contains American author Ambrose Bierce along with newlywed couple John and Mary Newlie. As night falls, all parties coincidentally seek shelter in an isolated inn/whorehouse which is run by vampires led by the high priestess Quixtla who targets Esmeralda. Esmeralda is revealed to be the half-human, half-vampire princess Santanico Pandemonium, whom the vampires want as their heir in which all the humans must join forces if they are to survive the night from the vicious blood-suckers.",
                Duration = 94,
                Views_Count = 0
            };
            m163.Add();
            Movie m164 = new Movie()
            {
                Imdb_Id = "tt0146455",
                Title = "Babylon 5: A Call to Arms",
                Genre_Id = gen2.Id,
                Director = "Michael Vejar",
                Poster = "http://image.tmdb.org/t/p/original//89N5vMYB5P7xtt3bSfdeoNR4K4W.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("03/01/1999", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1999,
                Description = "Five years after the events of the Babylon 5 series, a technomage named Galen predicts an imminent attack by the Drakh, the old allies of the Shadows. Through dreams, a thief, a captain, and a president are brought together to head them off. The president is John Sheridan. Because of his irrational behavior, Sheridan\'s friends begin to wonder about his sanity. It\'s up to all of them and two prototype battlecruisers, the Excalibur and the Victory, to stop the fleet and their planet-killer. But is there more to the Drakh\'s plan?",
                Duration = 94,
                Views_Count = 0
            };
            m164.Add();
            Movie m165 = new Movie()
            {
                Imdb_Id = "tt0120623",
                Title = "A Bug's Life",
                Genre_Id = gen2.Id,
                Director = "John Lasseter, Andrew Stanton(co-director)",
                Poster = "http://image.tmdb.org/t/p/original//bHMHpXNjeKRxcjWcpbIAD5f0aIK.jpg",
                Youtube_Trailer = "Ljk2YJ53_WI",
                Release_Date = DateTime.ParseExact("25/11/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "At an annual pace, a huge colony of ants is forced to collect every piece of food that grows on their island for a group of menacing grasshoppers. But that all changes when a misfit inventor ant named Flik accidentally knocks over the offering pile thus forcing the grasshoppers\' devious leader Hopper to force the ants to redo their gathering of food. Despite the fact that his friends don\'t believe him and desperate to help save the colony, Flik volunteers to go out into the world and search for a group of \'warrior\' bugs. Instead, what he got was a talented group of circus performers. But when the grasshoppers return and take control of the island, Flik must prove himself a true hero before it\'s too late.",
                Duration = 95,
                Views_Count = 0
            };
            m165.Add();
            Movie m166 = new Movie()
            {
                Imdb_Id = "tt0130018",
                Title = "I Still Know What You Did Last Summer",
                Genre_Id = gen16.Id,
                Director = "Danny Cannon",
                Poster = "http://image.tmdb.org/t/p/original//iaFSFtxX02lXsT2zQHiykNSj7YP.jpg",
                Youtube_Trailer = "99yCJwP97Uo",
                Release_Date = DateTime.ParseExact("13/11/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "Julie\'s back in college with her new friend, and they win a weekend trip to an island. On the way there, someone dies, and then the girls are tormented on the island.",
                Duration = 100,
                Views_Count = 0
            };
            m166.Add();
            Movie m167 = new Movie()
            {
                Imdb_Id = "tt0120422",
                Title = "Up 'n' Under",
                Genre_Id = gen19.Id,
                Director = "John Godber",
                Poster = "http://image.tmdb.org/t/p/original//sR8AeGbjIAeT0gPxptukCSFO7jj.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("23/01/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "The Cobblers Arms have been the best and most feared Amateur Rugby League team for the past ten years. Ex-pro Arthur bets their boss that he could train a bunch of deadbeats to defeat them ...",
                Duration = 99,
                Views_Count = 0
            };
            m167.Add();
            Movie m168 = new Movie()
            {
                Imdb_Id = "tt0178747",
                Title = "Max Q",
                Genre_Id = gen18.Id,
                Director = "Michael Shapiro",
                Poster = "http://image.tmdb.org/t/p/original//exkOzIrl1he1f864JSkLZ1U2iKi.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("19/11/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "A shuttle is launched into space to release a new satellite. When an explosion occurs the crew has to think of a way to get back to Earth without atmospheric pressure (max q) crushing the damaged shuttle.",
                Duration = 91,
                Views_Count = 0
            };
            m168.Add();
            Movie m169 = new Movie()
            {
                Imdb_Id = "tt0163862",
                Title = "T-Rex: Back to the Cretaceous",
                Genre_Id = gen9.Id,
                Director = "Brett Leonard",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("23/10/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "Ally Hayden is a teenager who shares her father\'s interest in dinosaurs and archaeology. When he brings a mysterious fossil back from a dig, she is convinced it\'s the egg of a Tyrannosaurus Rex. After accidentally knocking the egg to the floor, Ally begins to experience visions, as if she was being transported back in time to the Cretaceous period. There, she encounters several different dinosaurs, including her favorite, the mighty T-Rex.",
                Duration = 45,
                Views_Count = 0
            };
            m169.Add();
            Movie m170 = new Movie()
            {
                Imdb_Id = "tt0150111",
                Title = "Children of the Corn V: Fields of Terror",
                Genre_Id = gen13.Id,
                Director = "Ethan Wiley",
                Poster = "http://image.tmdb.org/t/p/original//frk5Gtc0f8M2TRkhDUkUI9L9jRu.jpg",
                Youtube_Trailer = "ZGnaj-lDCtA",
                Release_Date = DateTime.ParseExact("21/06/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "Six college students take a wrong turn and find themselves lost in a strangely deserted rural town... only to discover that this deceptively quiet place hides a murderous cult of children controlled by evil forces! Yet even as bodies begin cropping up all around them, the young friends decide to stay and rescue the children... or die trying!",
                Duration = 83,
                Views_Count = 0
            };
            m170.Add();
            Movie m171 = new Movie()
            {
                Imdb_Id = "tt0120586",
                Title = "American History X",
                Genre_Id = gen8.Id,
                Director = "Tony Kaye",
                Poster = "http://image.tmdb.org/t/p/original//i9A0UMFg1hI2kLyCCwnmSbpT2cd.jpg",
                Youtube_Trailer = "JsPW6Fj3BUI",
                Release_Date = DateTime.ParseExact("20/11/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "Derek Vineyard is paroled after serving 3 years in prison for brutally killing two black men who tried to break into/steal his truck. Through his brother, Danny Vineyard\'s narration, we learn that before going to prison, Derek was a skinhead and the leader of a violent white supremacist gang that committed acts of racial crime throughout L.A. and his actions greatly influenced Danny. Reformed and fresh out of prison, Derek severs contact with the gang and becomes determined to keep Danny from going down the same violent path as he did.",
                Duration = 119,
                Views_Count = 0
            };
            m171.Add();
            Movie m172 = new Movie()
            {
                Imdb_Id = "tt0120131",
                Title = "The Lion King 2: Simba's Pride",
                Genre_Id = gen2.Id,
                Director = "Darrell Rooney, Rob LaDuca(co-director)",
                Poster = "http://image.tmdb.org/t/p/original//mOXpgCVPy43L3Sbq9keft6VSQ7O.jpg",
                Youtube_Trailer = "cALH3eXpruM",
                Release_Date = DateTime.ParseExact("27/10/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "Simba and Nala have a daughter, Kiara. Timon and Pumbaa are assigned to be her babysitters, but she easily escapes their care and ventures into the forbidden lands. There she meets a lion cub named Kovu and they become friends. What she and her parents do not know is that Kovu is the son of Zira - a banished follower of the now-dead Scar. She plans to raise Kovu to overthrow Simba and become the king of the Pride Lands. This tests not only Kiara and Kovu\'s relationship as they mature, but Simba\'s relationship with his daughter.",
                Duration = 81,
                Views_Count = 0
            };
            m172.Add();
            Movie m173 = new Movie()
            {
                Imdb_Id = "tt0118539",
                Title = "3 Ninjas: High Noon at Mega Mountain",
                Genre_Id = gen2.Id,
                Director = "Sean McNamara",
                Poster = "http://image.tmdb.org/t/p/original//yTdUl6LZiTjl2Ry95ocsppuZGJY.jpg",
                Youtube_Trailer = "nkOfRFxgIX0",
                Release_Date = DateTime.ParseExact("18/06/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "Three young boys, Rocky, Colt and Tum Tum together with their neighbor girl, computer whiz Amanda are visiting Mega Mountain amusement park when it is invaded by an army of ninjas led by evil Medusa, who wants to take over the park and hold the owners for ransom. Kids and retired TV star Dave Dragon, who made his farewell appearance at the park at the time the ninjas appeared, have to break Medusa\'s vicious plans.",
                Duration = 93,
                Views_Count = 0
            };
            m173.Add();
            Movie m174 = new Movie()
            {
                Imdb_Id = "tt0120711",
                Title = "Babylon 5: In the Beginning",
                Genre_Id = gen2.Id,
                Director = "Michael Vejar",
                Poster = "http://image.tmdb.org/t/p/original//oHbxtTHZvdyR41ylRBCOJjgLIED.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("04/01/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "The Earth military encounters an alien race called the Minbari. Through a series of accidents and misunderstandings, a war breaks out that nearly results in the death of every human on Earth. The war and its aftermath provide the background for the TV series \"Babylon 5,\" especially its first season.",
                Duration = 94,
                Views_Count = 0
            };
            m174.Add();
            Movie m175 = new Movie()
            {
                Imdb_Id = "tt0354859",
                Title = "Radiohead: 7 Television Commercials",
                Genre_Id = gen14.Id,
                Director = "Magnus Carlsson, Paul Cunningham, Grant Gee, Jonathan Glazer, Jake Scott, Jamie Thraves",
                Poster = "http://image.tmdb.org/t/p/original//z8gU22hGmryjAyFF3VjJYnvXa55.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("30/06/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "Features 7 music videos from the British band, Radiohead. Covering their singles from the albums The Bends and OK Computer, this features songs like Street Spirit (Fade Out), Paranoid Android, and High and Dry.",
                Duration = 34,
                Views_Count = 0
            };
            m175.Add();
            Movie m176 = new Movie()
            {
                Imdb_Id = "tt0140519",
                Title = "Route 9",
                Genre_Id = gen8.Id,
                Director = "David Mackay",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "lxRKnyLnPFk",
                Release_Date = DateTime.ParseExact("20/11/1998", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1998,
                Description = "When two small-town deputy sheriffs stumble onto a crime scene where a drug buy had gone bad and everyone was shot dead, they discover a suitcase full of cash - $1.5 million. They decide to take the cash and cover-up the theft by burning the car the cash was in. However, things take a turn for the worse when they discover that one of the men is still alive and he has overheard their plans. They then have to suffocate him to stop him from revealing their plans. Things get even worse though when the DEA shows up and tell them that the man was one of their agents and he was wired. And then things take another bad turn when the coroner, who first received the body, discovers the tape first, switches it and wants a 50% cut.",
                Duration = 105,
                Views_Count = 0
            };
            m176.Add();
            Movie m177 = new Movie()
            {
                Imdb_Id = "tt0119535",
                Title = "A Life Less Ordinary",
                Genre_Id = gen6.Id,
                Director = "Danny Boyle",
                Poster = "http://image.tmdb.org/t/p/original//lmUzoIeQH5T8gP3gFVta3CuOmC.jpg",
                Youtube_Trailer = "k6K5q72jy9c",
                Release_Date = DateTime.ParseExact("24/10/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "Ewan McGregor stars as a cleaning man in L.A. who takes his boss\' daughter hostage after being fired and replaced by a robot. Two \"angels\" who are in charge of human relationships on earth, offer some unsolicited help to bring this unlikely couple together.",
                Duration = 103,
                Views_Count = 0
            };
            m177.Add();
            Movie m178 = new Movie()
            {
                Imdb_Id = "tt0118545",
                Title = "A, B, C... Manhattan",
                Genre_Id = gen15.Id,
                Director = "Amir Naderi",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("14/05/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "Three women are to make vital decisions about their future. Colleen wants to be a photographer but can\'t support her daughter Stella. Casey is looking for her dog stolen by her ex-boyfriend and lesbian lover who has dumped her. Kate decided to break up with Stevie and start living on her own.",
                Duration = 90,
                Views_Count = 0
            };
            m178.Add();
            Movie m179 = new Movie()
            {
                Imdb_Id = "tt3468686",
                Title = "G-Lock: Absorbed by the Grid",
                Genre_Id = gen10.Id,
                Director = "J.R. Myung",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("31/10/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "G-Lock - Absorbed by the Grid filmed Live August 16, 1997. Chris McLaren (bass), Frank Thomas (guitar / vocals, Mykill (drums), Liz Spires (vocals), and Steve Neal (vocals) in the bonus video. This DVD was sourced off a VHS tape from 1997, so audio and video quality may not 100% in all areas. Photosensitive Seizure Warning due to flashing images or lights.",
                Duration = 56,
                Views_Count = 0
            };
            m179.Add();
            Movie m180 = new Movie()
            {
                Imdb_Id = "tt0119345",
                Title = "I Know What You Did Last Summer",
                Genre_Id = gen16.Id,
                Director = "Jim Gillespie",
                Poster = "http://image.tmdb.org/t/p/original//3s1jogOznYmG0xPqHE45D5ir3bx.jpg",
                Youtube_Trailer = "EcWK0M4VMjA",
                Release_Date = DateTime.ParseExact("17/10/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "After an accident on a winding road, four teens make the fatal mistake of dumping their victim\'s body into the sea. But exactly one year later, the dead man returns from his watery grave and he\'s looking for more than an apology.",
                Duration = 101,
                Views_Count = 0
            };
            m180.Add();
            Movie m181 = new Movie()
            {
                Imdb_Id = "tt0248751",
                Title = "Denis Leary: Lock 'N Load",
                Genre_Id = gen5.Id,
                Director = "Ted Demme",
                Poster = "http://image.tmdb.org/t/p/original//76CrXErFHVCD6YYOIk2prU3FMhx.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/11/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "Actor/comic Denis Leary discusses family life, coffee, religion, and other topics in this stand-up special.",
                Duration = 65,
                Views_Count = 0
            };
            m181.Add();
            Movie m182 = new Movie()
            {
                Imdb_Id = "tt0120399",
                Title = "U Turn",
                Genre_Id = gen8.Id,
                Director = "Oliver Stone",
                Poster = "http://image.tmdb.org/t/p/original//58e2QJsmWT4tKWXENu8OID7s1F4.jpg",
                Youtube_Trailer = "9bt-0ISUwQ0",
                Release_Date = DateTime.ParseExact("03/10/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "When Bobby\'s car breaks down in the desert while on the run from some of the bookies who have already taken two of his fingers, he becomes trapped in the nearby small town where the people are stranger than anyone he\'s encountered. After becoming involved with a (unbeknownst to him) young married woman, her husband hires Bobby to kill her. Later, she hires Bobby to kill the husband.",
                Duration = 125,
                Views_Count = 0
            };
            m182.Add();
            Movie m183 = new Movie()
            {
                Imdb_Id = "tt0123950",
                Title = "The Land Before Time V: The Mysterious Island",
                Genre_Id = gen2.Id,
                Director = "Charles Grosvenor",
                Poster = "http://image.tmdb.org/t/p/original//vvrikCMyik8sZK7p8hrn8BjhWS4.jpg",
                Youtube_Trailer = "_et5LL4Pe1M",
                Release_Date = DateTime.ParseExact("09/12/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "When a swarm of \"leaf-gobblers\" devours all the green food in the Great Valley, the herds move on to find another valley of greens and in the process, Littlefoot and his friends Spike, Cera, Petrie and Ducky wind up on an island in the middle of the Big Water. They\'re reunited with Chomper...Along with his nasty, hungry parents.",
                Duration = 74,
                Views_Count = 0
            };
            m183.Add();
            Movie m184 = new Movie()
            {
                Imdb_Id = "tt0300629",
                Title = "WWF in Your House: D-Generation-X",
                Genre_Id = gen7.Id,
                Director = "Kevin Dunn",
                Poster = "http://image.tmdb.org/t/p/original//lnNCEXCIKTWZTYrvkjniBNm5Hv1.jpg",
                Youtube_Trailer = "h-XB4HZaog8",
                Release_Date = DateTime.ParseExact("08/12/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "WWF Title: Shawn Michaels vs. Ken Shamrock, WWF Intercontinental Title: Steve Austin vs. Rocky Miavia, WWF Tag Team Titles: The New Age Outlaws vs. The Leigon of Doom, WWF Light Heavyweight Title: Taka Michinoku vs. Brian Christopher, Boot Camp Match: Hunter Hearst-Helmsley vs. Sgt. Slaughter, Jeff Jarrett vs. The Undertaker, Los Baruquas vs. The D.O.A.",
                Duration = 180,
                Views_Count = 0
            };
            m184.Add();
            Movie m185 = new Movie()
            {
                Imdb_Id = "tt0120082",
                Title = "Scream 2",
                Genre_Id = gen16.Id,
                Director = "Wes Craven",
                Poster = "http://image.tmdb.org/t/p/original//cBUvJWcV8k7GTEGoL2Dp6CmgUV1.jpg",
                Youtube_Trailer = "C-j2TLBmTBY",
                Release_Date = DateTime.ParseExact("12/12/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "Two years after the events of Scream, Sidney Prescott and Randy are attending Windsor college. They are trying to get on with their lives...Until a new Ghostface killing spree begins. With the help of Dewey and Gale, Sidney must find out who\'s behind the murders. As the body count goes up, the list of suspects goes down.",
                Duration = 120,
                Views_Count = 0
            };
            m185.Add();
            Movie m186 = new Movie()
            {
                Imdb_Id = "tt0118540",
                Title = "4 Little Girls",
                Genre_Id = gen12.Id,
                Director = "Spike Lee",
                Poster = "http://image.tmdb.org/t/p/original//5FOXESwSuyEoutVgyNrY01VMVc.jpg",
                Youtube_Trailer = "kG_2tbFf7Qk",
                Release_Date = DateTime.ParseExact("09/07/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "This film recounts the people and events leading up to the one of the most despicable hate-crimes during the height of the civil-rights movement, the bombing of the 16th Street Church in Birmingham, Alabama. In that attack, four little African-American girls lost their lives and a nation was simultaneously revolted, angered and galvanized to push the fight for equality and justice on.",
                Duration = 102,
                Views_Count = 0
            };
            m186.Add();
            Movie m187 = new Movie()
            {
                Imdb_Id = "tt0171465",
                Title = "Dusting Cliff 7",
                Genre_Id = gen6.Id,
                Director = "William H. Molina",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "mvFJZHDAhXQ",
                Release_Date = DateTime.ParseExact("22/03/1997", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1997,
                Description = "The young daughter of a tough, female ex-agent is held ransom for the giving over of a top secret information file which outlines the layout of buried nuclear arms being held as garbage under a government restricted cliff seven in the desert. But to discover this she must go to the area and there, with some unexpected help, encounters the kidnappers in a daring shoot-out finish.",
                Duration = 93,
                Views_Count = 0
            };
            m187.Add();
            Movie m188 = new Movie()
            {
                Imdb_Id = "tt0117913",
                Title = "A Time to Kill",
                Genre_Id = gen8.Id,
                Director = "Joel Schumacher",
                Poster = "http://image.tmdb.org/t/p/original//b1cfBhhorGYNPbMVT6C9cHwxRr8.jpg",
                Youtube_Trailer = "7hfTnum9fVA",
                Release_Date = DateTime.ParseExact("24/07/1996", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1996,
                Description = "In Canton, Mississippi, 10-year-old Tonya Hailey is viciously brutalized by two white racist rednecks -- James Louis \"Pete\" Willard and Billy Ray Cobb. Almost immediately after Tonya is found and rushed to a hospital, Pete and Billy Ray are found at a roadside bar, where they had been bragging about what they did to Tonya. Tonya\'s understandably distraught and enraged father, Carl Lee Hailey, remembers a case from a year ago, when four white men raped an African-American girl in a nearby town, and got acquitted. Carl is determined to not let that happen in this case. While deputy Dwayne Powell Looney is escorting Pete and Billy Ray up a flight of stairs to a court room, Carl emerges from the building\'s basement with an assault rifle, and he kills Pete and Billy Ray for what they did to Tonya. Carl is later arrested at his house by African-American sheriff Ozzie Walls, and Carl is scheduled to be placed on trial. Despite the efforts of the NAACP and local African-American leaders to persuade Carl to choose some of their high-powered attorneys, Carl wants to be represented by his friend Jake Tyler Brigance, who has a wife named Carla and a daughter named Hannah. Presiding over the trial is white judge Omar Noose, and the prosecution attorney is Rufus Buckley, who would like nothing more than to win the case and swim in the publicity that a win would generate, because Rufus realizes that a murder conviction could help him gain higher office. Helping Jake on the case are his former law professor Lucien Wilbanks, fellow attorney Harry Rex Vonner, and law student Ellen Roark. Ellen has had experience with death penalty cases, and that\'s exactly what Rufus may be seeking. To start things off, Noose denies bail and denies Jake\'s petition for a change of venue. Carl has also been fired from his job. Billy Ray Cobb\'s brother Freddie Lee Cobb wants revenge on Carl, so Freddy gets the help of the Mississippi branch of the KKK, led by Mississippi grand dragon Stump Sisson. Carl\'s wife Gwen tells Carl that a doctor has said that because of Pete and Billy Ray, Tonya\'s reproductive organs are damaged enough to where she won\'t be able to have kids when she grows up. That night, a KKK member is found trying to plant a bomb under Jake\'s porch. Jake\'s secretary Ethel Twitty and her husband Bud are also attacked by the KKK. Still, Jake, Harry, Lucien, and Ellen continue to help Carl. On the day the trial begins, there is a riot outside the court building between the KKK and the area\'s African-American residents, and Stump Sisson is killed by a molotov cocktail that was dropped from a roof by one of Carl\'s sons, who was not seen dropping it. Freddy and the KKK start burning crosses throughout Canton, and one of the crosses burns Jake\'s house down while Jake and his family are not home. As a result, the National Guard is called to Canton to keep the peace during the trial. But Freddy is not about to let that stop him. While Freddy continues his efforts to get revenge on Carl for Billy Ray\'s death, Carl\'s attorneys put everything they\'ve got into Carl\'s defense.",
                Duration = 149,
                Views_Count = 0
            };
            m188.Add();
            Movie m189 = new Movie()
            {
                Imdb_Id = "tt0117880",
                Title = "T2 3-D: Battle Across Time",
                Genre_Id = gen1.Id,
                Director = "John Bruno, James Cameron, Keith Melton, Stan Winston",
                Poster = "http://image.tmdb.org/t/p/original//dH3LT4qrEIiwYOerOWPsCx5GjNB.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("27/04/1996", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1996,
                Description = "In the year 2029, a computer called Skynet is fighting against a human resistance, after having nearly destroyed the rest of humanity in 1997. Skynet has found a way to send some of it\'s warriors, called Terminators, back in time. This is the story of the Terminator sent to kill the resistance leader in 1996. The resistance sends a reprogrammed Terminator back to 1996 to protect the young man, and the two end up traveling to the year 2029. The question is, can the future resistance leader and the Terminator defeat another new Terminator while destroying Skynet in the future?",
                Duration = 21,
                Views_Count = 0
            };
            m189.Add();
            Movie m190 = new Movie()
            {
                Imdb_Id = "tt0321780",
                Title = "Cremaster 1",
                Genre_Id = gen10.Id,
                Director = "Matthew Barney",
                Poster = "http://image.tmdb.org/t/p/original//wZ5uRovwumofHAhUXKEdtOhhI7n.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("06/07/2005", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2005,
                Description = "An experimental short film from the Cremaster series which alludes to the position of the reproductive organs during the embryonic development process.",
                Duration = 40,
                Views_Count = 0
            };
            m190.Add();
            Movie m191 = new Movie()
            {
                Imdb_Id = "tt0116414",
                Title = "Girl 6",
                Genre_Id = gen8.Id,
                Director = "Spike Lee",
                Poster = "http://image.tmdb.org/t/p/original//wfX5aEsPKqZtKC8devcWrhSLuUO.jpg",
                Youtube_Trailer = "EH_vU3mSszw",
                Release_Date = DateTime.ParseExact("22/03/1996", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1996,
                Description = "This Spike Lee film examines the life of an aspiring actress in New York. She is upset by the treatment of women in the movie industry during one of her screen tests with \'QT\'. Out of work and desperate for money, she decides to take a job as a phone-sex operator. Here, unlike her previous dealings with potential employers, her (female) boss is kind, caring, and sensitive. Later, she begins to get too engrossed in her work and starts to lose touch with reality, represented by her friend and neighbor, Jimmy.",
                Duration = 108,
                Views_Count = 0
            };
            m191.Add();
            Movie m192 = new Movie()
            {
                Imdb_Id = "tt0114959",
                Title = "Witchcraft 8: Salem's Ghost",
                Genre_Id = gen18.Id,
                Director = "Joseph John Barmettler",
                Poster = "http://image.tmdb.org/t/p/original//4kmxowPIXwdhU8FZ4a8UomlMSwq.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("12/06/1996", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1996,
                Description = "A happy young couple moves into a \"dream home\" only to find it is a gateway for occult powers.",
                Duration = 90,
                Views_Count = 0
            };
            m192.Add();
            Movie m193 = new Movie()
            {
                Imdb_Id = "tt0113270",
                Title = "The Haunted World of Edward D. Wood Jr.",
                Genre_Id = gen4.Id,
                Director = "Brett Thompson",
                Poster = "http://image.tmdb.org/t/p/original//xeCdob80x6te0k80B7TPp0cqhLV.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/05/1996", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1996,
                Description = "How was it possible that a movie like \"Plan 9 from Outerspace\" could be made? This documentary about Ed Wood Jr.\'s masterpiece gives the answer.",
                Duration = 89,
                Views_Count = 0
            };
            m193.Add();
            Movie m194 = new Movie()
            {
                Imdb_Id = "tt0378840",
                Title = "Take That: Hometown - Live at Manchester G-Mex",
                Genre_Id = gen11.Id,
                Director = "Dick Carruthers",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("14/08/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "A concert by the record-breaking UK boyband Take That, recorded live in Manchester during their 1994 European tour.",
                Duration = 147,
                Views_Count = 0
            };
            m194.Add();
            Movie m195 = new Movie()
            {
                Imdb_Id = "tt0113368",
                Title = "I Like to Play Games",
                Genre_Id = gen18.Id,
                Director = "Robert Kubilos",
                Poster = "http://image.tmdb.org/t/p/original//xX5VEjTXwKFokLta1xZb7lTt0Ts.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/09/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "Michael is looking for a woman who likes to play games, but when he finds Suzzanne, she might just be more than he bargained for.",
                Duration = 95,
                Views_Count = 0
            };
            m195.Add();
            Movie m196 = new Movie()
            {
                Imdb_Id = "tt0113550",
                Title = "Kingfish: A Story of Huey P. Long",
                Genre_Id = gen8.Id,
                Director = "Thomas Schlamme",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("19/03/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "A look at the life and career of controversial Louisiana governor Huey Long, whose nickname was \"The Kingfish.\"",
                Duration = 100,
                Views_Count = 0
            };
            m196.Add();
            Movie m197 = new Movie()
            {
                Imdb_Id = "tt0112681",
                Title = "Citizen X",
                Genre_Id = gen6.Id,
                Director = "Chris Gerolmo",
                Poster = "http://image.tmdb.org/t/p/original//5M2zsDVRwGx8xNmPhh5WoKBiCyH.jpg",
                Youtube_Trailer = "20KiHIT6wu0",
                Release_Date = DateTime.ParseExact("25/02/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "Based on the true story of a Russian serial killer who, over many years, claimed over 50 victims, mostly under the age of 17. In what was then a Communist state, the police investigations were hampered by bureaucracy, incompetence and those in power. The story is told from the viewpoint of the detective in charge of the case.",
                Duration = 105,
                Views_Count = 0
            };
            m197.Add();
            Movie m198 = new Movie()
            {
                Imdb_Id = "tt0114781",
                Title = "Under Siege 2: Dark Territory",
                Genre_Id = gen20.Id,
                Director = "Geoff Murphy",
                Poster = "http://image.tmdb.org/t/p/original//1nPbFoDf5gXJHoCi1EQM21YukLB.jpg",
                Youtube_Trailer = "OhPOPHR67-U",
                Release_Date = DateTime.ParseExact("14/07/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "Seal Team Commander Casey Ryback has retired from the Navy since the conclusion of the events in the first movie, and is now a chef at the Mile High Cafe in Denver, Colorado. Ryback is taking his niece Sarah Ryback on vacation, to reconnect and commiserate with her after the death of her parents. They board a train traveling westbound through the Rocky Mountains from Denver to LA. With the help of gun-for-hire Marcus Penn a couple dozen of his mercenaries, ex-CIA brain (and mentally unstable) Travis Dane commandeers the train, takes the passengers and crew hostage, and sets up a mobile control center. He hacks into the CIA database and gains control of a Top-Secret defence satellite he designed during his Agency days that has just been deployed. Funded by various foreign interests, he stands to make 1 billion dollars for using the space weapon to blow up the Eastern seaboard by targeting a nuclear reactor housed beneath the Pentagon. Dane taunts the Joint Chiefs in the Pentagon Situation Room by using it to blow up a Chinese chemical weapons plant and the two stealth planes sent to intercept him, secure in the knowledge that he cannot be stopped because his location can\'t be traced as long as the train keeps moving, his location can\'t be fixed. Ryback, aided by young porter Bobby Zachs, is the only ones who can take out the bad guys, rescue the hostages, and prevent the destruction of the eastern seaboard before Dane can realise his dastardly plans!",
                Duration = 100,
                Views_Count = 0
            };
            m198.Add();
            Movie m199 = new Movie()
            {
                Imdb_Id = "tt0113253",
                Title = "Halloween 6: The Curse of Michael Myers",
                Genre_Id = gen20.Id,
                Director = "Joe Chappelle",
                Poster = "http://image.tmdb.org/t/p/original//shNOTvaMz7C05LxBOWpakfJVWHc.jpg",
                Youtube_Trailer = "rAaPBxBxaV8",
                Release_Date = DateTime.ParseExact("29/09/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "Six years ago, Michael Myers terrorized the town of Haddonfield, Illinois. He and his niece, Jamie Lloyd, have disappeared. Jamie was kidnapped by a bunch of evil druids who protect Michael Myers. And now, six years later, Jamie has escaped after giving birth to Michael\'s child. She runs to Haddonfield to get Dr. Loomis to help her again. Meanwhile, the family that adopted Laurie Strode is living in the Myers house and are being stalked by Myers. It\'s the curse of Thorn that Michael is possessed by that makes him kill his family. And it\'s up to Tommy Doyle, the boy from Halloween, and Dr. Loomis, to stop them all.",
                Duration = 87,
                Views_Count = 0
            };
            m199.Add();
            Movie m200 = new Movie()
            {
                Imdb_Id = "tt0110758",
                Title = "Pink Floyd: P. U. L. S. E. Live at Earls Court",
                Genre_Id = gen14.Id,
                Director = "David Mallet",
                Poster = "http://image.tmdb.org/t/p/original//4FEp1hl27OLV8EP8qyGtNidoUtv.jpg",
                Youtube_Trailer = "XyvoXn51BOA",
                Release_Date = DateTime.ParseExact("02/08/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "Pink Floyd\'s final live show in 1995.",
                Duration = 145,
                Views_Count = 0
            };
            m200.Add();
            Movie m201 = new Movie()
            {
                Imdb_Id = "tt0110093",
                Title = "I Love Trouble",
                Genre_Id = gen5.Id,
                Director = "Charles Shyer",
                Poster = "http://image.tmdb.org/t/p/original//4iosJnVbfTVGZ59hxSnzJjCEygp.jpg",
                Youtube_Trailer = "c0OGgqPat_A",
                Release_Date = DateTime.ParseExact("29/06/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "Veteran reporter Peter Brackett is enjoying new found fame after his book, \"White Lies\" is published. When he is asked by his newspaper \"The Chicago Chronicle\" to report on a train crash, he notices new reporter Sabrina Peterson. Brackett\'s complacency gets rudely shocked by Peterson\'s report for the rival \"Chicago Globe.\" What follows next is a mad race between the reporters who then cook up possible events that lead up to the crash. After an initial spate of mad reporting, both settle down to get the facts straight, which leads them to uncover opposing information. When each gets setup to be killed at the same place, they escape, and then agree to work together. While they initially do not trust one another, they eventually come to work together to uncover the truth behind the train crash.",
                Duration = 123,
                Views_Count = 0
            };
            m201.Add();
            Movie m202 = new Movie()
            {
                Imdb_Id = "tt0111361",
                Title = "Tammy and the T-Rex",
                Genre_Id = gen18.Id,
                Director = "Stewart Raffill",
                Poster = "http://image.tmdb.org/t/p/original//sO9xkkAiE5lg9SB2VPc25IAEHUa.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("21/12/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "An evil scientist implants the brain of Michael, a murdered high school student, in an animatronic Tyrannosaurus. He escapes, wreaks vengeance on his high school tormentors and is reunited with his sweetheart Tammy. Together, the couple try to elude the mad scientist and the police and find a more appropriate vessel for Michael\'s brain.",
                Duration = 82,
                Views_Count = 0
            };
            m202.Add();
            Movie m203 = new Movie()
            {
                Imdb_Id = "tt0109578",
                Title = "Death Wish V: The Face of Death",
                Genre_Id = gen6.Id,
                Director = "Allan A. Goldstein",
                Poster = "http://image.tmdb.org/t/p/original//xXtPHkNeKaLLKHF09lPo8uVySim.jpg",
                Youtube_Trailer = "IoMq2mIP704",
                Release_Date = DateTime.ParseExact("14/01/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "New York\'s garment district has turns into Dodge City when mobster Tommy O\'Shea muscles in on the fashion trade of his ex-wife Olivia Regent. Olivia is engaged to Paul Kersey, who provides a sense of security for herself and her daughter Chelsea. Olivia isn\'t impressed when Tommy tortures her manager, Big Al, so Tommy hires an enforcer named Freddie Flakes, who is a master of disguise. Freddie dons women\'s clothing to follow Olivia into a ladies\' room, where he smashes her face into a mirror, causing permanent disfigurement. In the offices of D.A. Tony Hoyle and his associate Hector Vasquez, Paul and Olivia vow to see to it that Tommy is prosecuted. Later, Freddie and two of his men disguise themselves as cops, infiltrate Olivia\'s apartment, and shoot Olivia dead. Now Kersey is ready to take things into his own hands. Kersey follows Tommy\'s thug Chickie Paconi to the Paconi family bistro, where Kersey kills Chickie by lacing his cannelloni with cyanide. Next, Paul tricks Freddie out of his fortress-like home and blows him up with a rigged ball. After dispatching the corrupt Hector Vasquez with a gun concealed in a doll, Kersey discovers that D.A. Hoyle is in cahoots with Tommy. Using Chelsea as bait, Tommy lures Paul to Olivia\'s factory for a confrontation.",
                Duration = 95,
                Views_Count = 0
            };
            m203.Add();
            Movie m204 = new Movie()
            {
                Imdb_Id = "tt0252105",
                Title = "WrestleMania X",
                Genre_Id = gen19.Id,
                Director = "Kevin Dunn",
                Poster = "http://image.tmdb.org/t/p/original//2jdrt59N7iMMhjCtbkGstc9RTCd.jpg",
                Youtube_Trailer = "R3ap_g7uOHE",
                Release_Date = DateTime.ParseExact("20/03/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "WWF Title: Lex Luger vs. Yokozuna, with the winner to face Bret Hart. Owen Hart vs. Bret Hart, WWF Intercontinental Title (ladder match): Razor Ramon vs. Shawn Michaels, WWF Tag Team Titles: The Quebeccers vs. Men on a Mission, Women\'s Title: Alundra Blayze vs. Lelani Kai, Falls Count Anywhere: Crush vs. Randy Savage, Earthquake vs. Adam Bomb, Doink & Dink vs. Bam Bam Bigelow & Luna",
                Duration = 164,
                Views_Count = 0
            };
            m204.Add();
            Movie m205 = new Movie()
            {
                Imdb_Id = "tt0110622",
                Title = "Naked Gun 33 1/3: The Final Insult",
                Genre_Id = gen6.Id,
                Director = "Peter Segal",
                Poster = "http://image.tmdb.org/t/p/original//n3ia62ThbLDVpoZpvTkoVe5SL1n.jpg",
                Youtube_Trailer = "WQ3p19A1mbw",
                Release_Date = DateTime.ParseExact("18/03/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "Oscar night. Who will win? Who will lose? And will someone please kick that numbskull off stage? Wait! That\'s no ordinary numbskull. That\'s Lt. Frank Drebin, crashing the ceremonies to stop a terrorist plot that could mean curtains for him -- or will a simple window shade be enough?",
                Duration = 83,
                Views_Count = 0
            };
            m205.Add();
            Movie m206 = new Movie()
            {
                Imdb_Id = "tt0110613",
                Title = "My Girl 2",
                Genre_Id = gen8.Id,
                Director = "Howard Zieff",
                Poster = "http://image.tmdb.org/t/p/original//uj6S0MZSkURedf9MmOJOOkNVtbE.jpg",
                Youtube_Trailer = "w3gVq6WXMpg",
                Release_Date = DateTime.ParseExact("11/02/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "Vada Sultenfuss has a holiday coming up, and an assignment: to do an essay on someone she admires and has never met. She decides she wants to do an assignment on her mother, but quickly realizes she knows very little about her. She manages to get her father to agree to let her go to LA to stay with her Uncle Phil and do some research on her mother. Once in LA, she finds herself under the protection of Nick, the son of Phil\'s girlfriend, who at first is very annoyed at losing his holidays to escort a hick *girl* around town. However, he soon becomes more involved in the difficult search.",
                Duration = 99,
                Views_Count = 0
            };
            m206.Add();
            Movie m207 = new Movie()
            {
                Imdb_Id = "tt0110255",
                Title = "Kickboxer 4: The Aggressor",
                Genre_Id = gen19.Id,
                Director = "Albert Pyun",
                Poster = "http://image.tmdb.org/t/p/original//ypNodj34ee0eXFvacB9Tw0Cqcej.jpg",
                Youtube_Trailer = "UKiAvG7hjnU",
                Release_Date = DateTime.ParseExact("14/05/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "Sasha Mitchell (\"Kickboxer 2&3\") triumphantly returns to the ring as David Sloan, fighting not just for his survival, but for his beautiful wife, who has become the sexual captive of the despicable world champion, Tong Po. Framed, forgotten and furious, Sloan has been wasting away in prison, but the Feds agree to release him if he will get inside Tong Po\'s impenetrable Mexican fortress, protected by its deadly guards and adorned by its sexual slaves. Sloan has no choice but to enter into Po\'s tournament of champions, a savage battle where winner takes all - and to Sloan - that means everything! Reluctantly, alliances form with a few others to help him out.",
                Duration = 90,
                Views_Count = 0
            };
            m207.Add();
            Movie m208 = new Movie()
            {
                Imdb_Id = "tt0109021",
                Title = "8 Seconds",
                Genre_Id = gen8.Id,
                Director = "John G. Avildsen",
                Poster = "http://image.tmdb.org/t/p/original//xfb9JIE8Sx7Usb4pyofe1o33kNG.jpg",
                Youtube_Trailer = "I2Sgit4QPlM",
                Release_Date = DateTime.ParseExact("25/02/1994", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1994,
                Description = "This film chronicles the life of Lane Frost, 1987 PRCA Bull Riding World Champion, his marriage and his friendships with Tuff Hedeman (three-time World Champion) and Cody Lambert.",
                Duration = 105,
                Views_Count = 0
            };
            m208.Add();
            Movie m209 = new Movie()
            {
                Imdb_Id = "tt0108366",
                Title = "Totally F***ed Up",
                Genre_Id = gen8.Id,
                Director = "Gregg Araki",
                Poster = "http://image.tmdb.org/t/p/original//3aRW3AZyj9Kr8Ii0yo0WsN6CdRs.jpg",
                Youtube_Trailer = "Q6eLzb4EpEY",
                Release_Date = DateTime.ParseExact("13/01/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "Life really sucks for a group of gay and lesbian teenagers living in Los Angeles. Their parents kicked them out, they\'re broke and bored, their lovers cheat on them, they\'re harassed by gay-bashers. If things are going to be this way, maybe suicide isn\'t a bad idea; at least not in the mind of Andy, our major protagonist, who gives the film its title by describing himself as \"totally fucked up.\"",
                Duration = 78,
                Views_Count = 0
            };
            m209.Add();
            Movie m210 = new Movie()
            {
                Imdb_Id = "tt0438975",
                Title = "The Secret File of J. Edgar Hoover",
                Genre_Id = gen2.Id,
                Director = "William Cran",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("02/09/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "For nearly 50 years, FBI director J. Edgar Hoover amassed secret files on America\'s most prominent figures, files he used to smear and control presidents and politicians. Frontline reveals how Hoover\'s own secret life left him open to blackmail by the Mafia and offers a startling new explanation why the FBI allowed the mob to operate unchallenged for over two decades.",
                Duration = 149,
                Views_Count = 0
            };
            m210.Add();
            Movie m211 = new Movie()
            {
                Imdb_Id = "tt0107044",
                Title = "Gregory K",
                Genre_Id = gen6.Id,
                Director = "Linda Otto",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("08/02/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "TV movie based on the the story of the kid who divorced his parents. Gregory has lived a rough life. His father abuses him and his two brothers. The boys are placed with the mother. Gregory is placed in a boys ranch after his mother can\'t take care of him and his two brothers. While at the ranch a lawyer visiting the facility meets him. He and his wife decide to adopt him and make him a part of the family. But Gregory can\'t be adopted until his biological parents lose custody. He divorces his parents from their rights to him.",
                Duration = 89,
                Views_Count = 0
            };
            m211.Add();
            Movie m212 = new Movie()
            {
                Imdb_Id = "tt0107243",
                Title = "Jack L. Warner: The Last Mogul",
                Genre_Id = gen4.Id,
                Director = "Gregory Orr",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("14/05/2006", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2006,
                Description = "An insider\'s account of a founding father of the American film industry. Produced by Jack Warner\'s grandson, filmmaker Gregory Orr, this feature length documentary provides the rags to riches story of the man whose studio - Warner Bros - created many of Hollywood\'s most classic films, including \"Casablanca,\" \"Now Voyager,\" \"Treasure or the Sierra Madre\" \"Yankee Doodle Dandy,\" \"My Fair Lady,\" \"Bonnie & Clyde\" and hundreds more. Includes extensive interviews with family members and friends, film clips, rare home movies and unique location footage.",
                Duration = 104,
                Views_Count = 0
            };
            m212.Add();
            Movie m213 = new Movie()
            {
                Imdb_Id = "tt0107468",
                Title = "M. Butterfly",
                Genre_Id = gen17.Id,
                Director = "David Cronenberg",
                Poster = "http://image.tmdb.org/t/p/original//1OHhe9Se2GxUscVhmUXJSGIT4LK.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/10/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "During the Cultural Revolution in China in the mid-1960s, a French diplomat falls in love with a singer in the Beijing Opera. Interwoven with allusions to the Puccini opera \"Madama Butterfly\", a story of love and betrayal unfolds.",
                Duration = 101,
                Views_Count = 0
            };
            m213.Add();
            Movie m214 = new Movie()
            {
                Imdb_Id = "tt0500177",
                Title = "VeggieTales: Where's God When I'm S-Scared?",
                Genre_Id = gen9.Id,
                Director = "Phil Vischer, Chris Olsen",
                Poster = "http://image.tmdb.org/t/p/original//zya2pjj0OEuwKSZ8Xc9cFnKpofM.jpg",
                Youtube_Trailer = "x2zxGp1kuTI",
                Release_Date = DateTime.ParseExact("01/12/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "\"Tales from the Crisper\": Junior Asparagus, after watching a scary Frankencelery movie, is afraid to go to sleep; he gets help from Bob the Tomato and Larry the Cucumber, who teach him that God is bigger than anything he might be afraid of. \"Daniel and the Lion\'s Den\": Daniel becomes King Darius\' trusted advisor, but some jealous scallions throw Daniel into the lion\'s den. Daniel realizes that God\'s love will always protect him.",
                Duration = 30,
                Views_Count = 0
            };
            m214.Add();
            Movie m215 = new Movie()
            {
                Imdb_Id = "tt0107659",
                Title = "Loaded Weapon 1",
                Genre_Id = gen5.Id,
                Director = "Gene Quintano",
                Poster = "http://image.tmdb.org/t/p/original//iopzKaV2M2aMYGXe3STZ4Bn2jgk.jpg",
                Youtube_Trailer = "Xtz0Zw0eSkA",
                Release_Date = DateTime.ParseExact("05/02/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "An LA detective is murdered because she has microfilm with the recipe to make cocaine cookies. A \"Lethal Weapon\" style cop team tries to find and stop the fiends before they can dope the nation by distributing their wares via the \"Wilderness Girls\" cookie drive.",
                Duration = 84,
                Views_Count = 0
            };
            m215.Add();
            Movie m216 = new Movie()
            {
                Imdb_Id = "tt0107899",
                Title = "Puppet Master 4",
                Genre_Id = gen13.Id,
                Director = "Jeff Burr",
                Poster = "http://image.tmdb.org/t/p/original//mGvLt7Qqnxk8M9yczKGv3Qu0HTb.jpg",
                Youtube_Trailer = "_Ry0urSxtF0",
                Release_Date = DateTime.ParseExact("22/09/1995", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1995,
                Description = "A young scientist working on an artificial intelligence project is the target of strange gremlin-like creatures, who are out to kill him and thus terminate his research. By coincidence, in one of the rooms he uses, there\'s a mysterious case containing the puppets of the \"puppet master\". When the puppets are brought to life, they help destroy the creatures.",
                Duration = 79,
                Views_Count = 0
            };
            m216.Add();
            Movie m217 = new Movie()
            {
                Imdb_Id = "tt0106336",
                Title = "Babylon 5: The Gathering",
                Genre_Id = gen2.Id,
                Director = "Richard Compton",
                Poster = "http://image.tmdb.org/t/p/original//4HnR4lZL4BQ4gcje6OWqjMG0JJh.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("22/02/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "This TV movie is the pilot for the \"Babylon 5\" TV series. Set on a space station in the late 23rd Century, Babylon 5 is a centre of diplomacy and trade, in neutral space located between many rival space empires. The project\'s success, already shaky, is put further in doubt when incoming Commander Jeffrey Sinclair is the key suspect in the attempted assassination of Kosh, a mysterious alien ambassador.",
                Duration = 89,
                Views_Count = 0
            };
            m217.Add();
            Movie m218 = new Movie()
            {
                Imdb_Id = "tt0105323",
                Title = "Scent of a Woman",
                Genre_Id = gen12.Id,
                Director = "Martin Brest",
                Poster = "http://image.tmdb.org/t/p/original//xDw3Yz797LSBGSxSrzBFEsP3Px4.jpg",
                Youtube_Trailer = "3GUvsJc3vvE",
                Release_Date = DateTime.ParseExact("08/01/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "Frank is a retired Lt Col in the US army. He\'s blind and impossible to get along with. Charlie is at school and is looking forward to going to university; to help pay for a trip home for Christmas, he agrees to look after Frank over thanksgiving. Frank\'s niece says this will be easy money, but she didn\'t reckon on Frank spending his thanksgiving in New York.",
                Duration = 156,
                Views_Count = 0
            };
            m218.Add();
            Movie m219 = new Movie()
            {
                Imdb_Id = "tt0104298",
                Title = "Freddie as F.R.O.7.",
                Genre_Id = gen2.Id,
                Director = "Jon Acevski",
                Poster = "http://image.tmdb.org/t/p/original//9HrdF4TPMkGsc5ZMDTPh0b84lEW.jpg",
                Youtube_Trailer = "Q2Odfz8Nu40",
                Release_Date = DateTime.ParseExact("28/08/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "The story about a man-sized frog named Prince Frederic who is turned into a frog by his wicked aunt Messina and hired by British Intelligence to solve the mysterious disappearances of some of Britain\'s greatest monuments. Several hundred years later, Freddie is now living in modern-day Paris -- a six-foot-tall amphibian with the moniker Secret Agent F.R.O.7. Messina, too, is still around causing mischief, joining forces with an arch-villain named El Supremo in a scheme to shrink Big Ben. Freddie, alerted to Messina\'s nefarious plans, gathers his fellow agents Daffers and Scottie together, planning to hide out in Big Ben and surprise the evil doers when they are set to strike at the much-loved British landmark.",
                Duration = 90,
                Views_Count = 0
            };
            m219.Add();
            Movie m220 = new Movie()
            {
                Imdb_Id = "tt0104437",
                Title = "Honey I Blew Up the Kid",
                Genre_Id = gen5.Id,
                Director = "Randal Kleiser",
                Poster = "http://image.tmdb.org/t/p/original//ae2oJzjdGcGo14iECNnkcnLlUyI.jpg",
                Youtube_Trailer = "NIury7go2bM",
                Release_Date = DateTime.ParseExact("17/07/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "Wayne Szalinski is at it again. But instead of shrinking things, he tries to make a machine that can make things grow. As in the first one, his machine isn\'t quite accurate. But when he brings Nick & his toddler son Adam to see his invention, the machine unexpectedly starts working. And when Adam comes right up to the machine, he gets zapped along with his stuffed bunny. Now, whenever Adam comes near anything electrical, the electricity causes him to grow. Adam soon starts to grow to the height of over 100 feet. And he is now walking through Las Vegas which he thinks is one big play land.",
                Duration = 89,
                Views_Count = 0
            };
            m220.Add();
            Movie m221 = new Movie()
            {
                Imdb_Id = "tt0105512",
                Title = "T Bone N Weasel",
                Genre_Id = gen11.Id,
                Director = "Lewis Teague",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("02/11/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "An ex-con and a crazy man are an unlikely duo on the road looking for a better life. All they have is an old gun and a stolen car to aid them in finding some much needed luck and plenty of cold hard cash.",
                Duration = 94,
                Views_Count = 0
            };
            m221.Add();
            Movie m222 = new Movie()
            {
                Imdb_Id = "tt0104797",
                Title = "Malcolm X",
                Genre_Id = gen8.Id,
                Director = "Spike Lee",
                Poster = "http://image.tmdb.org/t/p/original//q6rZELSmaTmg1jISuRKvtJhQ2SW.jpg",
                Youtube_Trailer = "LbKs766Tr88",
                Release_Date = DateTime.ParseExact("18/11/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "Biograpical epic of Malcolm X, the legendary African American leader. Born Malcolm Little, his father (a Garveyite Baptist minister) was killed by the Ku Klux Klan. Malcolm became a gangster, and while in jail discovered the Nation of Islam writings of Elijah Muhammad. He preaches the teachings when let out of jail, but later on goes on a pilgrimage to the city of Mecca, there he converts to the original Islamic religion and becomes a Sunni Muslim and changes his name to El-Hajj Malik Al-Shabazz. He is assassinated on February 21, 1965 and dies a Muslim martyr.",
                Duration = 202,
                Views_Count = 0
            };
            m222.Add();
            Movie m223 = new Movie()
            {
                Imdb_Id = "tt0104714",
                Title = "Lethal Weapon 3",
                Genre_Id = gen6.Id,
                Director = "Richard Donner",
                Poster = "http://image.tmdb.org/t/p/original//rnMLbWNSWX70eWFxWOpkfngXtwD.jpg",
                Youtube_Trailer = "oGbAMRvYYq0",
                Release_Date = DateTime.ParseExact("15/05/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "Martin Riggs finally meets his match in the form of Lorna Cole, a beautiful but tough policewoman. Together with Roger Murtaugh, his partner, the three attempt to expose a crooked former policeman and his huge arms racket. The crooked cop (Jack Travis) thwarts them at every turn, mainly by killing anyone who is about to talk, but Murtaugh has personal problems of his own as his family are brought into the equation.",
                Duration = 118,
                Views_Count = 0
            };
            m223.Add();
            Movie m224 = new Movie()
            {
                Imdb_Id = "tt0101628",
                Title = "Critters 4",
                Genre_Id = gen18.Id,
                Director = "Rupert Harvey",
                Poster = "http://image.tmdb.org/t/p/original//7GHXvhvildJxOnoK6EkufJa7LSl.jpg",
                Youtube_Trailer = "Ic3pHEu9FV4",
                Release_Date = DateTime.ParseExact("14/10/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "Just before bounty hunter Charile triggers his gun to destroy the last two Critter-eggs, he gets a message that it would be illegal to extinguish the race from the galaxy. He\'s sent a transporter where he puts the eggs - unfortunately the transporter takes him with it and then gets lost in space. After 53 deep-frozen years, he\'s found by a private wreckage collector team under the unscrupulous Rick. On behalf of the mighty company Terracor they bring him to an empty space station - but Rick is curious and opens the box... so Charlie has work again, to keep the Critters from eating everybody.",
                Duration = 87,
                Views_Count = 0
            };
            m224.Add();
            Movie m225 = new Movie()
            {
                Imdb_Id = "tt0104549",
                Title = "Jennifer 8",
                Genre_Id = gen8.Id,
                Director = "Bruce Robinson",
                Poster = "http://image.tmdb.org/t/p/original//uHmSupRi8iy95PqSNuZTaGw0ECA.jpg",
                Youtube_Trailer = "QT4ldB2Ck0Y",
                Release_Date = DateTime.ParseExact("06/11/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "A big-city cop from L.A. moves to a small-town police force and immediately finds himself investigating a murder. Using theories rejected by his colleagues, the cop, John Berlin, meets a young blind woman named Helena, who he is attracted to. Meanwhile, a serial killer is on the loose and only John knows it.",
                Duration = 124,
                Views_Count = 0
            };
            m225.Add();
            Movie m226 = new Movie()
            {
                Imdb_Id = "tt0102343",
                Title = "Love Potion No. 9",
                Genre_Id = gen10.Id,
                Director = "Dale Launer",
                Poster = "http://image.tmdb.org/t/p/original//4BPDY8omk9r1qMrgG7oTAA82YS1.jpg",
                Youtube_Trailer = "uh6ir2m5SLw",
                Release_Date = DateTime.ParseExact("13/11/1992", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1992,
                Description = "Two scientists who are hopeless with the opposite sex experiment with a substance that makes them irresistible to anyone who hears them speak.",
                Duration = 92,
                Views_Count = 0
            };
            m226.Add();
            Movie m227 = new Movie()
            {
                Imdb_Id = "tt0106758",
                Title = "The Double 0 Kid",
                Genre_Id = gen5.Id,
                Director = "Dee McLachlan",
                Poster = "http://image.tmdb.org/t/p/original//8OC9QmxmWaeBuGZ8pMS5ucCQcyV.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/04/1993", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1993,
                Description = "Lance, a teenager, dreams to be a secret agent when he is suddenly in the middle of an hacker intrigue which aims at an international environmental congress. Lance gets in possession of a computer access card one of which the hackers are in urgent need of for their operation. Lance begins to play with the hackers, seeing his dream come true.",
                Duration = 95,
                Views_Count = 0
            };
            m227.Add();
            Movie m228 = new Movie()
            {
                Imdb_Id = "tt0102015",
                Title = "Hearts of Darkness: A Filmmaker's Apocalypse",
                Genre_Id = gen8.Id,
                Director = "Fax Bahr, George Hickenlooper, Eleanor Coppola",
                Poster = "http://image.tmdb.org/t/p/original//mQ6GJtc5xZpNQpVhAfoeZZbrzJO.jpg",
                Youtube_Trailer = "lxowb5IQRuI",
                Release_Date = DateTime.ParseExact("06/12/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "Documents the sensational events surrounding the making of Apocalypse Now (1979)\' and Francis Ford Coppola\'s struggle with nature, governments, actors, and self-doubt. Includes footage and sound secretly recorded by Eleanor Coppola, wife of Francis.",
                Duration = 96,
                Views_Count = 0
            };
            m228.Add();
            Movie m229 = new Movie()
            {
                Imdb_Id = "tt0102481",
                Title = "Muppet*vision 3-D",
                Genre_Id = gen5.Id,
                Director = "Jim Henson, Frank Oz",
                Poster = "http://image.tmdb.org/t/p/original//43FMrcBZaqpfEUVwPHy6GBB9Lsf.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/05/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "Muppet*vision 3-D, more appropriately, 4-D, can only be seen at the Disney\'s Hollywood Studios in Walt Disney World, Orlando, FL and also at California Adventure at the Disneyland Resort, Anaheim, CA. This \"4-D\" film begins with an entertaining 15 minute pre-show in the waiting area. The movie is shown in a huge theater on screen that is twice the size of a typical movie theater. 3-D glasses are required to see the film correctly. Antics abound in this hilarious show that is true to the classic Muppet Show. Kermit narrates while we visit the Muppet Lab which, of course, has its difficulties. This is where we meet Dr. Bunsen Honeydew\'s newest discovery, Waldo - the spirit of 3-D, who causes some trouble. Next, Miss Piggy sings a song where Bean Bunny tries to improve the show. Bean Bunny\'s good intentions do not satisfy Miss Piggy, and disheartened, he runs away with Waldo and the search is on in the theater. Finally, Sam Eagle is in charge of the grand finale, \"A Salute to All Nations, but Mostly America\" but, of course, things don\'t go so well. Don\'t forget to look at the rear of the theater to see the Chef running the projector... and the cannon.",
                Duration = 20,
                Views_Count = 0
            };
            m229.Add();
            Movie m230 = new Movie()
            {
                Imdb_Id = "tt0101846",
                Title = "F/X2",
                Genre_Id = gen20.Id,
                Director = "Richard Franklin",
                Poster = "http://image.tmdb.org/t/p/original//9v2a9G98m8RJxr4EekFmnh9YYfJ.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("10/05/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "F/X man Rollie Tyler (Bryan Brown) is now a toy maker. Mike Brandon (Tom Mason), the ex-husband of Rolly\'s girlfriend Kim(Rachel Ticotin), is a cop. He asks Rollie to help catch a killer. The operation goes well until some unknown man kills both the killer and Mike.Mike\'s boss, Ray Silak (Philip Bosco) says it was the killer who killed Mike but Rollie knows it wasn\'t. Silak is involved with Mike\'s death, so he calls on Leo McCarthy (Brian Dennehy), the cop from the last movie, who is now a P.I., for help and they discover it\'s not just Silak they have to worry about.",
                Duration = 108,
                Views_Count = 0
            };
            m230.Add();
            Movie m231 = new Movie()
            {
                Imdb_Id = "tt0101301",
                Title = "All I Want for Christmas",
                Genre_Id = gen9.Id,
                Director = "Robert Lieberman",
                Poster = "http://image.tmdb.org/t/p/original//tAp9pc2YawPcgnaZ4TBz1o9EWcI.jpg",
                Youtube_Trailer = "rjRILzo_Nu0",
                Release_Date = DateTime.ParseExact("08/11/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "\"All I Want For Christmas\" is a comedy about two New York City children who launch a hilarious scheme to get what they most want this holiday season. Ethan, a practical older brother, and adorable Hallie, who knows how to charm her way out of a difficult situation, are intent on spending Christmas with their parents, Catherine and Michael, and grandmother Lillian. As Ethan and Hallie embark on their adventure, almost nothing goes exactly as they planned. Complicating things is a smarmy businessman named Toney Boer, who has taken an interest in Catherine. Ethan, meanwhile, is preoccupied with not only his parents\' romantic dilemma, but also his own - one brought about by his new friendship with Stephanie, his first teenage crush. What evolves is an elaborate scheme involving mice, telephone calls and an ice-cream truck, as Ethan and Hallie try to achieve their goal with the help of Stephanie. The duo\'s primary obstacle is their mother\'s fiance, Tony. The children finally succeed with a little Christmas magic from Santa Claus.",
                Duration = 92,
                Views_Count = 0
            };
            m231.Add();
            Movie m232 = new Movie()
            {
                Imdb_Id = "tt0102177",
                Title = "K-9000",
                Genre_Id = gen18.Id,
                Director = "Kim Manners",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/07/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "A policeman and a female scientist team up to recover her latest creation, a cybernetic, crime-fighting dog.",
                Duration = 96,
                Views_Count = 0
            };
            m232.Add();
            Movie m233 = new Movie()
            {
                Imdb_Id = "tt0102364",
                Title = "M Is for Man, Music, Mozart",
                Genre_Id = gen22.Id,
                Director = "Peter Greenaway",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("03/11/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "A commissioned project, made for TV in honor the the 200th anniversary of Mozart\'s death, this is a highly avant-garde piece of music, theater and dance, set to an original score by the controversial Dutch composer Louis Andriessen (who would later collaborate with Greenaway on the operas \"Rosa\" and \"Writing to Vermeer\"). Four nude, powder-white dancers (representing the Gods) appear on a stage designed in the style of an 18th century anatomy theater. A woman sings a list of objects beginning with various letters of the alphabet up to \"M\"; the Gods then decide to create Man, assembling him from body parts listed as onscreen text. Having created Man, the Gods then give him Movement; so as to give him a reason to move, they create Music; finally, so as to have Perfect Music, they create Mozart.",
                Duration = 29,
                Views_Count = 0
            };
            m233.Add();
            Movie m234 = new Movie()
            {
                Imdb_Id = "tt0101507",
                Title = "Boyz n the Hood",
                Genre_Id = gen8.Id,
                Director = "John Singleton",
                Poster = "http://image.tmdb.org/t/p/original//numVTm441JOv6d4rQMaNz9o3Gm6.jpg",
                Youtube_Trailer = "AE4BdijGtu4",
                Release_Date = DateTime.ParseExact("12/07/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "John Singleton\'s portrayal of social problems in inner-city Los Angeles takes the form of a tale of three friends growing up together \'in the \'hood.\' Half-brothers Doughboy and Ricky Baker are foils for each other\'s personality, presenting very different approaches to the tough lives they face. Ricky is the \'All-American\' athlete, looking to win a football scholarship to USC and seeks salvation through sports, while \'Dough\' succumbs to the violence, alcohol, and crime surrounding him in his environment, but maintains a strong sense of pride and code of honor. Between these two is their friend Tre, who is lucky to have a father, \'Furious\' Styles, to teach him to have the strength of character to do what is right and to always take responsibility for his actions.",
                Duration = 112,
                Views_Count = 0
            };
            m234.Add();
            Movie m235 = new Movie()
            {
                Imdb_Id = "tt0103956",
                Title = "Child's Play 3",
                Genre_Id = gen20.Id,
                Director = "Jack Bender",
                Poster = "http://image.tmdb.org/t/p/original//kHGLUgNsjTNsDAgXMvYH7J48Ikx.jpg",
                Youtube_Trailer = "9X4Uq9lf1c0",
                Release_Date = DateTime.ParseExact("30/08/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "It\'s been eight years since the events in the second film, we now see that Andy is a teenager who has been enrolled in a military school. Play Pals Toy Company decides to re-release its Good Guys line, feeling that after all this time, the bad publicity has died down. As they re-used old materials, the spirit of Charles Lee Ray once again comes to life. In his search for Andy, Chucky falls into the hands of a younger boy, and he realizes that it may be easier to transfer his soul into this unsuspecting child. Andy is the only one who knows what Chucky is up to, and it\'s now up to him to put a stop to it.",
                Duration = 90,
                Views_Count = 0
            };
            m235.Add();
            Movie m236 = new Movie()
            {
                Imdb_Id = "tt0105410",
                Title = "Silent Night, Deadly Night 5: The Toy Maker",
                Genre_Id = gen18.Id,
                Director = "Martin Kitrosser",
                Poster = "http://image.tmdb.org/t/p/original//9N9AwRjoiOmqSgVN5bJL5VxUp4P.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("06/11/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "A young boy sees his father killed by a toy that was anonymously delivered to his house. After that, he is too traumatized to speak, and his mother must deal with both him and the loss of her husband. Meanwhile, a toy maker named Joe Peto builds some suspicious-looking toys, and a mysterious man creeps around both the toy store and the boy\'s house...but who is responsible for the killer toys?",
                Duration = 90,
                Views_Count = 0
            };
            m236.Add();
            Movie m237 = new Movie()
            {
                Imdb_Id = "tt0101255",
                Title = "9 1/2 Ninjas!",
                Genre_Id = gen15.Id,
                Director = "Aaron Barsky",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/01/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "The first erotic arts action comedy.",
                Duration = 88,
                Views_Count = 0
            };
            m237.Add();
            Movie m238 = new Movie()
            {
                Imdb_Id = "tt0099141",
                Title = "Bird on a Wire",
                Genre_Id = gen5.Id,
                Director = "John Badham",
                Poster = "http://image.tmdb.org/t/p/original//sHIwSqEeSNILJ6db2MNBalhX7zI.jpg",
                Youtube_Trailer = "MhaVziFh1ws",
                Release_Date = DateTime.ParseExact("18/05/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "Rick has been given a new identity by the FBI for helping convict a drug dealing FBI agent. Fifteen years later his former fiance recognises him. Rick\'s FBI \'minder\' has been replaced by a corrupt agent who helps the drug dealing FBI agent and his accomplice locate him. There are many subsequent chase scenes as Rick and girlfriend revisit his former haunts.",
                Duration = 110,
                Views_Count = 0
            };
            m238.Add();
            Movie m239 = new Movie()
            {
                Imdb_Id = "tt0098211",
                Title = "Cyber-C.H.I.C.",
                Genre_Id = gen5.Id,
                Director = "Ed Hansen, Jeffrey Mandel",
                Poster = "http://image.tmdb.org/t/p/original//yoB1dgQe0IDRg5LObgHpesQiW8g.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("09/08/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "Dr. Von Colon has just put the finishing touches on his most amazing creation: Robo-C.H.I.C., a crime-fighting robot built in the shape of a Playboy Playmate. Her invention comes just in time, as a disgruntled engineer has built a set of atomic bombs and plans to set them all off if his demands are not met. Adding to the confusion are a pimp and a motorcycle gang who decide to kidnap the bomber for their own purposes.",
                Duration = 102,
                Views_Count = 0
            };
            m239.Add();
            Movie m240 = new Movie()
            {
                Imdb_Id = "tt0128246",
                Title = "H",
                Genre_Id = gen21.Id,
                Director = "Darrell Wasyk",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/09/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "Two junkies lock themselves in an underground apartment in a desperate attempt to wean themselves off heroin.",
                Duration = 94,
                Views_Count = 0
            };
            m240.Add();
            Movie m241 = new Movie()
            {
                Imdb_Id = "tt0099445",
                Title = "Dr. M",
                Genre_Id = gen8.Id,
                Director = "Claude Chabrol",
                Poster = "http://image.tmdb.org/t/p/original//4GHdNtTingCFr4KXsNq0UrLVGQN.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/05/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "In the not-too-distant future Berlin is shocked by a series of spectacular suicides; a policeman\'s investigations lead him to a beautiful, enigmatic woman and the revelation of a sinister plot to manipulate the population through mass hypnosis.",
                Duration = 116,
                Views_Count = 0
            };
            m241.Add();
            Movie m242 = new Movie()
            {
                Imdb_Id = "tt0100192",
                Title = "Mother Goose Rock 'n' Rhyme",
                Genre_Id = gen9.Id,
                Director = "Jeff Stein",
                Poster = "http://image.tmdb.org/t/p/original//pbElGlpuXscpZUoqHl3J9gDEQGE.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("19/05/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "There\'s a crisis in Rhymeland! All the Rhymies (the characters from Nursery Rhymes) are disappearing! Gordon Goose, son of Mother Goose, and Little Bo Peep set off to find them.",
                Duration = 96,
                Views_Count = 0
            };
            m242.Add();
            Movie m243 = new Movie()
            {
                Imdb_Id = "tt0098966",
                Title = "3 Men and a Little Lady",
                Genre_Id = gen8.Id,
                Director = "Emile Ardolino",
                Poster = "http://image.tmdb.org/t/p/original//vRPZTQxaNxoQhlj7SeYSAkxmy2M.jpg",
                Youtube_Trailer = "tzwQWUYtiUE",
                Release_Date = DateTime.ParseExact("21/11/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "Sylvia\'s work increasingly takes her away from the three men who help bring up Mary, her daughter. When she decides to move to England and take Mary with her, the three men are heartbroken at losing the two most important females in their lives.",
                Duration = 104,
                Views_Count = 0
            };
            m243.Add();
            Movie m244 = new Movie()
            {
                Imdb_Id = "tt0101326",
                Title = "American Ninja 4: The Annihilation",
                Genre_Id = gen8.Id,
                Director = "Cedric Sundstrom",
                Poster = "http://image.tmdb.org/t/p/original//1SOYro5XNcIp4Z4EicqmcfCeIDE.jpg",
                Youtube_Trailer = "9i1rrGVLlPI",
                Release_Date = DateTime.ParseExact("08/03/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "CIA agent Sean Davidson and his sidekick Carl are sent into the stronghold of sadistic British ex-soldier Mulgrew to rescue some Delta Force commandoes who have been captured and tortured. When Sean, Carl and pretty doctor Sarah run into some problems, Peace Corps vet Joe Armstrong is lured out of retirement to stop Mulgrew\'s plan to explode a nuclear device in New York City.",
                Duration = 99,
                Views_Count = 0
            };
            m244.Add();
            Movie m245 = new Movie()
            {
                Imdb_Id = "tt0097981",
                Title = "A Nightmare on Elm Street 5: The Dream Child",
                Genre_Id = gen13.Id,
                Director = "Stephen Hopkins",
                Poster = "http://image.tmdb.org/t/p/original//7jQ5uwFcMuRL7pmCVDjq7KpBwbU.jpg",
                Youtube_Trailer = "wAfqn1F3lhE",
                Release_Date = DateTime.ParseExact("11/08/1989", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1989,
                Description = "Alice, having survived the previous installment of the Nightmare series, finds the deadly dreams of Freddy Krueger starting once again. This time, the taunting murderer is striking through the sleeping mind of Alice\'s unborn child. His intention is to be \"born again\" into the real world. The only one who can stop Freddy is his dead mother, but can Alice free her spirit in time to save her own son?",
                Duration = 89,
                Views_Count = 0
            };
            m245.Add();
            Movie m246 = new Movie()
            {
                Imdb_Id = "tt0346832",
                Title = "Dancing for Mr. B: Six Balanchine Ballerinas",
                Genre_Id = gen15.Id,
                Director = "Anne Belle, Deborah Dickson",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("07/10/1989", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1989,
                Description = "Six of George Balanchine\'s finest stars, Maria Tallchief, Mary Ellen Moylan, Melissa Hayden, Allegra Kent, Merrill Ashley and Darci Kistler pay a moving tribute to the legendary choreographer and tell how he shaped them as dancers and influenced their lives.",
                Duration = 86,
                Views_Count = 0
            };
            m246.Add();
            Movie m247 = new Movie()
            {
                Imdb_Id = "tt0097523",
                Title = "Honey, I Shrunk the Kids",
                Genre_Id = gen5.Id,
                Director = "Joe Johnston",
                Poster = "http://image.tmdb.org/t/p/original//5AhzhhWMD7VxjXjvr1Cx3BmPxyj.jpg",
                Youtube_Trailer = "PVF9Wz3LBgs",
                Release_Date = DateTime.ParseExact("23/06/1989", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1989,
                Description = "Wayne Szalinski is your average \"nutty scientist\", working on a top secret machine that shrinks objects. When it unexpectedly starts working, he\'s so amazed he forgets to tell his family to be careful. And when they wander into his lab...",
                Duration = 93,
                Views_Count = 0
            };
            m247.Add();
            Movie m248 = new Movie()
            {
                Imdb_Id = "tt0097637",
                Title = "K-9",
                Genre_Id = gen5.Id,
                Director = "Rod Daniel",
                Poster = "http://image.tmdb.org/t/p/original//cpeXyg83ONQCMGcTixIJ4pNcNlN.jpg",
                Youtube_Trailer = "hCRZBon82Qw",
                Release_Date = DateTime.ParseExact("28/04/1989", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1989,
                Description = "The extravagant cop Michael Dooley needs some help to fight a drug dealer who has tried to kill him. A \"friend\" gives him a dog named Jerry Lee, who has been trained to smell drugs. With his help, Dooley sets out to put his enemy behind the bars, but Jerry Lee has a personality of his own and works only when he wants to. On the other hand, the dog is quite good at destroying Dooley\'s car, house and sex-life...",
                Duration = 101,
                Views_Count = 0
            };
            m248.Add();
            Movie m249 = new Movie()
            {
                Imdb_Id = "tt0097939",
                Title = "My Name Is Bill W.",
                Genre_Id = gen20.Id,
                Director = "Daniel Petrie",
                Poster = "http://image.tmdb.org/t/p/original//1urHtVm2tYGynQfeNGUqCRNDLEf.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("30/04/1989", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1989,
                Description = "This film reconstructs the true story of stockbroker William Griffith Wilson, a World War I veteran whose small drinking problem becomes a serious addiction after he loses his fortune in the stock market collapse of 1929. Wilson\'s career and his domestic life are in tatters when he meets Dr. Robert Holbrook Smith also struggling with a drinking problem. The two form a support group that becomes the basis for the organization Alcoholics Anonymous.",
                Duration = 100,
                Views_Count = 0
            };
            m249.Add();
            Movie m250 = new Movie()
            {
                Imdb_Id = "tt0096804",
                Title = "American Ninja 3: Blood Hunt",
                Genre_Id = gen8.Id,
                Director = "Cedric Sundstrom",
                Poster = "http://image.tmdb.org/t/p/original//28Cpn5TcL0tGFBo7Qh7CbvV8i5n.jpg",
                Youtube_Trailer = "30Wp3YQNc2Q",
                Release_Date = DateTime.ParseExact("24/02/1989", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1989,
                Description = "Jackson is back, and now he has a new partner, karate champion Sean, as they must face a deadly terrorist known as \"The Cobra\", who has infected Sean with a virus. Sean and Jackson have no choice but to fight the Cobra and his bands of ninjas.",
                Duration = 89,
                Views_Count = 0
            };
            m250.Add();
            Movie m251 = new Movie()
            {
                Imdb_Id = "tt0094620",
                Title = "Zombie 4: After Death",
                Genre_Id = gen13.Id,
                Director = "Claudio Fragasso",
                Poster = "http://image.tmdb.org/t/p/original//fMr7gdEFGTI7XZIKJGnold1aSt.jpg",
                Youtube_Trailer = "us0M1T069ac",
                Release_Date = DateTime.ParseExact("27/07/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "A woman goes back to the island where her parents were killed. They had been working on a cure for cancer and accidentally raised the dead by angering a voodoo priest. With the woman is a group of mercenaries and they meet up with some other researchers. They raise the dead again and all hell breaks loose.",
                Duration = 84,
                Views_Count = 0
            };
            m251.Add();
            Movie m252 = new Movie()
            {
                Imdb_Id = "tt0098105",
                Title = "Police Academy 6: City Under Siege",
                Genre_Id = gen6.Id,
                Director = "Peter Bonerz",
                Poster = "http://image.tmdb.org/t/p/original//Apyk9JRSm6mgQ9H13N5KabMiboo.jpg",
                Youtube_Trailer = "f52e7LNT474",
                Release_Date = DateTime.ParseExact("10/03/1989", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1989,
                Description = "A string of business robberies have taken place in the city\'s Wilson Heights neighborhood, all done by the same three crooks. Captain Thaddeus Harris is no longer in the same precinct with a certain group of cops that he doesn\'t like. That\'s why Harris is so happy to be in the Wilson Heights precinct. But then The Mayor tells Harris that business in the city is plummeting because of the robberies. Since there appears to be a leak in Harris\'s precinct, the Governor has sent in a team to stop the Wilson Heights gang. Much to Harris\'s dismay, the team is led by Commandant Eric Lassard, so Harris knows who the team members are -- exactly the cops that he doesn\'t like. The team members are Nick Lassard, Moses Hightower, Eugene Tackleberry, Larvell Jones, Debbie Callahan, Laverne Hooks, and Douglas Fackler. The stakes are raised when Commandant Lassard is accused of being the mastermind behind the robberies, and the team must clear his name.",
                Duration = 84,
                Views_Count = 0
            };
            m252.Add();
            Movie m253 = new Movie()
            {
                Imdb_Id = "tt0097716",
                Title = "Mr. H Is Late",
                Genre_Id = gen5.Id,
                Director = "Eric Sykes",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/02/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "A team of inept undertakers attempt to get a coffin to a funeral on time.",
                Duration = 30,
                Views_Count = 0
            };
            m253.Add();
            Movie m254 = new Movie()
            {
                Imdb_Id = "tt0246644",
                Title = "George Carlin: What Am I Doing in New Jersey?",
                Genre_Id = gen5.Id,
                Director = "Bruce Gowers",
                Poster = "http://image.tmdb.org/t/p/original//i5DGEWs5jUnkpvDfZySA948k5yU.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("12/06/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "George Carlin changes his act by bringing politics into the act, but also talks about the People he can do without, Keeping People Alert, and Cars and Driving part 2.",
                Duration = 61,
                Views_Count = 0
            };
            m254.Add();
            Movie m255 = new Movie()
            {
                Imdb_Id = "tt0094696",
                Title = "Baby M",
                Genre_Id = gen8.Id,
                Director = "James Steven Sadwith",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("22/05/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "When Bill and Betsy Stern ask MaryBeth Whitehead to bear a surrogate child for them, it seems like a perfect arrangement. But little do they realize that MaryBeth will refuse to surrender her new born daughter. There are no laws governing surrogacy and when MaryBeth goes on the run with the baby, the Stems are forced into a traumatic court case to fight for custody of the daughter they have grown to love so dearly. But even more crucial are the rights of Baby M herself, a child growing up with two names, two homes, a child torn between two loving families.",
                Duration = 200,
                Views_Count = 0
            };
            m255.Add();
            Movie m256 = new Movie()
            {
                Imdb_Id = "tt0096142",
                Title = "Sorority Babes in the Slimeball Bowl-O-Rama",
                Genre_Id = gen13.Id,
                Director = "David DeCoteau",
                Poster = "http://image.tmdb.org/t/p/original//tXxZ4PZZyFut82v861vo6EPt9Gt.jpg",
                Youtube_Trailer = "-VHcdmh6JwA",
                Release_Date = DateTime.ParseExact("29/01/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "Three frat boys sneak into the Tri-Delt sorority to witness the initiation of new pledges and are caught. The pledges must go to the local bowling lane and steal a trophy, aided by the unwanted frat boys. An accident causes the trophy to break, releasing an evil imp who then begins wreaking havoc with the teens, who begin suffering an attrition problem.",
                Duration = 80,
                Views_Count = 0
            };
            m256.Add();
            Movie m257 = new Movie()
            {
                Imdb_Id = "tt0096101",
                Title = "Short Circuit 2",
                Genre_Id = gen8.Id,
                Director = "Kenneth Johnson",
                Poster = "http://image.tmdb.org/t/p/original//tHuWYBNfsVOc99PBmQtEBryG2Hd.jpg",
                Youtube_Trailer = "z6VVELKyhOg",
                Release_Date = DateTime.ParseExact("06/07/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "When Number Five is sent from Newton and Stephanie\'s ranch to the big city to help Ben with his electronics business, he finds that his robotic talents are wanted by city low-life who want to turn Number Five into profits.",
                Duration = 110,
                Views_Count = 0
            };
            m257.Add();
            Movie m258 = new Movie()
            {
                Imdb_Id = "tt0095742",
                Title = "A Nightmare on Elm Street 4: The Dream Master",
                Genre_Id = gen4.Id,
                Director = "Renny Harlin",
                Poster = "http://image.tmdb.org/t/p/original//dDn5n9JbGLEthBndWtkW343BhYE.jpg",
                Youtube_Trailer = "jc-9vF9F_eg",
                Release_Date = DateTime.ParseExact("19/08/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "Following up the previous Nightmare film, the dream demon Freddy Krueger is resurrected from his apparent demise, and rapidly tracks down and kills all three of the surviving Elm Street kids. However, Kristen (who has the ability to draw others into her dreams) wills her special ability to her friend Alice before her demise. Afterwords, Alice soon realizes that Freddy is taking advantage of that unknown power she now wields to pull a new group of teenage children into his foul domain.",
                Duration = 93,
                Views_Count = 0
            };
            m258.Add();
            Movie m259 = new Movie()
            {
                Imdb_Id = "tt0095882",
                Title = "Police Academy 5: Assignment: Miami Beach",
                Genre_Id = gen6.Id,
                Director = "Alan Myerson",
                Poster = "http://image.tmdb.org/t/p/original//pmQ4DsQ4x6iSA0iOIArRpGt8lT3.jpg",
                Youtube_Trailer = "FKEspwO4vHA",
                Release_Date = DateTime.ParseExact("18/03/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "The old Commandant Lassard, leader of the Police Academy (1984), goes to Florida to receive an award. In the city arrives also the cynic Captain Harris who wants to take Lassard\'s job. Harris wants to place himself in a favourable light in front of the high military hierarchy but, at the airport, Lassard exchanges his bag with another one...",
                Duration = 90,
                Views_Count = 0
            };
            m259.Add();
            Movie m260 = new Movie()
            {
                Imdb_Id = "tt0095032",
                Title = "Disaster at Silo 7",
                Genre_Id = gen18.Id,
                Director = "Larry Elikann",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("27/11/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "During routine maintenance of a liquid-fuelled ICBM, the fuel tank is penetrated by a falling spanner. The film traces the efforts of the maintenance crew and associated military and civilian personnel to recover the potentially disastrous situation before the fuel tank is sufficiently depressurised that the stack collapses and explodes.",
                Duration = 96,
                Views_Count = 0
            };
            m260.Add();
            Movie m261 = new Movie()
            {
                Imdb_Id = "tt0292522",
                Title = "Garfield: His 9 Lives",
                Genre_Id = gen2.Id,
                Director = "Phil Roman, Doug Frankel, Bob Scott, Ruth Kissane(co-director), Bill Littlejohn(co-director), Bob Nesler(co-director), George Singer(co-director), John Sparey(co-director)",
                Poster = "http://image.tmdb.org/t/p/original//9npcUo0fmdlFeuOqVu9xphZBVh5.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("22/11/1988", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1988,
                Description = "This sometimes funny and sometimes emotional animated retelling of the book of the same name follows the nine lives that Garfield the cat had lived throughout history, often as himself but sometimes as a completely different looking cat. The live action introductory segment \"In the Beginning\" follows two angels who wonder why God gave nine lives to cats of all creatures. \"Cave Cat\" follows Garfield as a prehistoric cat-Neanderthal, as well as the evolutionary path that led to him. In \"King Cat\", Garfield is the sacred pet cat of the Egyptian pharaoh. When Garfield learns in shock that if the pharaoh dies, his cats get buried with him, he tries everything he can to prevent his master\'s assassination. \"In the Garden\" follows Garfield as a cute innocent kitten who lives playing with his young mistress in her uncle\'s beautiful garden all day long. However, her uncle warns them never to open a mysterious chest that lies in the garden. In \"Court Musician\", a king demands that Handel, a local composer, writes a wonderful concerto for him. Since the king might punish him if he doesn\'t end up liking the piece, Handel sends his pet cat and apprentice Garfield to play it for the king. \"Stunt Cat\" follows Garfield as a professional stunt-cat, who doubles for famous Krazy Kat. However, one of the stunts doesn\'t go as planned. In \"Diana\'s Piano\", Garfield is a beautiful female cat called Diana, who enjoys resting on top of a piano while her talented young mistress Sara practices. The two make a life-long bond through music. The next segment, \"Lab Animal\", is the most serious and darkest segment as it follows Garfield as one of the frightened lab animals, who are about to become test subjects. Subject 19-GB, as he\'s called in the lab, tries to make a daring desperate escape from the facility. The next story \"Garfield\" focuses on his current life with Jon and Odie and shows how they all met. The final story \"Space Cat\" is set in the future and follows Garfield and Odie as two astronaut animals, who try to find a way to fight back and save themselves when a mad commander called Mendelson and his IHGWF (Incredibly Huge Galactic War Fleet) threaten to blow up their shuttle. After having spent all of his nine lives, Garfield, in the epilogue, finally meets God - with surprising results.",
                Duration = 60,
                Views_Count = 0
            };
            m261.Add();
            Movie m262 = new Movie()
            {
                Imdb_Id = "tt0093629",
                Title = "A Nightmare on Elm Street 3: Dream Warriors",
                Genre_Id = gen13.Id,
                Director = "Chuck Russell",
                Poster = "http://image.tmdb.org/t/p/original//lNrbMhjhAQK9Hf4Nww7GoBezCMA.jpg",
                Youtube_Trailer = "tG_faxqrjc0",
                Release_Date = DateTime.ParseExact("27/02/1987", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1987,
                Description = "Picking up where the original Nightmare left off, Nancy has grown up and become a psychiatrist specializing in dream therapy. She meets a group of children at a local hospital facing Freddy Krueger, the same demon she once encountered in her sleep. One of them is Kristen, who has the power to draw other people into her dreams. Working with a male doctor assigned to the case, Nancy helps the kids realize their special abilities within the nightmare world. When Freddy captures one of her charges, she leads a rescue attempt into Krueger\'s domain, in hopes of putting his spirit to rest once and for all.",
                Duration = 96,
                Views_Count = 0
            };
            m262.Add();
            Movie m263 = new Movie()
            {
                Imdb_Id = "tt0093970",
                Title = "Sign 'o' the Times",
                Genre_Id = gen14.Id,
                Director = "Prince, Albert Magnoli",
                Poster = "http://image.tmdb.org/t/p/original//uNBcDVnWtN2wiFK7MBPvdNheKpH.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("20/11/1987", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1987,
                Description = "In front of a crowd at the Rotterdam Music Hall, Prince and his band perform 13 numbers, 11 of which are from his double album, \"Sign \'o\' the Times,\" and all but \"Now\'s the Time\" are his compositions. This is high energy stuff, with neon signs flashing above the stage, suggesting the honky-tonk district of a big city. Between a few of the numbers, there are vignettes of street life. Three women - Shiela E, Boni Boyer, and Cat - provide rhythmic, vocal, and physical pyrotechnics. Sheena Easton appears in a film within a film, her rock video \"U Got the Look.\" In constant motion, never far from center stage, is Prince, Minnesota\'s charismatic pixy.",
                Duration = 85,
                Views_Count = 0
            };
            m263.Add();
            Movie m264 = new Movie()
            {
                Imdb_Id = "tt0092796",
                Title = "Creepshow 2",
                Genre_Id = gen10.Id,
                Director = "Michael Gornick",
                Poster = "http://image.tmdb.org/t/p/original//cEOva5ciTQxJCQgcXb6vpAx1BcP.jpg",
                Youtube_Trailer = "or86vxRtXl4",
                Release_Date = DateTime.ParseExact("01/05/1987", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1987,
                Description = "\"Creepshow 2\" is divided into three stories, conducted by a leading segment where a boy that loves the horror comic book Creepshow buys seeds of carnivorous plant and is bullied by four teenagers. Meanwhile the Creep tells the tales of Creepshow: (1) \"Old Chief Wood\'nhead\" - The elders Ray (George Kennedy) and Martha Spruce (Dorothy Lamour) have lived their whole life and raised their family with their small store in an Arizona town. Now the town is economically decadent and Ray gives credit to his costumers including the Indians of Ben Whitemoon\'s tribe. When Ray is repairing the wooden statue of an old chief in the front door, Ben (Frank Salsedo) arrives and asks him to keep the jewels of his tribe as a guarantee for their debts. However, Ben\'s nephew Sam (Holt McCallany) unexpectedly arrives with two other punks to steal Ray, and he kills the elders. They expect to travel to Hollywood, but the Old Chief Wood\'nhead will not let them go. (2) \"The Raft\" - The teenagers Deke (Paul Satterfield) and Randy (Daniel Beer) travel with Laverne (Jeremy Green) and Rachel (Page Hannah) to a lake expecting to smoke weed, swim and get laid. They swim to a raft that is floating in the middle of the lake, but they discover a carnivorous blob in the lake that is hungry. (3) \"The Hitchhiker\" - In Maine, the unfaithful Annie Lansing (Lois Chiles) stays too long having sex with her escort and is late to meet her husband in the airport. She drives her Mercedes Bens in a hurry and loses control on the road. Annie runs over a hitchhiker, but she does not help the man and hit-and-run, questioning whether she can live with the situation. She discovers that the hitchhiker will not leave her.",
                Duration = 92,
                Views_Count = 0
            };
            m264.Add();
            Movie m265 = new Movie()
            {
                Imdb_Id = "tt0093756",
                Title = "Police Academy 4: Citizens on Patrol",
                Genre_Id = gen6.Id,
                Director = "Jim Drake",
                Poster = "http://image.tmdb.org/t/p/original//aHiWHHqO1a1WY02KQGwvECJ7hzH.jpg",
                Youtube_Trailer = "hByakBsSyEw",
                Release_Date = DateTime.ParseExact("03/04/1987", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1987,
                Description = "A new batch of recruits arrives at Police Academy, this time a group of civilian volunteers who have joined Commandant Lassard\'s new Citizens on Patrol program. Although the community relations project has strong governmental support, a disgusted Captain Harris is determined to see it fail.",
                Duration = 88,
                Views_Count = 0
            };
            m265.Add();
            Movie m266 = new Movie()
            {
                Imdb_Id = "tt0093405",
                Title = "Leonard Part 6",
                Genre_Id = gen5.Id,
                Director = "Paul Weiland",
                Poster = "http://image.tmdb.org/t/p/original//2OoykhydUHRQlmqdQ3tqX53LwKs.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("18/12/1987", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1987,
                Description = "The CIA asks for ex-spy Leonard\'s help in stopping an evil force that is brainwashing small animals into killing people. Leonard, however, has his own problems to deal with: winning back his ex-wife.",
                Duration = 85,
                Views_Count = 0
            };
            m266.Add();
            Movie m267 = new Movie()
            {
                Imdb_Id = "tt0092780",
                Title = "Conspiracy: The Trial of the Chicago 8",
                Genre_Id = gen16.Id,
                Director = "Jeremy Kagan",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/05/1987", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1987,
                Description = "A made-for-cable-TV docudrama about the trial of the men accused of conspiring to cause protesters to riot at the 1968 Democratic National Convention in Chicago. Combines in an innovative manner dramatic recreations (largely faithful to the actual trial transcripts) with documentary footage and interviews with the actual defendants.",
                Duration = 118,
                Views_Count = 0
            };
            m267.Add();
            Movie m268 = new Movie()
            {
                Imdb_Id = "tt0099763",
                Title = "Henry: Portrait of a Serial Killer",
                Genre_Id = gen6.Id,
                Director = "John McNaughton",
                Poster = "http://image.tmdb.org/t/p/original//9ZYJvlx2nzoi2Q4O11wuDHvTZQe.jpg",
                Youtube_Trailer = "IU3P6WXzvXU",
                Release_Date = DateTime.ParseExact("07/09/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "Loosely based on serial killer Henry Lee Lucas, the film follows Henry and his roommate Otis who Henry introduces to murdering randomly selected people. The killing spree depicted in the film starts after Otis\' sister Becky comes to stay with them. The people they kill are strangers and in one particularly gruesome attack, kill all three members of a family during a home invasion. Henry lacks compassion in everything he does and isn\'t the kind to leave behind witnesses - of any kind.",
                Duration = 83,
                Views_Count = 0
            };
            m268.Add();
            Movie m269 = new Movie()
            {
                Imdb_Id = "tt0089118",
                Title = "F/X",
                Genre_Id = gen20.Id,
                Director = "Robert Mandel",
                Poster = "http://image.tmdb.org/t/p/original//t0u76RL3YlcfnWdRWgRudROqEkg.jpg",
                Youtube_Trailer = "rDQ1hzfb_B4",
                Release_Date = DateTime.ParseExact("07/02/1986", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1986,
                Description = "A movies special effects man is hired by a government agency to help stage the assassination of a well known gangster. When the agency double crosses him, he uses his special effects to trap the gangster and the corrupt agents.",
                Duration = 109,
                Views_Count = 0
            };
            m269.Add();
            Movie m270 = new Movie()
            {
                Imdb_Id = "tt0092076",
                Title = "The Texas Chainsaw Massacre 2",
                Genre_Id = gen13.Id,
                Director = "Tobe Hooper",
                Poster = "http://image.tmdb.org/t/p/original//ajdhwlImMWSWTu1sEMv72yu7IqK.jpg",
                Youtube_Trailer = "xUyEaYxTI2U",
                Release_Date = DateTime.ParseExact("22/08/1986", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1986,
                Description = "Radio DJ Vanita \'Stretch\' Brock\'s open request night is plagued by the annoying phone pranking of two road tripping, party-hard, hoodlums, but things take a disturbing turn when the hoodlums meet their demise at the hands of familiar chainsaw wielding maniacs. With the entire gruesome ordeal recorded on tape, Stretch seeks out the help of a former Texas Marshall who\'s on a personal quest of vengeance against this family of cannibals. While at first he turns her down, he eventually decides to use her tape to his advantage, asking her to air it during her request block- effectively baiting the cannibals to the radio station where he\'ll personally deal with them.",
                Duration = 101,
                Views_Count = 0
            };
            m270.Add();
            Movie m271 = new Movie()
            {
                Imdb_Id = "tt0091777",
                Title = "Police Academy 3: Back in Training",
                Genre_Id = gen4.Id,
                Director = "Jerry Paris",
                Poster = "http://image.tmdb.org/t/p/original//fxIm54v5iHtGmgVQKAu5zyN9L7T.jpg",
                Youtube_Trailer = "QBai0KLPCXY",
                Release_Date = DateTime.ParseExact("21/03/1986", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1986,
                Description = "When police funding is cut, the Governor announces he must close one of the academies. To make it fair, the two police academies must compete against each other to stay in operation. Mauser persuades two officers in Lassard\'s academy to better his odds, but things don\'t quite turn out as expected...",
                Duration = 83,
                Views_Count = 0
            };
            m271.Add();
            Movie m272 = new Movie()
            {
                Imdb_Id = "tt0089686",
                Title = "A Nightmare on Elm Street 2: Freddy's Revenge",
                Genre_Id = gen7.Id,
                Director = "Jack Sholder",
                Poster = "http://image.tmdb.org/t/p/original//tJTrNDt1242xe4zlatlZfDMvWjg.jpg",
                Youtube_Trailer = "9iqNVyjwLFA",
                Release_Date = DateTime.ParseExact("01/11/1985", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1985,
                Description = "A new family moves into the house on Elm Street, and before long, the kids are again having nightmares about deceased child murderer Freddy Krueger. This time, Freddy attempts to possess a teenage boy to cause havoc in the real world, and can only be overcome if the boy\'s sweetheart can master her fear.",
                Duration = 87,
                Views_Count = 0
            };
            m272.Add();
            Movie m273 = new Movie()
            {
                Imdb_Id = "tt0089003",
                Title = "Death Wish 3",
                Genre_Id = gen6.Id,
                Director = "Michael Winner",
                Poster = "http://image.tmdb.org/t/p/original//GqSEbUkXZiulvz0uaME8qTdkX0.jpg",
                Youtube_Trailer = "jeJ7FDxFUxc",
                Release_Date = DateTime.ParseExact("01/11/1985", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1985,
                Description = "Paul Kersey, New York City architect and part-time vigilante, returns from L.A. to visit an old friend. Instead, he must avenge his death by fighting youth gangs.",
                Duration = 92,
                Views_Count = 0
            };
            m273.Add();
            Movie m274 = new Movie()
            {
                Imdb_Id = "tt0087130",
                Title = "Def-Con 4",
                Genre_Id = gen18.Id,
                Director = "Paul Donovan, Digby Cook, Tony Randel",
                Poster = "http://image.tmdb.org/t/p/original//zOPe0FmqTkFSgisiM5sj7j7dwFh.jpg",
                Youtube_Trailer = "qLVpkrMaobw",
                Release_Date = DateTime.ParseExact("15/03/1985", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1985,
                Description = "Two men and a woman circle the globe in a satellite armed with a nuclear device. The third world war breaks out, and a few months later the satellite crashes. They survive the crash but one man gets killed by survivors and the other man gets caught. The woman stays by the remains of the the satellite but is soon caught by evil punks who have taken power.",
                Duration = 88,
                Views_Count = 0
            };
            m274.Add();
            Movie m275 = new Movie()
            {
                Imdb_Id = "tt0090196",
                Title = "Transylvania 6-5000",
                Genre_Id = gen10.Id,
                Director = "Rudy De Luca",
                Poster = "http://image.tmdb.org/t/p/original//9Qo8ZpAU5j5yJI77CUodebBfYE3.jpg",
                Youtube_Trailer = "ABKy-Pqu-HQ",
                Release_Date = DateTime.ParseExact("08/11/1985", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1985,
                Description = "Tabloid reporters Jack Harrison and Gil Turner are sent to Transylvania with two choices: find the Frankenstein monster or find new jobs. But before the jumpy journalists can dig up their big story, they must first face the horrors of an extremely clumsy butler, a nymphomaniac vampiress and a semi-mad doctor, as well as assorted mummies, werewolves and more Transylvanian oddballs. Can these two bumbling heroes unravel this monstrous mystery or are they in for some very scary surprises?",
                Duration = 93,
                Views_Count = 0
            };
            m275.Add();
            Movie m276 = new Movie()
            {
                Imdb_Id = "tt0086855",
                Title = "André and Wally B.",
                Genre_Id = gen9.Id,
                Director = "Alvy Ray Smith",
                Poster = "http://image.tmdb.org/t/p/original//7l7JMlnEvxoHTPRo0tcGwLEVCu8.jpg",
                Youtube_Trailer = "rQsCw1v-cEU",
                Release_Date = DateTime.ParseExact("22/11/1991", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1991,
                Description = "Dawn, the forest. André is waking up. Soon, Wally is taunting him. André points the other way and, with Wally temporarily distracted, runs off. Wally quickly catches on and chases André...",
                Duration = 2,
                Views_Count = 0
            };
            m276.Add();
            Movie m277 = new Movie()
            {
                Imdb_Id = "tt0087333",
                Title = "Gimme an 'F'",
                Genre_Id = gen18.Id,
                Director = "Paul Justman",
                Poster = "http://image.tmdb.org/t/p/original//wSKAkcsflCQN0sZWNwSGwsYVaRL.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/11/1984", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1984,
                Description = "Can a squad of misfit cheerleaders with an over-age trainer possibly win the big cheerleading competition? Looked down upon by the other teams, it will be an difficult. Their lack of skill and talent make it even harder.",
                Duration = 101,
                Views_Count = 0
            };
            m277.Add();
            Movie m278 = new Movie()
            {
                Imdb_Id = "tt0086999",
                Title = "Breakin' 2: Electric Boogaloo",
                Genre_Id = gen8.Id,
                Director = "Sam Firstenberg",
                Poster = "http://image.tmdb.org/t/p/original//1NHcoLRLnWjvA5ruH8t3QMPaxlX.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("21/12/1984", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1984,
                Description = "A developer tries to bulldoze a community recreation center. The local breakdancers try to stop it.",
                Duration = 94,
                Views_Count = 0
            };
            m278.Add();
            Movie m279 = new Movie()
            {
                Imdb_Id = "tt0085334",
                Title = "A Christmas Story",
                Genre_Id = gen9.Id,
                Director = "Bob Clark",
                Poster = "http://image.tmdb.org/t/p/original//wok0YepwQfBAPsrttFq0W6HXT2g.jpg",
                Youtube_Trailer = "uvMLfSQrHKE",
                Release_Date = DateTime.ParseExact("18/11/1983", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1983,
                Description = "Christmas is approaching and 9 year-old Ralphie wants only one thing: a Red Ryder Range 200 Shot BB gun. When he mentions it at the dinner table, his mother\'s immediate reaction is that he\'ll put his eye out. He then decides on a perfect theme for his teacher but her reaction is like his. He fantasizes about what it would be like to be Red Ryder and catch the bad guys. When the big day arrives he gets lots of present under the tree including a lovely gift from his aunt that his mother just adores. But what about the BB gun?",
                Duration = 94,
                Views_Count = 0
            };
            m279.Add();
            Movie m280 = new Movie()
            {
                Imdb_Id = "tt0085750",
                Title = "Jaws 3-D",
                Genre_Id = gen13.Id,
                Director = "Joe Alves",
                Poster = "http://image.tmdb.org/t/p/original//e6xFzaEzjSF4OnJ4f65ovMJE3vu.jpg",
                Youtube_Trailer = "zMlx33ov82c",
                Release_Date = DateTime.ParseExact("22/07/1983", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1983,
                Description = "Several years after Amity\'s former Police Chief Martin Brody electrocuted the shark at Cable Junction, his sons, Mike & Sean, are now working in different roles at Sea World Orlando. Mike is working as a park engineer and considering marriage to his girlfriend, killer whale biologist Kathryn Morgan. Sean is also involved with 1 of the park\'s water skiers, Kelly Ann Bukowski. Sea World is about to open a massive \'Undersea Kingdom\' which will bring visitors closer to marine life than ever before. The park is accessible from the ocean by a series of gates, one of which malfunctions. A young Great White Shark swims through the gate, and when a maintenance diver heads down to fix the gate he does not return. The young Great White is captured & placed in a tank but soon dies despite Kathryn\'s best efforts to save it. More alarming though, is the young shark\'s massive, 35 foot mother which has followed the baby shark into the lagoon and killed the maintenance diver, whose body is recovered. It isn\'t long before the huge shark begins wreaking havoc, and Mike & Kathryn, along with Sea World manager Calvin Bouchard and photographer Phillip Fitzroyce, must find a way to eliminate the shark before they - or the guests - become the shark\'s next meal.",
                Duration = 99,
                Views_Count = 0
            };
            m280.Add();
            Movie m281 = new Movie()
            {
                Imdb_Id = "tt0086518",
                Title = "Up 'n' Coming",
                Genre_Id = gen8.Id,
                Director = "Stu Segall",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("07/01/1983", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1983,
                Description = "A rising young country/western singer gets a job as the opening act for a a veteran female country star. Soon the young girl is drawing much attention from the audiences and the record companies, and the older star doesn\'t like it one bit.",
                Duration = 86,
                Views_Count = 0
            };
            m281.Add();
            Movie m282 = new Movie()
            {
                Imdb_Id = "tt0082586",
                Title = "Murder 1, Dancer 0",
                Genre_Id = gen8.Id,
                Director = "Reza Badiyi",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("05/06/1983", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1983,
                Description = "Private eye Joe Dancer finds himself framed for manslaughter while trying to uncover a Hollywood scandal that could ruin a studio and destroy a top star\'s career.",
                Duration = 100,
                Views_Count = 0
            };
            m282.Add();
            Movie m283 = new Movie()
            {
                Imdb_Id = "tt0084908",
                Title = "Will: The Autobiography of G. Gordon Liddy",
                Genre_Id = gen8.Id,
                Director = "Robert Lieberman",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("10/01/1982", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1982,
                Description = "Based on the autobiography of G. Gordon Liddy who spent 54 months in prison following the Watergate scandal.",
                Duration = 120,
                Views_Count = 0
            };
            m283.Add();
            Movie m284 = new Movie()
            {
                Imdb_Id = "tt0084112",
                Title = "I, the Jury",
                Genre_Id = gen8.Id,
                Director = "Richard T. Heffron",
                Poster = "http://image.tmdb.org/t/p/original//kOJdLGRsvRqgN74m0P4a9K0hD1O.jpg",
                Youtube_Trailer = "p5G-m6lLBLI",
                Release_Date = DateTime.ParseExact("22/04/1982", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1982,
                Description = "An old friend of a private detective is murdered. The detective, Mike Hammer, will make every effort to find out the killer. At each step he does, there is someone taking advantage of his progress.",
                Duration = 111,
                Views_Count = 0
            };
            m284.Add();
            Movie m285 = new Movie()
            {
                Imdb_Id = "tt0084556",
                Title = "Q",
                Genre_Id = gen13.Id,
                Director = "Larry Cohen",
                Poster = "http://image.tmdb.org/t/p/original//fZCAeLvohhFOMIZBbT9cFOz0Olu.jpg",
                Youtube_Trailer = "9bjsag2vYlQ",
                Release_Date = DateTime.ParseExact("29/10/1982", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1982,
                Description = "New York police are bemused by a spate of reports of a giant flying lizard that has been spotted around the rooftops of New York, which they assume to be bogus until the lizard starts to eat people. An out-of-work, ex-con piano player is the only person who knows the location of the monster\'s nest and is determined to turn the knowledge to his advantage, but will his gamble pay off or will he end up as lizard food?",
                Duration = 93,
                Views_Count = 0
            };
            m285.Add();
            Movie m286 = new Movie()
            {
                Imdb_Id = "tt0083633",
                Title = "Before the Nickelodeon: The Cinema of Edwin S. Porter",
                Genre_Id = gen4.Id,
                Director = "Charles Musser",
                Poster = "http://image.tmdb.org/t/p/original//19tACyhAnFNmt3YTyLji8YTjLG4.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/10/1982", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1982,
                Description = "This documentary is produced by one of the world\'s foremost authorities and biographers of Edwin S. Porter. Since little is known of Porter\'s personal life, the emphasis here is on his technique and contributions to the art of the cinema. This film also serves as a documentary on the origins of the American cinema; Porter\'s work is showcased in the context of the whole American cinema of his day, from mutoscope parlors to the advent of the projected image.",
                Duration = 60,
                Views_Count = 0
            };
            m286.Add();
            Movie m287 = new Movie()
            {
                Imdb_Id = "tt0084021",
                Title = "Grease 2",
                Genre_Id = gen8.Id,
                Director = "Patricia Birch",
                Poster = "http://image.tmdb.org/t/p/original//i2fTDqSrrq6cHKI3xZWQxV5uemG.jpg",
                Youtube_Trailer = "yfM4Gt4TIYw",
                Release_Date = DateTime.ParseExact("11/06/1982", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1982,
                Description = "Return to rockin\' Rydell High for a whole new term! It\'s 1961, two years after the original Grease gang graduated, and there\'s a new crop of seniors - and new members of the coolest cliques on campus, the Pink Ladies and T-Birds. Michael Carrington is the new kid in school - but he\'s been branded a brainiac. Can he fix up an old motorcycle, don a leather jacket, avoid a rumble with the leader of the T-Birds, and win the heart of Pink Lady Stephanie Zinone? He\'s surely going to try!",
                Duration = 115,
                Views_Count = 0
            };
            m287.Add();
            Movie m288 = new Movie()
            {
                Imdb_Id = "tt0083745",
                Title = "Come Back to the 5 & Dime, Jimmy Dean, Jimmy Dean",
                Genre_Id = gen8.Id,
                Director = "Robert Altman",
                Poster = "http://image.tmdb.org/t/p/original//epb9jLQoKCu5LTcUxstHBkx8lNL.jpg",
                Youtube_Trailer = "d9pd7tnEdEA",
                Release_Date = DateTime.ParseExact("06/04/1983", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1983,
                Description = "The Disciples of James Dean meet up on the anniversary of his death and mull over their lives in the present and in flashback, revealing the truth behind their complicated lives. Who is the mysterious Joanne and what\'s the real story behind Mona\'s son, James Dean Junior ?",
                Duration = 109,
                Views_Count = 0
            };
            m288.Add();
            Movie m289 = new Movie()
            {
                Imdb_Id = "tt0130671",
                Title = "Exhausted: John C. Holmes, the Real Story",
                Genre_Id = gen4.Id,
                Director = "Julia St. Vincent",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/07/1981", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1981,
                Description = "Exhausted is a self-serving softball \"documentary\" about John C. Holmes, who was the biggest star in the adult film industry in two ways. He was the most famous, and he was just the biggest where it really counts in that business, about 13 inches worth. The film combines footage from actual porn films, \"man on the street\" interviews, and interviews with industry insiders: director Bob Chinn, actress Seka, and John Holmes himself. While this film is a not bona fide documentary, detailing the life of John Holmes (before his notorious murder trial), it is still a very erotic and very arousing sex film. It is an attempt to dig into the career of John Holmes, one of the best-known male stars of hard-core pornography, most noted for his big gun. This excellent production was billed as the \"true life story of the unchallenged King of Porn himself\". If you watch it, its difficult to argue - Its packed with the most luscious, explosive women in adult entertainment from the early 80s. The movie in its day was the most publicized adult film to hit the screen since Deep Throat.",
                Duration = 72,
                Views_Count = 0
            };
            m289.Add();
            Movie m290 = new Movie()
            {
                Imdb_Id = "tt0138972",
                Title = "K-9 and Company: A Girl's Best Friend",
                Genre_Id = gen18.Id,
                Director = "John Black",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("28/12/1981", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1981,
                Description = "Spin-off from \"Doctor Who\" which, despite good ratings, didn\'t get past the pilot stage. One time companion to a mysterious and body-changing alien known as \"The Doctor\", Sarah Jane Smith returns to Earth and carries on with her journalist career. Now, in 1981, she has managed to rebuild her career and has come, a matter of days before Christmas, to her Aunt Lavinia\'s (a famous scientist) house in the sleepy English village of Moreton Harwood to write a book and to rest after her world-travelling assignments. However, her journalist\'s nose sniffs out another mystery when she arrives to find Aunt Lavinia gone, and nobody knows where she is, but the local rumour is that she was the victim of a local witch coven. Worshipers of a pagan goddess Hecate gather to celebrate a festival by ritually murdering a friend of Sarah\'s. She needs help... and she gets it from a box from her friend \"The Doctor.\" Inside the box is a metal robotic but almost human-like talking dog called K-9 that is built for Sarah Jane personally and together Sarah and K-9 sets out to solve the mystery and stop the killing of Sarah\'s friend...",
                Duration = 50,
                Views_Count = 0
            };
            m290.Add();
            Movie m291 = new Movie()
            {
                Imdb_Id = "tt0082265",
                Title = "Dial M for Murder",
                Genre_Id = gen3.Id,
                Director = "Boris Sagal",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("09/04/1981", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1981,
                Description = "A London businessman concocts an intricate plan to murder his unfaithful wife for her money.",
                Duration = 98,
                Views_Count = 0
            };
            m291.Add();
            Movie m292 = new Movie()
            {
                Imdb_Id = "tt0082527",
                Title = "X-Ray",
                Genre_Id = gen20.Id,
                Director = "Boaz Davidson",
                Poster = "http://image.tmdb.org/t/p/original//zNu4DtWuV1oG4xY63Ur59aTG9BN.jpg",
                Youtube_Trailer = "gw5GTiaKYzg",
                Release_Date = DateTime.ParseExact("01/04/1982", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1982,
                Description = "Divorcee Susan Jeremy goes to a local Los Angeles county hospital for a routine exam and finds herself stranded there while a maniac, dressed in a doctor\'s surgical mask and clothing, goes around killing all the staff are associated with her. Could it possibly be the psycho Harold, who killed a friend of Susan\'s on Valentine\'s Day 19 years earlier?",
                Duration = 89,
                Views_Count = 0
            };
            m292.Add();
            Movie m293 = new Movie()
            {
                Imdb_Id = "tt0082418",
                Title = "Friday the 13th Part 2",
                Genre_Id = gen16.Id,
                Director = "Steve Miner",
                Poster = "http://image.tmdb.org/t/p/original//mshdRsIOPgzIMdcHUD4I5TUf7kT.jpg",
                Youtube_Trailer = "Qqmj12n7yYc",
                Release_Date = DateTime.ParseExact("30/04/1981", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1981,
                Description = "Months after Alice beheaded psycho killer/mother Pamela Voorhees at Camp Crystal Lake, survivor Alice is still traumatized because of the murders. But there is one problem. Mrs. Voorhee\'s son Jason never drowned and died.So he saw Alice behead Mrs. Voorhees. Jason finds Alice soon and murders her. Five years later a camp counselor in training program begins at Campanack Lodge. Right near Jason\'s home.Camp Crystal Lake. As teenagers in the program start snooping around Camp Crystal Lake, they start getting killed violently one by one.",
                Duration = 87,
                Views_Count = 0
            };
            m293.Add();
            Movie m294 = new Movie()
            {
                Imdb_Id = "tt0080960",
                Title = "Jimmy B. & André",
                Genre_Id = gen14.Id,
                Director = "Guy Green",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("19/03/1980", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1980,
                Description = "Real-life story detailing the relationship between a popular Detroit restaurant owner and a young black youngster whom he tries to adopt.",
                Duration = 100,
                Views_Count = 0
            };
            m294.Add();
            Movie m295 = new Movie()
            {
                Imdb_Id = "tt0081096",
                Title = "M Station: Hawaii",
                Genre_Id = gen3.Id,
                Director = "Jack Lord",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("10/06/1980", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1980,
                Description = "A Russian submarine sank somewhere near Hawaii. The government sees this as an opportunity to learn what they can from the submarine. However, they don\'t want to let the Russians know that ...",
                Duration = 100,
                Views_Count = 0
            };
            m295.Add();
            Movie m296 = new Movie()
            {
                Imdb_Id = "tt0080813",
                Title = "The Great Rock 'n' Roll Swindle",
                Genre_Id = gen20.Id,
                Director = "Julien Temple",
                Poster = "http://image.tmdb.org/t/p/original//mA8jOBq6dfr077V3SPoo4IZhfAp.jpg",
                Youtube_Trailer = "eizQ9l9Qu0A",
                Release_Date = DateTime.ParseExact("12/03/1981", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1981,
                Description = "A rather incoherent post-breakup Sex Pistols \"documentary\", told from the point of view of Pistols manager Malcolm McLaren, whose (arguable) position is that the Sex Pistols in particular and punk rock in general were an elaborate scam perpetrated by him in order to make \"a million pounds.\" Silly and hard to follow at times, but worth seeing for some excellent Pistols concert footage, some wickedly amusing animated sequences, and Sid Vicious\' eerily prophetic performance of \"My Way.\"",
                Duration = 103,
                Views_Count = 0
            };
            m296.Add();
            Movie m297 = new Movie()
            {
                Imdb_Id = "tt0081447",
                Title = "S.H.E: Security Hazards Expert",
                Genre_Id = gen2.Id,
                Director = "Robert Michael Lewis",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("23/02/1980", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1980,
                Description = "Security Hazards Expert Lavinia Kean, a brilliant American espionage agent, combats the wiles of international criminal and blackmailer Cesare Magnasco.",
                Duration = 100,
                Views_Count = 0
            };
            m297.Add();
            Movie m298 = new Movie()
            {
                Imdb_Id = "tt0080895",
                Title = "How to Beat the High Co$t of Living",
                Genre_Id = gen6.Id,
                Director = "Robert Scheerer",
                Poster = "http://image.tmdb.org/t/p/original//xuetcFEDI4IRpenM8T8CIonUVJY.jpg",
                Youtube_Trailer = "9-77VpXSygs",
                Release_Date = DateTime.ParseExact("11/07/1980", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1980,
                Description = "Oregon, 1980: Jane, Elaine and Louise are all feeling the effects of inflation and cannot afford, as the title states, the high cost of living. Jane cannot afford a babysitter or get married and if she wants privacy with her boyfriend, she has to sleep in the car. Even worse, her war veteran father comes to live with her to turn her life upside down. Louise lives a happy life with her veterinarian husband, Albert. She runs an antique shop on the side, but since it doesn\'t take in any profit, the IRS considers it a hobby. She needs to come up with the money to keep it going, or she will be trouble with the IRS. Elaine\'s husband has left her for another woman and without any money. She is in a constant struggle with banks, power companies, and gas stations. She needs money to get by and also catches the eye of police officer Jack. The local mall is having a contest that features a giant money ball that states it will help fight the inflation. Elaine comes up with a plan to steal the money out of it and split it three ways with Jane and Louise. Of course, one catastrophe after another tries to keep them from achieving their goal.",
                Duration = 105,
                Views_Count = 0
            };
            m298.Add();
            Movie m299 = new Movie()
            {
                Imdb_Id = "tt0080684",
                Title = "Star Wars: Episode V - The Empire Strikes Back",
                Genre_Id = gen2.Id,
                Director = "Irvin Kershner",
                Poster = "http://image.tmdb.org/t/p/original//amYkOxCwHiVTFKendcIW0rSrRlU.jpg",
                Youtube_Trailer = "KwYa7UpoWtM",
                Release_Date = DateTime.ParseExact("20/06/1980", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1980,
                Description = "Luke Skywalker, Han Solo, Princess Leia and Chewbacca face attack by the Imperial forces and its AT-AT walkers on the ice planet Hoth. While Han and Leia escape in the Millennium Falcon, Luke travels to Dagobah in search of Yoda. Only with the Jedi master\'s help will Luke survive when the dark side of the Force beckons him into the ultimate duel with Darth Vader.",
                Duration = 124,
                Views_Count = 0
            };
            m299.Add();
            Movie m300 = new Movie()
            {
                Imdb_Id = "tt0079285",
                Title = "Saturn 3",
                Genre_Id = gen13.Id,
                Director = "Stanley Donen, John Barry",
                Poster = "http://image.tmdb.org/t/p/original//bPBW0mETVimiCeQepPRgKnmyeb6.jpg",
                Youtube_Trailer = "NENxIu02bvg",
                Release_Date = DateTime.ParseExact("15/02/1980", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1980,
                Description = "Two lovers stationed at a remote base in the asteroid fields of Saturn are intruded upon by a retentive technocrat from Earth and his charge: a malevolent 8-ft robot. Remember, in space no one can hear you scream...",
                Duration = 96,
                Views_Count = 0
            };
            m300.Add();
            Movie m301 = new Movie()
            {
                Imdb_Id = "tt0080130",
                Title = "When a Stranger Calls",
                Genre_Id = gen8.Id,
                Director = "Fred Walton",
                Poster = "http://image.tmdb.org/t/p/original//fAHaJJCrW8AlQTuTRYD3rAdut5k.jpg",
                Youtube_Trailer = "ZMugfJu_q78",
                Release_Date = DateTime.ParseExact("26/10/1979", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1979,
                Description = "High school student Jill Johnson is traumatized over an evening of babysitting by a caller who repeatedly asks, \"Have you checked the children lately?\" After notifying the police, Jill is told that the calls are coming from inside the house...",
                Duration = 97,
                Views_Count = 0
            };
            m301.Add();
            Movie m302 = new Movie()
            {
                Imdb_Id = "tt7557212",
                Title = "Yours Truly, Andrea G. Stern",
                Genre_Id = gen8.Id,
                Director = "Susan Seidelman",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "HH0Pbmgx6wQ",
                Release_Date = DateTime.ParseExact("11/10/1979", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1979,
                Description = "A young girl chronicles her divorced mother\'s relationship with a new boyfriend who has just moved into the house.",
                Duration = 38,
                Views_Count = 0
            };
            m302.Add();
            Movie m303 = new Movie()
            {
                Imdb_Id = "tt0183152",
                Title = "The Haunting of M.",
                Genre_Id = gen3.Id,
                Director = "Anna Thomas",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/05/1981", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1981,
                Description = "This ghost story, set at the turn of the century, centers on the plight of elderly dowager Marianna, who is tormented by the alleged specter of a young man roaming the corridors of her mansion. After spotting a face in an old photograph that seems to match the old woman\'s description of the \"visitor\", Marianna\'s sister decides to check things out and see if any of this is for real.",
                Duration = 98,
                Views_Count = 0
            };
            m303.Add();
            Movie m304 = new Movie()
            {
                Imdb_Id = "tt0079813",
                Title = "Rock 'n' Roll High School",
                Genre_Id = gen14.Id,
                Director = "Allan Arkush, Joe Dante",
                Poster = "http://image.tmdb.org/t/p/original//zblWKbxJxmV1I0XpciL5R9jDZr.jpg",
                Youtube_Trailer = "qYUzYGRHEo4",
                Release_Date = DateTime.ParseExact("24/08/1979", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1979,
                Description = "Vince Lombardi High School keeps losing principals to nervous breakdowns because of the students\' love of rock \'n\' roll and their disregard of education. The putative leader of the students is Riff Randell, who loves the music of the Ramones. A new principal, the rock-music-hating Miss Evelyn Togar, is brought in and promises to put an end to the music craze. When Miss Togar and a group of parents attempt to burn a pile of rock records, the students take over the high school, joined by the Ramones, who are made honorary students. When the police are summoned and demand that the students evacuate the building, they do so, which leads to an explosive finale.",
                Duration = 93,
                Views_Count = 0
            };
            m304.Add();
            Movie m305 = new Movie()
            {
                Imdb_Id = "tt0079580",
                Title = "Adventures of the Wilderness Family 3",
                Genre_Id = gen2.Id,
                Director = "Jack Couffer",
                Poster = "http://image.tmdb.org/t/p/original//2vsRA8koOVN9v1hiQYwrviSBs9X.jpg",
                Youtube_Trailer = "fvwhBxX-s5c",
                Release_Date = DateTime.ParseExact("01/11/1979", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1979,
                Description = "The family who went \"back to nature\" by homesteading in the Colorado Rockies is threatened by possible federal opposition to their mining claims on the land they moved to.",
                Duration = 100,
                Views_Count = 0
            };
            m305.Add();
            Movie m306 = new Movie()
            {
                Imdb_Id = "tt0079824",
                Title = "Runaway Robots! Romie-O and Julie-8",
                Genre_Id = gen17.Id,
                Director = "Clive A. Smith",
                Poster = "http://image.tmdb.org/t/p/original//zqBTmMZF8gCYRSIFREo6eORYabm.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/04/1979", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1979,
                Description = "Two rival robotics companies in the future release their latest creations at a robotics convention, claiming each to be the latest and greatest in technological advances. Mega Stellar Company\'s release is a robot boy named Romie-O, while Super Solar Cybernetics has released a girl robot named Julie-8. Unforeseen to each of the company\'s creators, is how each of the advanced robots soon falls in love with the other.",
                Duration = 30,
                Views_Count = 0
            };
            m306.Add();
            Movie m307 = new Movie()
            {
                Imdb_Id = "tt0077270",
                Title = "The Boys in Company C",
                Genre_Id = gen21.Id,
                Director = "Sidney J. Furie",
                Poster = "http://image.tmdb.org/t/p/original//kAYKExzVzCRqAhtGEXMXzeNmogS.jpg",
                Youtube_Trailer = "bTmqlvnHGEY",
                Release_Date = DateTime.ParseExact("02/03/1978", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1978,
                Description = "This war drama (which prefigures the later \"Full Metal Jacket\") follows the lives of five young Marine inductees from their training in boot camp in 1967 through a tour in Vietnam in 1968 that quickly devolves into a hellish nightmare. Disheartened by futile combat, appalled by the corruption of their South Vietnamese ally, and constantly endangered by the incompetence of their own company commander, the young men find a possible way out of the war. They are told that if they can defeat a rival soccer team, they can spend the rest of their tour playing exhibition games behind the lines. But as they might have predicted, nothing in Vietnam is as simple as it seems.",
                Duration = 125,
                Views_Count = 0
            };
            m307.Add();
            Movie m308 = new Movie()
            {
                Imdb_Id = "tt0077713",
                Title = "I Spit on Your Grave",
                Genre_Id = gen20.Id,
                Director = "Meir Zarchi",
                Poster = "http://image.tmdb.org/t/p/original//u1YrVf4665Gv8od4VKgP2r6pOIY.jpg",
                Youtube_Trailer = "ZkCTSn8gcL4",
                Release_Date = DateTime.ParseExact("22/11/1978", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1978,
                Description = "The film follows Jennifer, a writer who is working on a new novel and needs to get out of the city to finish it. She rents a riverside cabin in upstate New York to work on her novel, attracting the attention of a number of rowdy male locals. They catch Jennifer one day and strip her naked for the village idiot (Matthew) and rape her. Jennifer is later attacked and raped a further two times by the four degenerates, and her novel is also destroyed. But Jennifer recovers, and in her now-twisted, psychotic state, she begins to seek revenge on the men.",
                Duration = 101,
                Views_Count = 0
            };
            m308.Add();
            Movie m309 = new Movie()
            {
                Imdb_Id = "tt0077766",
                Title = "Jaws 2",
                Genre_Id = gen8.Id,
                Director = "Jeannot Szwarc",
                Poster = "http://image.tmdb.org/t/p/original//pUVaVyWFBRCRSuu6M0rFcyqAwQx.jpg",
                Youtube_Trailer = "oDfZgGf8B5Y",
                Release_Date = DateTime.ParseExact("16/06/1978", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1978,
                Description = "Four years after the events of the original \"Jaws\", the town of Amity suddenly experiences series of mysterious boating accidents and disappearances. Chief of Police, Martin Brody, fears that another shark is out there, but he is ignored by the townsfolk. Unfortunately, he\'s right. There is another Great White in the sea. And it wants revenge.",
                Duration = 116,
                Views_Count = 0
            };
            m309.Add();
            Movie m310 = new Movie()
            {
                Imdb_Id = "tt0076759",
                Title = "Star Wars: Episode IV - A New Hope",
                Genre_Id = gen2.Id,
                Director = "George Lucas",
                Poster = "http://image.tmdb.org/t/p/original//4iJfYYoQzZcONB9hNzg0J0wWyPH.jpg",
                Youtube_Trailer = "vZ734NWnAHA",
                Release_Date = DateTime.ParseExact("25/05/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "The Imperial Forces, under orders from cruel Darth Vader, hold Princess Leia hostage in their efforts to quell the rebellion against the Galactic Empire. Luke Skywalker and Han Solo, captain of the Millennium Falcon, work together with the companionable droid duo R2-D2 and C-3PO to rescue the beautiful princess, help the Rebel Alliance and restore freedom and justice to the Galaxy.",
                Duration = 121,
                Views_Count = 0
            };
            m310.Add();
            Movie m311 = new Movie()
            {
                Imdb_Id = "tt0076172",
                Title = "I Never Promised You a Rose Garden",
                Genre_Id = gen10.Id,
                Director = "Anthony Page",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("29/10/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "Based very loosely on the intricate novel by Joanne Greenberg. A young woman\'s devotion to a childhood fantasy kingdom has taken over her entire life and causes her endless pain and degradation. Placed in a mental hospital, she has the great good fortune to have a truly caring therapist who tries to help her accept reality, even though reality isn\'t so great either.",
                Duration = 96,
                Views_Count = 0
            };
            m311.Add();
            Movie m312 = new Movie()
            {
                Imdb_Id = "tt0076567",
                Title = "The Private Files of J. Edgar Hoover",
                Genre_Id = gen8.Id,
                Director = "Larry Cohen",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/12/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "The story of the late J. Edgar Hoover, who was head of the FBI from 1924-1972. The film follows Hoover from his racket-busting days through his reign under eight U.S. presidents.",
                Duration = 112,
                Views_Count = 0
            };
            m312.Add();
            Movie m313 = new Movie()
            {
                Imdb_Id = "tt0154013",
                Title = "Young, Hot 'n Nasty Teenage Cruisers",
                Genre_Id = gen5.Id,
                Director = "Tom Denucci, Johnny Legend",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/04/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "The first porno rock and roll movie spoofing various teen action and drama flicks from the 1950s, 1960s and early 1970s and set during a long night in the lives of a group of various people getting by during their night on the town. Among the people featured are Willy, the local peeping tom; Babsy Beaudine, a psycho-nymph who escapes from a lunatic hospital and takes a high school professor hostage to make him her sex slave; Serena trying to go all the way with her boyfriend Johnny; two greasers, named Lumby and Whitney, trying to find fun, and encountering it as a local strip club run by gangster Rudy; local stud Moby having a swimming pool frolic with some female admirers; and the local radio DJ Mambo Reaves broadcasting his thoughts over the air.",
                Duration = 83,
                Views_Count = 0
            };
            m313.Add();
            Movie m314 = new Movie()
            {
                Imdb_Id = "tt0127812",
                Title = "The Secret Dreams of Mona Q",
                Genre_Id = gen5.Id,
                Director = "Charles Kaufman",
                Poster = "http://image.tmdb.org/t/p/original//xbMMrYH2TzJFdpO25gtCCDF25cD.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/11/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "Marriage without fantasy is like life without wine. Mona Q - on the surface is a calm and proper young wife, but deep inside she\'s a hot young temptress, driven by uncontrollable urges. ...",
                Duration = 72,
                Views_Count = 0
            };
            m314.Add();
            Movie m315 = new Movie()
            {
                Imdb_Id = "tt0156246",
                Title = "11 x 14",
                Genre_Id = gen5.Id,
                Director = "James Benning",
                Poster = "http://image.tmdb.org/t/p/original//cVXd0wLBrd7aLmGIUuy4Fgde97W.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/04/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "One of the most widely praised American avant-garde films in recent years, James Benning\'s 1977 feature is a laconic mosaic of single-shot sequences, each offering some sort of image/sound pun or paradox. At once a crypto-narrative with an abstract, peekaboo storyline and a fractured, painterly study of the American midwestern landscape, 11x14 points toward the creation of a new, non-literary but populist cinema.",
                Duration = 81,
                Views_Count = 0
            };
            m315.Add();
            Movie m316 = new Movie()
            {
                Imdb_Id = "tt0076475",
                Title = "No. 1 of the Secret Service",
                Genre_Id = gen5.Id,
                Director = "Lindsay Shonteff",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "dJqgrfKMdms",
                Release_Date = DateTime.ParseExact("01/04/1978", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1978,
                Description = "No. 1 is fearless, irrestible, and licensed to kill. No. 1 is assigned to capture a madman killing international financiers. Before getting the bad guy, No. 1 encounters mercenaries from the evil organization K.R.A.S.H. (Killing, Rape, Arson, Slaughter, and Hit).",
                Duration = 91,
                Views_Count = 0
            };
            m316.Add();
            Movie m317 = new Movie()
            {
                Imdb_Id = "tt0074469",
                Title = "Captive Women 4",
                Genre_Id = gen21.Id,
                Director = "Patrice Rhomm",
                Poster = "http://image.tmdb.org/t/p/original//b7uY42nUXEsS2VI3ySVr5RBJguz.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("26/09/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "To improve the morale of the German officers, a train with beautiful girls is arranged to entertain them when on leave.",
                Duration = 90,
                Views_Count = 0
            };
            m317.Add();
            Movie m318 = new Movie()
            {
                Imdb_Id = "tt0074749",
                Title = "The Killing of a Chinese Bookie",
                Genre_Id = gen8.Id,
                Director = "John Cassavetes",
                Poster = "http://image.tmdb.org/t/p/original//71oqZMM6dgKvi1WQztOoUHSzDdZ.jpg",
                Youtube_Trailer = "GRrj60C24Y0",
                Release_Date = DateTime.ParseExact("08/10/1977", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1977,
                Description = "Cosmo Vitelli owns the Crazy Horse West, a strip joint in California. He\'s laconic, a Korean War vet, and a gambler. When we meet him, he\'s making his last payment on a gambling debt. Then, he promptly loses $23,000 playing poker at an illegal local casino. The guys he owes this time aren\'t so friendly, pressuring him for immediate payment. Then they suggest that he kill a Chinese bookie to wipe off the debt. Vitelli and the film move back and forth between the double-crossing, murderous insincerity of the gamblers and the friendships, sweetness, and even love among Vitelli, the dancers, a dancer\'s mother, and the club\'s singer, Mr. Sophistication.",
                Duration = 135,
                Views_Count = 0
            };
            m318.Add();
            Movie m319 = new Movie()
            {
                Imdb_Id = "tt3681154",
                Title = "The Mysterious House of Dr. C.",
                Genre_Id = gen12.Id,
                Director = "Ted Kneeland",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/01/1976", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1976,
                Description = "The Mysterious House of Dr. C. (1976) is a rarely seen, reworked version of the 1966 Dr. Coppelius, a dance film based on the classic 19th-century Leo Delibes ballet \"Coppelia.\"",
                Duration = 88,
                Views_Count = 0
            };
            m319.Add();
            Movie m320 = new Movie()
            {
                Imdb_Id = "tt0074113",
                Title = "Alice in Wonderland: An X-Rated Musical Fantasy",
                Genre_Id = gen5.Id,
                Director = "Bud Townsend",
                Poster = "http://image.tmdb.org/t/p/original//zCdkoCF8vIoddcCMdQRTgeOvskR.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("10/12/1976", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1976,
                Description = "Alice is a virginal librarian, cheerful and outgoing, who acts and dresses younger than her age. She rebuffs William, a suitor, because he\'s insistent on behavior she considers inappropriate: she\'s a prude. While daydreaming about reliving her life, a white rabbit taps her on the shoulder, and she follows him to Wonderland, where playful animals and people introduce her to her imagination and to pleasure. After encounters with the imperious Queen of Hearts, Alice decides that Wonderland may not be for her, and she longs for William.",
                Duration = 88,
                Views_Count = 0
            };
            m320.Add();
            Movie m321 = new Movie()
            {
                Imdb_Id = "tt0075236",
                Title = "Smash-Up on Interstate 5",
                Genre_Id = gen7.Id,
                Director = "John Llewellyn Moxey",
                Poster = "http://image.tmdb.org/t/p/original//kLX83fDURmmkpw6r10ArqcTipEq.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("03/12/1976", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1976,
                Description = "A disaster movie opening with an enormous multi-vehicle crash on a Californian highway. After the opening stunt-filled action, a flashback of the crash victims\' lives prior to and leading up to the accident. The closing replays the entire \"smash up\" from various angles and in slow motion, depicting much carnage and indifference to the victims.",
                Duration = 100,
                Views_Count = 0
            };
            m321.Add();
            Movie m322 = new Movie()
            {
                Imdb_Id = "tt0076459",
                Title = "9 Lives of a Wet Pussy",
                Genre_Id = gen13.Id,
                Director = "Abel Ferrara",
                Poster = "http://image.tmdb.org/t/p/original//pvkTsk8YtnHoWpT4ArrIhvzssal.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("20/08/1976", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1976,
                Description = "Pauline is a wealthy and married New York heiress who embarks on a series of sexual encounters with various people. She keeps in close contact with Gypsy, a tarot reader whom Pauline writes letters describing in minute detail about her conquests from seducing a French stable boy, to having sex with a gas station attendant, to a visiting Nigerian princess with a past, and to a fantasy lover, which apparently stems from her past involving a flashback sequence showing Pauline\'s young grand mother and younger sister taking a verse from the bible a little too far and seducing their own father.",
                Duration = 70,
                Views_Count = 0
            };
            m322.Add();
            Movie m323 = new Movie()
            {
                Imdb_Id = "tt0072730",
                Title = "A Boy and His Dog",
                Genre_Id = gen8.Id,
                Director = "L.Q. Jones",
                Poster = "http://image.tmdb.org/t/p/original//pTpEjMBxwxUjSkRnz3ufbtZXlcD.jpg",
                Youtube_Trailer = "AYKOFdZEK2M",
                Release_Date = DateTime.ParseExact("14/11/1975", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1975,
                Description = "A post-apocalyptic tale based on a novella by Harlan Ellison. A boy communicates telepathically with his dog as they scavenge for food and sex, and they stumble into an underground society where the old society is preserved. The daughter of one of the leaders of the community seduces and lures him below, where the citizens have become unable to reproduce because of being underground so long. They use him for impregnation purposes, and then plan to be rid of him.",
                Duration = 91,
                Views_Count = 0
            };
            m323.Add();
            Movie m324 = new Movie()
            {
                Imdb_Id = "tt0074509",
                Title = "F. Scott Fitzgerald in Hollywood",
                Genre_Id = gen8.Id,
                Director = "Anthony Page",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/05/1976", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1976,
                Description = "The story of author F. Scott Fitzgerald\'s two stays in Hollywood to write for films, once in 1927 at the height of his acclaim, and again in 1937 when he arrived with little money, enormous expenses and an ill wife.",
                Duration = 100,
                Views_Count = 0
            };
            m324.Add();
            Movie m325 = new Movie()
            {
                Imdb_Id = "tt0073659",
                Title = "Sarah T. - Portrait of a Teenage Alcoholic",
                Genre_Id = gen8.Id,
                Director = "Richard Donner",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("11/02/1975", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1975,
                Description = "Finding herself unable to cope with the divorce of her parents and the stress of daily life, 15-year-old Sarah Travis starts drinking in secret. At first, alcohol provides comfort and release. Then it sends her life spiraling out of control.",
                Duration = 96,
                Views_Count = 0
            };
            m325.Add();
            Movie m326 = new Movie()
            {
                Imdb_Id = "tt0255483",
                Title = "The Playmates in Deep Vision 3-D",
                Genre_Id = gen11.Id,
                Director = "Stephen Gibson",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/03/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "A sex researcher making a documentary about swingers can\'t find sex or love in her own life.",
                Duration = 71,
                Views_Count = 0
            };
            m326.Add();
            Movie m327 = new Movie()
            {
                Imdb_Id = "tt0071481",
                Title = "F. Scott Fitzgerald and 'The Last of the Belles'",
                Genre_Id = gen8.Id,
                Director = "George Schaefer",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "oNOLkNhHsCk",
                Release_Date = DateTime.ParseExact("07/01/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "A semi-fictional account of how writer F. Scott Fitzgerald met his wife while he was in the army and stationed in Alabama in 1919.",
                Duration = 98,
                Views_Count = 0
            };
            m327.Add();
            Movie m328 = new Movie()
            {
                Imdb_Id = "tt0071828",
                Title = "Melvin Purvis G-MAN",
                Genre_Id = gen4.Id,
                Director = "Dan Curtis",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("09/04/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "Agent Melvin Purvis is placed in charge of running down notorious killer Machine Gun Kelly, and sets out to do just that.",
                Duration = 74,
                Views_Count = 0
            };
            m328.Add();
            Movie m329 = new Movie()
            {
                Imdb_Id = "tt0072107",
                Title = "S*P*Y*S",
                Genre_Id = gen5.Id,
                Director = "Irvin Kershner",
                Poster = "http://image.tmdb.org/t/p/original//nUtTRXrdrThcIyJncEXFMjlnxAU.jpg",
                Youtube_Trailer = "03SutQhOXEY",
                Release_Date = DateTime.ParseExact("05/09/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "In 1974, flanked by such filmic monuments to paranoia and corruption as Chinatown and The Parallax View, Elliott Gould and Donald Sutherland tried to re-create the screwball nonchalance of their earlier M*A*S*H performances in this lightweight spy spoof, directed by Irvin Kershner. Gould and Sutherland play two CIA agents-Griff and Bruland-who are marked for death by their own agency after botching the defection of a Russian ballet dancer (Michael Petrovich). As they repeatedly mess up their assignments and wriggle out of tight corners, they not only find themselves pursued by the CIA, but also by the KGB, the Chinese Communists, and a terrorist group that wants to destroy the CIA.",
                Duration = 87,
                Views_Count = 0
            };
            m329.Add();
            Movie m330 = new Movie()
            {
                Imdb_Id = "tt0072386",
                Title = "W",
                Genre_Id = gen2.Id,
                Director = "Richard Quine",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/06/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "Katie Lewis and her husband Ben discover that they are the targets of a mysterious killer who leaves the letter W at the scene of their near-fatal \"accidents.\" While trying to avoid death, the couple must struggle to discover the source of these attacks.",
                Duration = 95,
                Views_Count = 0
            };
            m330.Add();
            Movie m331 = new Movie()
            {
                Imdb_Id = "tt0397022",
                Title = "6 Rms Riv Vu",
                Genre_Id = gen1.Id,
                Director = "Alan Alda, Clark Jones",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("17/03/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "Two strangers meet when they respond to an ad in The New York Times for a river view apartment. Paul Friedman is a married advertising copywriter; Ann Miller a discontented housewife. They view the apartment, but before they can leave discover that the door has accidentally been locked and they are now trapped inside together. A connection quickly forms between them as they begin sharing things about their lives, and they find themselves attracted to one another.",
                Duration = 110,
                Views_Count = 0
            };
            m331.Add();
            Movie m332 = new Movie()
            {
                Imdb_Id = "tt0072647",
                Title = "Angel Number 9",
                Genre_Id = gen8.Id,
                Director = "Roberta Findlay",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("02/07/1976", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1976,
                Description = "Heartless, despicable womanizer is reincarnated as a woman who then falls for a heartless, despicable womanizer.",
                Duration = 75,
                Views_Count = 0
            };
            m332.Add();
            Movie m333 = new Movie()
            {
                Imdb_Id = "tt0070079",
                Title = "From the Mixed-Up Files of Mrs. Basil E. Frankweiler",
                Genre_Id = gen5.Id,
                Director = "Fielder Cook",
                Poster = "http://image.tmdb.org/t/p/original//9oJCW2WHGxioXwi7EFC9jMlbYzn.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("27/09/1973", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1973,
                Description = "Pre-teen Claudia, adolescent Jamie, and infant Kevin are the three children of the Kincaids of Madison, New Jersey. Claudia is prone to flights of fancy - especially wishing that she lived the life of Lady Guinevere - out of which her father hopes she will grow. Claudia senses an opportunity when she finds in the trash an unused train pass, good for her and one other child. Needing Jamie\'s money - $24.40 which he obtained from years of gambling with a friend - but also wanting his company, Claudia convinces him to run away with her using that train pass. With Jamie controlling the money, Claudia does not divulge her complete plan to him until it happens: they will take the train into New York City and live as hideaways in the Metropolitan Museum of Art, where they can indulge in fantasies of others\' lives and worlds through the museum\'s many exhibits. Their primary tasks of getting basic necessities while evading the museum\'s security guards change when Claudia spots a sculpture of an angel in a work room, and learns the story that it was sold to the museum by a Mrs. Basil E. Frankweiler for a pittance of its probable worth, especially if the rumors that it is an authentic Michelangelo are true. To validate the reason she decided to run away, Claudia, with Jamie by her side, has to find out the truth behind the sculpture, and believes that reclusive Mrs. Frankweiler has the answers.",
                Duration = 105,
                Views_Count = 0
            };
            m333.Add();
            Movie m334 = new Movie()
            {
                Imdb_Id = "tt0070143",
                Title = "H Is for House",
                Genre_Id = gen8.Id,
                Director = "Peter Greenaway",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("25/05/1990", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1990,
                Description = "Experimental short film set in the English countryside, with strange narration which has a particular focus on objects beginning with the letter \'H\'.",
                Duration = 10,
                Views_Count = 0
            };
            m334.Add();
            Movie m335 = new Movie()
            {
                Imdb_Id = "tt0070464",
                Title = "O Lucky Man!",
                Genre_Id = gen8.Id,
                Director = "Lindsay Anderson",
                Poster = "http://image.tmdb.org/t/p/original//vWBdjLEnTcXQb5cfHEoyCxVNZko.jpg",
                Youtube_Trailer = "N_Ze68pE6rs",
                Release_Date = DateTime.ParseExact("20/06/1973", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1973,
                Description = "Follows the literal and associated life journey of middle class Brit, Mick Travis, representing the \"everyman\", as he tries to make his mark in his so far young life. He is able to make great strides in his traditional view of success by being what those in authority want him to be. As such, he achieves in a few weeks what it usually take years for others, namely having his own sales territory - the northeast and ultimately Scotland - for Imperial Coffee. He is also able to garner a plethora of fringe benefits from this job, including women throwing themselves at his feet. But he will ultimately face a struggle in class and authority warfare, which culminates with his encounter with the Burgess family - wealthy Industrialist Sir James Burgess and his daughter Patricia, who Mick wants to marry - the former who is contemplating investing in the shady dealings in Zingara. Mick will also find that the class struggle not only applies in his case in an upward direction, but also in a downward direction with the working class and the truly down and out. Through it all, Alan Price and his small combo act as a Greek chorus of sorts providing commentary of Mick\'s travails through song.",
                Duration = 178,
                Views_Count = 0
            };
            m335.Add();
            Movie m336 = new Movie()
            {
                Imdb_Id = "tt0071227",
                Title = "The Black 6",
                Genre_Id = gen8.Id,
                Director = "Matt Cimber",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("19/08/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "A black high school student is caught dating a white girl by the girl\'s brother. He and his biker gang beat the boy to death. The boy\'s brother, who is a member of a black biker gang, hears about it and comes to town to avenge his brother\'s death.",
                Duration = 94,
                Views_Count = 0
            };
            m336.Add();
            Movie m337 = new Movie()
            {
                Imdb_Id = "tt0069080",
                Title = "Pete 'n' Tillie",
                Genre_Id = gen8.Id,
                Director = "Martin Ritt",
                Poster = "http://image.tmdb.org/t/p/original//2dJyusaMWzFoEodHgGThQpypoxp.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("08/06/1973", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1973,
                Description = "Unassuming and single thirty-three year old Tillie Shlain is at that phase of her life of being known as a soon to be spinster if she doesn\'t marry soon. She isn\'t looking forward to meeting the latest in a long string of blind dates, his name being Pete Seltzer. Pete and Tillie are not a match made in heaven, he using wisecracking and constant flirtations with women to mask his own insecurities about his average looks and not wanting to deal with life head on. Despite Tillie\'s guard being up with regard to Pete, he is able slowly to chip away at her defenses. They do embark on a relationship which ends up in a straightforward and somewhat mutual declaration that they will get married despite their fundamental differences. But can their relationship survive these fundamental differences, which don\'t change during the course of their marriage, and as they deal with the terminal malignant tumor diagnosis of their nine-year old son, Robbie?",
                Duration = 100,
                Views_Count = 0
            };
            m337.Add();
            Movie m338 = new Movie()
            {
                Imdb_Id = "tt0067577",
                Title = "Pink 8 Ball",
                Genre_Id = gen5.Id,
                Director = "Gerry Chiniquy",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("06/02/1972", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1972,
                Description = "The Pink Panther is in his apartment, gift-wrapping a basketball. The ball drops through the wrapping paper to the floor, bounces out a window, and knocks a pointy-nosed, little man in a lower-level apartment off of his balcony swimming pool diving board and down to the street, where the Pink Panther catches him. The Pink Panther chases the bouncing basketball into a zoo, where an ostrich mistakes the ball for an egg and fights the panther for possession of it. The ball bounces away and becomes the plaything of two seals, with the Pink Panther trying to intercept their tossing of the ball. The ball resumes its meandering and leads the Pink Panther on a chase into the wig section of a department store, then bounces near a volleyball court and falls in love with a volleyball- but balks at marriage and returns to the Pink Panther, who resumes his chase of the elusive, bouncing ball with a mind of its own.",
                Duration = 6,
                Views_Count = 0
            };
            m338.Add();
            Movie m339 = new Movie()
            {
                Imdb_Id = "tt0066921",
                Title = "A Clockwork Orange",
                Genre_Id = gen8.Id,
                Director = "Stanley Kubrick",
                Poster = "http://image.tmdb.org/t/p/original//unMc1jEyqCnzba976GviSFKGagt.jpg",
                Youtube_Trailer = "SPRzm8ibDQ8",
                Release_Date = DateTime.ParseExact("02/02/1972", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1972,
                Description = "Protagonist Alex DeLarge is an \"ultraviolent\" youth in futuristic Britain. As with all luck, his eventually runs out and he\'s arrested and convicted of murder and rape. While in prison, Alex learns of an experimental program in which convicts are programmed to detest violence. If he goes through the program, his sentence will be reduced and he will be back on the streets sooner than expected. But Alex\'s ordeals are far from over once he hits the mean streets of Britain that he had a hand in creating.",
                Duration = 136,
                Views_Count = 0
            };
            m339.Add();
            Movie m340 = new Movie()
            {
                Imdb_Id = "tt0067258",
                Title = "J W Coop",
                Genre_Id = gen22.Id,
                Director = "Cliff Robertson",
                Poster = "http://image.tmdb.org/t/p/original//d4cqx9cCBcD2ELMN70xrONvFbYG.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/01/1972", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1972,
                Description = "After losing 9 years 9 months and thirteen days to prison, cowboy J. W. Coop is released to return to life as a professional rodeo cowboy in the 60\'s. Determined to make up for the lost \'prime\' years of his career, he doggedly goes forward, and learns that not only has the business of rodeo changed during his incarceration but society as a whole has made dramatic changes as well.",
                Duration = 112,
                Views_Count = 0
            };
            m340.Add();
            Movie m341 = new Movie()
            {
                Imdb_Id = "tt0067245",
                Title = "The Incredible 2-Headed Transplant",
                Genre_Id = gen18.Id,
                Director = "Anthony M. Lanza",
                Poster = "http://image.tmdb.org/t/p/original//izYkndfN3vZgs9E2dM8ywMZFqTb.jpg",
                Youtube_Trailer = "AOA5HEATo9k",
                Release_Date = DateTime.ParseExact("03/10/1971", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1971,
                Description = "Dr. Roger Girard is a rich scientist conducting experiments on head transplantation. His caretaker has a son, Danny, who, although fully grown, has the mind of child. One day an escaped psycho-killer invades Girard\'s home, killing Danny\'s father before being gunned down himself. With the maniac dying and Danny deeply unsettled by his father\'s death, Dr. Girard decides to take the final step and transplant the killer\'s head onto Danny\'s body. Of course, things go horribly wrong and the two-headed creature escapes to terrorize the countryside.",
                Duration = 88,
                Views_Count = 0
            };
            m341.Add();
            Movie m342 = new Movie()
            {
                Imdb_Id = "tt0067229",
                Title = "I Drink Your Blood",
                Genre_Id = gen1.Id,
                Director = "David E. Durston",
                Poster = "http://image.tmdb.org/t/p/original//7uuCr7e3ns18eaprh9ObAGvBlF2.jpg",
                Youtube_Trailer = "ydFQSU4szOM",
                Release_Date = DateTime.ParseExact("01/12/1970", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1970,
                Description = "A band of satanist hippies roll into a town and begin terrorizing the local folk. They rape a local girl and her grandpa goes after them. He fails and is given LSD. This bothers his grandson and he gets back at the hippies by feeding them meat pies infected with blood from a rabid dog. They turn into crazed lunatics and begin killing and/or infecting everything in their path.",
                Duration = 83,
                Views_Count = 0
            };
            m342.Add();
            Movie m343 = new Movie()
            {
                Imdb_Id = "tt0146398",
                Title = "4 Clowns",
                Genre_Id = gen22.Id,
                Director = "Robert Youngson",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/09/1970", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1970,
                Description = "The \"four clowns\" of this Robert Youngson anthology are: Stan Laurel, Oliver Hardy, Charley Chase and Buster Keaton. There are examples of Laurel and Hardy\'s individual work prior to their teaming; samples of Chase\'s work, including his 1928 short, \"Limousine Love\"; and an abridged version of Keaton\'s 1925 feature, \"Seven Chances.\"",
                Duration = 97,
                Views_Count = 0
            };
            m343.Add();
            Movie m344 = new Movie()
            {
                Imdb_Id = "tt0066356",
                Title = "7 Plus Seven",
                Genre_Id = gen4.Id,
                Director = "Michael Apted",
                Poster = "http://image.tmdb.org/t/p/original//gtYyD6PsXxQwxKpMLDdrQyP2U3H.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/12/1970", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1970,
                Description = "Director Michael Apted revisits the same group of British-born children after a seven-year wait. The subjects are interviewed as to the changes that have occurred in their lives during the last seven years.",
                Duration = 52,
                Views_Count = 0
            };
            m344.Add();
            Movie m345 = new Movie()
            {
                Imdb_Id = "tt0064107",
                Title = "A Boy Named Charlie Brown",
                Genre_Id = gen5.Id,
                Director = "Bill Melendez",
                Poster = "http://image.tmdb.org/t/p/original//agihHwnIadEBr6Vp2jUnHBqG2Dn.jpg",
                Youtube_Trailer = "SjIEWmqD3xc",
                Release_Date = DateTime.ParseExact("04/12/1969", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1969,
                Description = "Poor Charlie Brown. He can\'t fly a kite, and he always loses in baseball. Having his faults projected onto a screen by Lucy doesn\'t help him much either. Against the sage advice and taunting of the girls in his class, he volunteers for the class spelling bee...and wins! Next, it\'s the school spelling bee. Once again, a winner! Good grief! Now the pressure is on as he is off to New York City for the televised national spelling bee. With Snoopy and Linus present for moral support, can Charlie Brown spell his way to a national championship?",
                Duration = 86,
                Views_Count = 0
            };
            m345.Add();
            Movie m346 = new Movie()
            {
                Imdb_Id = "tt0063242",
                Title = "Love Camp 7",
                Genre_Id = gen20.Id,
                Director = "Lee Frost",
                Poster = "http://image.tmdb.org/t/p/original//kYaWkBLNrMXolUsfBnsWUW63Wss.jpg",
                Youtube_Trailer = "UXAXDbV0LNM",
                Release_Date = DateTime.ParseExact("04/10/1969", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1969,
                Description = "Set in a Nazi \"Love Camp\" that services the needs of front line officers. The video packaging claims that this film is based on fact, but the plot is so far fetched you would have a hard time believing that. Two young WAC officers go undercover as POW\'s in the prison camp hoping to get some information from a scientist that\'s being held there, before being sprung out by the French resistance. Unfortunately things go wrong with the break out and they end up overstaying their welcome and being subjected to the same indignities as the other inmates.",
                Duration = 96,
                Views_Count = 0
            };
            m346.Add();
            Movie m347 = new Movie()
            {
                Imdb_Id = "tt0064231",
                Title = "The Devil's 8",
                Genre_Id = gen6.Id,
                Director = "Burt Topper",
                Poster = "http://image.tmdb.org/t/p/original//kOhABhG7Ic5FBB4xjpPJIIwzUsO.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/04/1970", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1970,
                Description = "A federal agent rounds up eight convicts to help fight a vicious moonshine gang.",
                Duration = 98,
                Views_Count = 0
            };
            m347.Add();
            Movie m348 = new Movie()
            {
                Imdb_Id = "tt0062683",
                Title = "Assignment K",
                Genre_Id = gen6.Id,
                Director = "Val Guest",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/06/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "Philip Scott, head of a successful toy company, is also secretly the head of a British spy unit. When his cover is blown, enemy agents kidnap his girlfriend to force him to reveal the identities of his operatives.",
                Duration = 97,
                Views_Count = 0
            };
            m348.Add();
            Movie m349 = new Movie()
            {
                Imdb_Id = "tt0063655",
                Title = "Submarine X-1",
                Genre_Id = gen8.Id,
                Director = "William A. Graham",
                Poster = "http://image.tmdb.org/t/p/original//5IuClABw2auHcFOqB3BssoCFxgw.jpg",
                Youtube_Trailer = "WaZ88lMA1mk",
                Release_Date = DateTime.ParseExact("22/03/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "During World War II, the British Royal Navy used experimental midget submarines to raid German warships in Norway.",
                Duration = 89,
                Views_Count = 0
            };
            m349.Add();
            Movie m350 = new Movie()
            {
                Imdb_Id = "tt0062624",
                Title = "3 Ring Wing-Ding",
                Genre_Id = gen3.Id,
                Director = "Alex Lovy",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/08/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "English Colonel Rimfire reads that a circus offers $1000 for a live tiger. Rimfire decides to deliver Cool Cat, the hip tiger, to the circus and collect the money, but Cool Cat won\'t cooperate with Rimfire and leads the Colonel on a chase, straight into the circus, where the Colonel is clobbered for not having an admission ticket. After paying for a ticket and gaining legitimate entry into the big top, Rimfire chases Cool Cat through all the circus acts, including the Indian Snake Charmer, the trained seal, the human cannon ball, the fire eater, and the high wire.",
                Duration = 6,
                Views_Count = 0
            };
            m350.Add();
            Movie m351 = new Movie()
            {
                Imdb_Id = "tt0062503",
                Title = "Work Is a 4-Letter Word",
                Genre_Id = gen10.Id,
                Director = "Peter Hall",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("25/09/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "Everyone is employed by the ultra-modern DICE Corporation but Valentine Brose would rather stay at home to tend his psychedelic mushrooms.",
                Duration = 93,
                Views_Count = 0
            };
            m351.Add();
            Movie m352 = new Movie()
            {
                Imdb_Id = "tt0062626",
                Title = "5 Card Stud",
                Genre_Id = gen17.Id,
                Director = "Henry Hathaway",
                Poster = "http://image.tmdb.org/t/p/original//jIITeVoAHbuj8Ib5n4yZrdHwQAZ.jpg",
                Youtube_Trailer = "0NFRsdAtPwE",
                Release_Date = DateTime.ParseExact("22/11/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "After a card shark is caught cheating, he is taken out and lynched by the drunkards he was playing against. Soon afterwards, the men who were in the lynch mob start being murdered, one after another; all by hanging, strangling, or smothering. Who will be killed next and who is responsible? Is it one of the original party seeking to cover their accursed deed, or perhaps the mysterious Rev. Jonathan Rudd, who has recently arrived in town?",
                Duration = 103,
                Views_Count = 0
            };
            m352.Add();
            Movie m353 = new Movie()
            {
                Imdb_Id = "tt0063694",
                Title = "Thunderbird 6",
                Genre_Id = gen18.Id,
                Director = "David Lane",
                Poster = "http://image.tmdb.org/t/p/original//y7QwpuyJIRf8O6NiraZIAgUD776.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("20/11/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "The International Rescue team is faced with one of its toughest challenges yet, as the revolutionary lighter-than-air craft Skyship One is hijacked while on her maiden voyage around the world. Against backdrops including the Statue of Liberty and the Sphinx, Lady Penelope, Parker, Alan and Tin-Tin fight the hijackers from on-board, while the rest of the team tries to stop the airship crashing into a missile silo.",
                Duration = 89,
                Views_Count = 0
            };
            m353.Add();
            Movie m354 = new Movie()
            {
                Imdb_Id = "tt0062209",
                Title = "Rock 'n' Rodent",
                Genre_Id = gen5.Id,
                Director = "Abe Levitow",
                Poster = "http://image.tmdb.org/t/p/original//g6Grp85S2yZLqLTa1qKdkEsCS4w.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("07/04/1967", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1967,
                Description = "Jerry heads out to his night job: drummer for an all-mouse rock band in the basement of a high-rise. They are loud enough to wake up Tom, despite his attempts to block the noise. Tom\'s attempts keep running him afoul of a rather mean-tempered dog.",
                Duration = 6,
                Views_Count = 0
            };
            m354.Add();
            Movie m355 = new Movie()
            {
                Imdb_Id = "tt0061956",
                Title = "Maroc 7",
                Genre_Id = gen8.Id,
                Director = "Gerry O'Hara",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/01/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "The lady of a top fashion magazine doubles as a jewel thief and becomes involved in Moroccan intrigue.",
                Duration = 91,
                Views_Count = 0
            };
            m355.Add();
            Movie m356 = new Movie()
            {
                Imdb_Id = "tt0124666",
                Title = "The Girls on F Street",
                Genre_Id = gen8.Id,
                Director = "Saul Resnick",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("04/09/1974", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1974,
                Description = "A pathetic Joe (Nick Nickerson) pays a bitter prostitute, Margo (Althea Curier) to have sex with him, and is abused endlessly. A woman sculptor and her live model try to suppress their lesbian longings for each other. Lonely, bespectacled middle-aged Nick (Ken McCormick) goes to the House of Fetish - the local brothel - after watching a buxom stripper (Eve St. Pierre) do her exotic dance on stage. His wife catches him in bed with another woman, and whips her silly...",
                Duration = 69,
                Views_Count = 0
            };
            m356.Add();
            Movie m357 = new Movie()
            {
                Imdb_Id = "tt0060186",
                Title = "Boy, Did I Get a Wrong Number!",
                Genre_Id = gen1.Id,
                Director = "George Marshall",
                Poster = "http://image.tmdb.org/t/p/original//rysGHe65LF3cdmeibH2kCkozjaR.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("08/06/1966", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1966,
                Description = "The Divine Didi, a European actress known more for her bubble bath scenes than for her acting, decides she has had enough with bubble baths and wants to be taken seriously as an actress. So much so that she runs away during the middle of a scene while filming in Hollywood and winds up in Oregon. While she is staying in a hotel, the operator accidentally connects her with a real estate agent named Tom Meade. She asks Tom to bring her some food and when he does he suggests that she go to his cabin in the woods. She also asks him not to tell anyone where she is because she doesn\'t want to go back to Hollywood. Now Tom must keep the secret, especially from his wife and from his suspicious housekeeper Millie.",
                Duration = 99,
                Views_Count = 0
            };
            m357.Add();
            Movie m358 = new Movie()
            {
                Imdb_Id = "tt0060869",
                Title = "Puss 'N' Boats",
                Genre_Id = gen9.Id,
                Director = "Abe Levitow",
                Poster = "http://image.tmdb.org/t/p/original//arfizeYSsNoRj0iuhCQGw397rFr.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("05/05/1966", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1966,
                Description = "A scent--which looks like a trail of vapor with a hand at the end of it--caresses Jerry as he sleeps on the wharf. It seductively leads Jerry to its source: a crate full of fromage, queso--cheese! Jerry rashly runs toward the cheese, as it is being pulled onto a cargo ship. But the scent holds out its hand to stop him. Watch out, it\'s telling him. And then it jerks its thumb toward Tom, the cat who is guarding the ship. Now Jerry is determined to sneak aboard, and Tom is determined to keep him on shore. The captain blithely walks about as this drama unfolds. But a shark off the pier is paying more attention. Either Tom or Jerry would make an excellent meal.",
                Duration = 6,
                Views_Count = 0
            };
            m358.Add();
            Movie m359 = new Movie()
            {
                Imdb_Id = "tt0060311",
                Title = "Dimension 5",
                Genre_Id = gen18.Id,
                Director = "Franklin Adreon",
                Poster = "http://image.tmdb.org/t/p/original//nHL9F3y01keMM9cjJKBhcOFSMSJ.jpg",
                Youtube_Trailer = "_ZkkaQeIWAI",
                Release_Date = DateTime.ParseExact("01/10/1966", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1966,
                Description = "The unofficial agency of the American government Espionage Corporation is assigned to investigate the Chinese organization The Dragons when the government is advised to remove the American troops from Asia, otherwise The Dragons would destroy Los Angeles with a Hydrogen Bomb. The chief Mr. Kane asks his best agent Justin Power, who is testing a time converter belt, to be in charge of the mission with the Chinese agent Ki Ti Tso, aka Kitty. The intelligence agency unravels that parts of the bomb has been imported by the smuggler Big Buddha and Power and Kitty seek the hidden place in USA.",
                Duration = 91,
                Views_Count = 0
            };
            m359.Add();
            Movie m360 = new Movie()
            {
                Imdb_Id = "tt0059377",
                Title = "Lady L",
                Genre_Id = gen4.Id,
                Director = "Peter Ustinov",
                Poster = "http://image.tmdb.org/t/p/original//yjwyErNh28TL72fZ4myE04enqao.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("17/12/1965", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1965,
                Description = "Today Lady Louise Lendale is 80 years old and she tells her long time admirer, British poet Sir Percy, all about her eventful life. In the beginning, she was a young laundress working in \"Le Mouton Bleu\", a renowned Paris whorehouse. There, she met Armand, both a charming man and a bomb-throwing anarchist, and it wasn\'t long before she became his mistress. One day while Armand was away in Switzeland, working for a revolutionary movement aiming to murder a Russian prince, Louise met the second man in her life,, a British Lord she soon called Dicky. The latter offered to marry her. In exchange, he would save Armand from the police\'s grip. She accepted on the condition she could still see Armand...",
                Duration = 117,
                Views_Count = 0
            };
            m360.Add();
            Movie m361 = new Movie()
            {
                Imdb_Id = "tt0059102",
                Title = "Dial 'P' for Pink",
                Genre_Id = gen5.Id,
                Director = "Friz Freleng, Hawley Pratt(co-director)",
                Poster = "http://image.tmdb.org/t/p/original//eS84TX4WWbjJT7Xp0TvbKHGxuxO.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("17/03/1965", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1965,
                Description = "A short, pointy-nosed safecracker intends to rob a safe in a building, but he doesn\'t realize that the safe is occupied by the Pink Panther, who has made the safe his home. When the ...",
                Duration = 6,
                Views_Count = 0
            };
            m361.Add();
            Movie m362 = new Movie()
            {
                Imdb_Id = "tt0059744",
                Title = "Spaceflight IC-1: An Adventure in Space",
                Genre_Id = gen6.Id,
                Director = "Bernard Knowles",
                Poster = "http://image.tmdb.org/t/p/original//fQFl5sHIbwGCKiLI2ymbpmgkEmF.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/10/1965", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1965,
                Description = "In the year 2015, a spaceship, the IC-1, travels through outer space looking for a suitable planet to settle on. The commander, Captain Ralston, is stern and brutal in which one cadet, Steven, plots a revolt to turn the leadership of the command over to him.",
                Duration = 65,
                Views_Count = 0
            };
            m362.Add();
            Movie m363 = new Movie()
            {
                Imdb_Id = "tt0059681",
                Title = "Saul e David",
                Genre_Id = gen8.Id,
                Director = "Marcello Baldi",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/06/1968", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1968,
                Description = "David of Bethlehem slays the giant and becomes a rival to King Saul.",
                Duration = 105,
                Views_Count = 0
            };
            m363.Add();
            Movie m364 = new Movie()
            {
                Imdb_Id = "tt0059282",
                Title = "Agent 8 3/4",
                Genre_Id = gen12.Id,
                Director = "Ralph Thomas",
                Poster = "http://image.tmdb.org/t/p/original//n7rmQ1lZScTQ0PFonGb8RbimND8.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("18/09/1964", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1964,
                Description = "Unemployed Czech-speaking writer Nicholas Whistler thinks he\'s got a job visiting Prague for a bit of industrial espionage. In fact he is now in the employ of British Intelligence. His pretty chauffeuse on arrival behind the Iron Curtain, Comrade Simonova, is herself a Czech agent. Just as well she\'s immediately attracted to 007\'s unwitting replacement.",
                Duration = 98,
                Views_Count = 0
            };
            m364.Add();
            Movie m365 = new Movie()
            {
                Imdb_Id = "tt0058632",
                Title = "Code 7, Victim 5",
                Genre_Id = gen2.Id,
                Director = "Robert Lynn",
                Poster = "http://image.tmdb.org/t/p/original//lYXgRhkwTA8v1QiFsGVgSBxCrIK.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("10/07/1964", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1964,
                Description = "When a millionaires valet is murdered he hires a detective to discover by who and why his valet was killed, leading to connections of the nazi sort!",
                Duration = 89,
                Views_Count = 0
            };
            m365.Add();
            Movie m366 = new Movie()
            {
                Imdb_Id = "tt0058529",
                Title = "Robin and the 7 Hoods",
                Genre_Id = gen6.Id,
                Director = "Gordon Douglas",
                Poster = "http://image.tmdb.org/t/p/original//gFWAQnvPGVU8MLj37tFcZTvSLEX.jpg",
                Youtube_Trailer = "JRpsNchGxL4",
                Release_Date = DateTime.ParseExact("24/06/1964", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1964,
                Description = "In prohibition-era Chicago, the corrupt sheriff and Guy Gisborne, a south-side racketeer, knock off the boss Big Jim. Everyone falls in line behind Guy except Robbo, who controls the north side. Although he\'s outgunned, Robbo wants to keep his own territory. A pool-playing dude from Indiana and the director of a boys\' orphanage join forces with Robbo; and, when he gives some money to the orphanage, he becomes the toast of the town as a hood like Robin Hood. Meanwhile, Guy schemes to get rid of Robbo, and Big Jim\'s heretofore unknown daughter Marian appears and goes from man to man trying to find an ally in her quest to run the whole show. Can Robbo hold things together?",
                Duration = 123,
                Views_Count = 0
            };
            m366.Add();
            Movie m367 = new Movie()
            {
                Imdb_Id = "tt0057193",
                Title = "It's a Mad Mad Mad Mad World",
                Genre_Id = gen2.Id,
                Director = "Stanley Kramer",
                Poster = "http://image.tmdb.org/t/p/original//jvR2MRGQXQ2bHrJm0gtBJ85kZqN.jpg",
                Youtube_Trailer = "Sla845GW9YM",
                Release_Date = DateTime.ParseExact("03/12/1963", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1963,
                Description = "After a long prison sentence Smiler Grogan is heading at high speed to a California park where he hid $350,000 from a job 15 years previously. He accidentally careens over a cliff in view of four cars whose occupants go down to help. The dying Grogan gives details of where the money is buried and when the witnesses fail to agree on sharing the cash, a crazy chase develops across the state.",
                Duration = 205,
                Views_Count = 0
            };
            m367.Add();
            Movie m368 = new Movie()
            {
                Imdb_Id = "tt0057634",
                Title = "The V.I.P.s",
                Genre_Id = gen15.Id,
                Director = "Anthony Asquith",
                Poster = "http://image.tmdb.org/t/p/original//xBvg3bAQoW0va81mKhgyvo7yqt6.jpg",
                Youtube_Trailer = "dC3JZoYhGmA",
                Release_Date = DateTime.ParseExact("19/09/1963", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1963,
                Description = "Awaiting at London Airport for a flight to New York, Frances Andros, seen off by her tycoon husband, Paul Andros, plans to leave her spouse for the arms of an aging international playboy, Marc Champselle. Les Mangrum, a self-made Australian businessman traveling with his loyal secretary, Miss Mead, must be in New York the following day to arrange the loan that will help him repel a hostile takeover of his tractor company. Max Buba, a film mogul traveling with starlet Gloria Gritti, must get out of England immediately or face ruinous British income tax. The Duchess of Brighton has taken a job as a hostess at an American holiday resort, thinking she will be able to keep her family estate on her new income. Fog descends and blurs the future for them all, forced now to wait in the airport hotel for morning and fair weather.",
                Duration = 119,
                Views_Count = 0
            };
            m368.Add();
            Movie m369 = new Movie()
            {
                Imdb_Id = "tt0056880",
                Title = "Boin-n-g",
                Genre_Id = gen4.Id,
                Director = "Herschell Gordon Lewis",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("18/04/1963", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1963,
                Description = "An inexperienced producer and director audition and film naked women for a nudie movie. Everything goes wrong.",
                Duration = 70,
                Views_Count = 0
            };
            m369.Add();
            Movie m370 = new Movie()
            {
                Imdb_Id = "tt0057693",
                Title = "X: The Man with the X-Ray Eyes",
                Genre_Id = gen18.Id,
                Director = "Roger Corman",
                Poster = "http://image.tmdb.org/t/p/original//b8cZvjNIQ1nhYibnRWMKiG8Gs5o.jpg",
                Youtube_Trailer = "4clwgHEOYMo",
                Release_Date = DateTime.ParseExact("20/04/1965", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1965,
                Description = "Dr. James Xavier is a world renowned scientist experimenting with human eyesight. He devises a drug, that when applied to the eyes, enables the user to see beyond the normal realm of our sight (ultraviolet rays etc.) it also gives the user the power to see through objects. Xavier tests this drug on himself, when his funding is cut off. As he continues to test the drug on himself, Xavier begins to see, not only through walls and clothes, but through the very fabric of reality!",
                Duration = 79,
                Views_Count = 0
            };
            m370.Add();
            Movie m371 = new Movie()
            {
                Imdb_Id = "tt0057071",
                Title = "4 for Texas",
                Genre_Id = gen22.Id,
                Director = "Robert Aldrich",
                Poster = "http://image.tmdb.org/t/p/original//wDdbtHUx3QywTDpNPz1vuY21nw6.jpg",
                Youtube_Trailer = "EMbP1jrGCQA",
                Release_Date = DateTime.ParseExact("25/12/1963", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1963,
                Description = "Sharpshooters Zack Thomas and Joe Jarrett are in a Texan stage-coach and manage to fight off Matson\'s robber gang, so afterward they can fight over the $100,000 cash carried by a railroad official. Both make it to Galveston, where each, including vexed Matson, meets up with respective accomplices in various dirty schemes. The money keeps changing hands and the scene shifts to a river boat, which should multiply the winnings as a casino, but the crooks and bullets follow.",
                Duration = 124,
                Views_Count = 0
            };
            m371.Add();
            Movie m372 = new Movie()
            {
                Imdb_Id = "tt0057600",
                Title = "Transylvania 6-5000",
                Genre_Id = gen5.Id,
                Director = "Chuck Jones, Maurice Noble(co-director)",
                Poster = "http://image.tmdb.org/t/p/original//kL08WWNShLHqskTyIB4ApzJzSih.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("30/11/1963", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1963,
                Description = "After getting lost on his vacation, Bugs ends up in the middle of Transylvania. He decides to get a room for the night in a nearby castle, which of course turns out to be home to a vampire. The bloodsucker is looking to make Bugs his next meal, but the bunny has a few tricks, as well as a few magic words, up his sleeve.",
                Duration = 7,
                Views_Count = 0
            };
            m372.Add();
            Movie m373 = new Movie()
            {
                Imdb_Id = "tt0056592",
                Title = "To Kill a Mockingbird",
                Genre_Id = gen8.Id,
                Director = "Robert Mulligan",
                Poster = "http://image.tmdb.org/t/p/original//eb8EqwtFWVoujlbU8CmaEYc1qE5.jpg",
                Youtube_Trailer = "zPcH6joLZjg",
                Release_Date = DateTime.ParseExact("16/03/1963", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1963,
                Description = "Small-town Alabama, 1932. Atticus Finch (played by Gregory Peck) is a lawyer and a widower. He has two young children, Jem and Scout. Atticus Finch is currently defending Tom Robinson, a black man accused of raping a white woman. Meanwhile, Jem and Scout are intrigued by their neighbours, the Radleys, and the mysterious, seldom-seen Boo Radley in particular.",
                Duration = 129,
                Views_Count = 0
            };
            m373.Add();
            Movie m374 = new Movie()
            {
                Imdb_Id = "tt0058025",
                Title = "Dog Star Man: Part I",
                Genre_Id = gen4.Id,
                Director = "Stan Brakhage",
                Poster = "http://image.tmdb.org/t/p/original//3Z8ytP2hoyCAhwYFTFm3nTQ6oFg.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("09/03/2004", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 2004,
                Description = "From a murky landscape, a wooded mountain emerges. We watch the sun. We see a bearded man climbing up the mountain through the snow. He carries an ax, and he\'s accompanied by a dog. His labors continue. There is no soundtrack. Images rush past - water, trees, and surfaces too close up to distinguish. He struggles. A fire burns. Nature, in long shots and magnified, is formidable and silent. It\'s tough going; he carries on. In a capillary, blood flows.",
                Duration = 30,
                Views_Count = 0
            };
            m374.Add();
            Movie m375 = new Movie()
            {
                Imdb_Id = "tt0057239",
                Title = "The L-Shaped Room",
                Genre_Id = gen17.Id,
                Director = "Bryan Forbes",
                Poster = "http://image.tmdb.org/t/p/original//kH4MEGd9pECI27pKq5NkohGu2xD.jpg",
                Youtube_Trailer = "UlFaQ8D-Obk",
                Release_Date = DateTime.ParseExact("20/11/1962", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1962,
                Description = "Jane, a young French woman, pregnant and unmarried, takes a room in a seedy London boarding house, which is inhabited by an assortment of misfits. She considers getting an abortion, but is unhappy with this solution. She falls into a relationship with Toby, a struggling young writer who lives on the first floor. Eventually she comes to like her odd room, and makes friends with all the strange people in the house. But she still faces two problems: what to do with her baby, and what to do with Toby.",
                Duration = 126,
                Views_Count = 0
            };
            m375.Add();
            Movie m376 = new Movie()
            {
                Imdb_Id = "tt0056470",
                Title = "Sergeants 3",
                Genre_Id = gen22.Id,
                Director = "John Sturges",
                Poster = "http://image.tmdb.org/t/p/original//70Hy7rrDqO2UwgcAn0jZ54P5RjZ.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("10/02/1962", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1962,
                Description = "Three cavalry officers and a bugler work together to thwart a Native American chief intent on uniting local tribes against the white man.",
                Duration = 112,
                Views_Count = 0
            };
            m376.Add();
            Movie m377 = new Movie()
            {
                Imdb_Id = "tt0055868",
                Title = "Convicts 4",
                Genre_Id = gen8.Id,
                Director = "Millard Kaufman",
                Poster = "http://image.tmdb.org/t/p/original//ktV0onv0MRwc2LnlipFtqPTXiM9.jpg",
                Youtube_Trailer = "fAbXQFRdfRM",
                Release_Date = DateTime.ParseExact("07/02/1963", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1963,
                Description = "A semi-fictionalized version of John Resko\'s incarceration is presented. John is on death row at Sing Sing for murder. In December 1930, he killed a toy store shopkeeper over a teddy bear he wanted to get as a Christmas present for his two year old daughter, Cathy, but for which he could not pay. Twenty minutes before John\'s scheduled execution, he is given a reprieve, his sentence commuted to life, and he transferred to Dannemora. He initially has a difficult time adjusting to life at Dannemora, from the uncaring direction of the prison administration including they not dealing with the issue of bed bugs, to altercations with fellow prisoners who seem to want their two pounds of literal and figurative flesh from John, to news that he receives from the outside about goings-on within his family. However, he does eventually befriend many of his fellow prisoners, especially Nick, Iggy and Wino. John dreams of escaping from Dannemora, so that he can be at least an economically generating father for Cathy, even if she may not want to resume a life with him. But one of the principals at the prison may have a way to get prisoners like John out of the system, by giving them creative outlets to show parole boards what is in their innermost thoughts. He wants to nurture what seems to be John\'s artistic abilities. Although John initially balks at the idea of art as an outlet, he does eventually get a passion for it, which leads to an outcome not expected by either the principal or John.",
                Duration = 105,
                Views_Count = 0
            };
            m377.Add();
            Movie m378 = new Movie()
            {
                Imdb_Id = "tt0054779",
                Title = "D' Fightin' Ones",
                Genre_Id = gen3.Id,
                Director = "Friz Freleng",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("22/04/1961", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1961,
                Description = "Sylvester Cat and a scrawny bulldog escape from a truck headed for the city animal pound and make like convicts on the lam.",
                Duration = 6,
                Views_Count = 0
            };
            m378.Add();
            Movie m379 = new Movie()
            {
                Imdb_Id = "tt0055637",
                Title = "Zip 'N Snort",
                Genre_Id = gen9.Id,
                Director = "Chuck Jones",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("21/01/1961", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1961,
                Description = "Wile E. Coyote tries to catch the Road Runner using a sling shot, a grenade in a toy airplane whose propeller detaches and leaves the plane behind, a cannon on a cliff ledge that gives way, and axle grease on his feet that sends him into the path of a train driven by the Road Runner.",
                Duration = 6,
                Views_Count = 0
            };
            m379.Add();
            Movie m380 = new Movie()
            {
                Imdb_Id = "tt0055627",
                Title = "X-15",
                Genre_Id = gen12.Id,
                Director = "Richard Donner",
                Poster = "http://image.tmdb.org/t/p/original//nkcTMZaFczZcyD25uvIe3b8cSVr.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("22/12/1961", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1961,
                Description = "At the height of the Cold War during the 1960s the U.S. Air Force and NASA tested an experimental rocket-powered research aircraft code-named X-15.The X-15 experiments were conducted at Edwards Air Force Base.The X-15 aircraft set altitude and speed records by reaching the edge of outer space.The project is managed by U.S. Air Force Colonel Craig Brewster and scientist Tom Deparma. The main test pilots are Matt Powell, Colonel Lee Brandon and Major Ernest Wilde.During the test flights the X-15 aircraft is dropped from a B-52 Stratofortress mother ship before starting its engine.The whole test team is enthusiastic about the project but the project is plagued by setbacks and near disasters right from the start.",
                Duration = 107,
                Views_Count = 0
            };
            m380.Add();
            Movie m381 = new Movie()
            {
                Imdb_Id = "tt0053882",
                Title = "The 3 Worlds of Gulliver",
                Genre_Id = gen9.Id,
                Director = "Jack Sher",
                Poster = "http://image.tmdb.org/t/p/original//5jZvKR1VJstitfks3jG78fHkxQN.jpg",
                Youtube_Trailer = "bxi6yZoyVk0",
                Release_Date = DateTime.ParseExact("01/12/1960", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1960,
                Description = "Doctor Gulliver is poor, so nothing - not even his charming fiancée Elisabeth - keeps him in the town he lives. He signs on to a ship to India, but in a storm he\'s washed off the ship and ends up on an island, which is inhibitated by very tiny people. After he managed to convince them he\'s harmless and is accepted as one of their citizens, their king wants to use him in war against a people of giants. Compared to them, even Gulliver is a gnome.",
                Duration = 99,
                Views_Count = 0
            };
            m381.Add();
            Movie m382 = new Movie()
            {
                Imdb_Id = "tt0053622",
                Title = "BUtterfield 8",
                Genre_Id = gen8.Id,
                Director = "Daniel Mann",
                Poster = "http://image.tmdb.org/t/p/original//eoQqz9mmQ3UBJyPvhLXs0BIEN2e.jpg",
                Youtube_Trailer = "FH0xqOJyycI",
                Release_Date = DateTime.ParseExact("04/11/1960", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1960,
                Description = "Beautiful Gloria Wandrous, a New York fashion model engages in an illicit affair with married socialite Weston Liggett. However, Gloria\'s desire for respectability causes her to reconsider her lifestyle.",
                Duration = 109,
                Views_Count = 0
            };
            m382.Add();
            Movie m383 = new Movie()
            {
                Imdb_Id = "tt0052561",
                Title = "Anatomy of a Murder",
                Genre_Id = gen8.Id,
                Director = "Otto Preminger",
                Poster = "http://image.tmdb.org/t/p/original//aFfbSVwzXH5tCi5MQN0idkoFbk0.jpg",
                Youtube_Trailer = "fMCt7fyjqO0",
                Release_Date = DateTime.ParseExact("01/09/1959", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1959,
                Description = "Frederick Manion (Ben Gazzara), a lieutenant in the army, is arrested for the murder of a bartender, Barney Quill. He claims, in his defense, that the victim had raped and beaten up his wife Laura (Lee Remick). Although Laura supports her husband\'s story, the police surgeon can find no evidence that she has been raped. Manion is defended by Paul Biegler (James Stewart), a rather humble small-town lawyer. During the course of interviews, Biegler discovers that Manion is violently possessive and jealous, and also that his wife has a reputation for giving her favors to other men. Biegler realizes that the prosecution will try to make the court believe that Laura was the lover of the bartender and than Manion killed him and beat her up when he discovered them together. Manion pleads \"not guilty\" and Biegler, who knows that his case is weak, sets his assistants to try to find a witness who will save Manion.",
                Duration = 160,
                Views_Count = 0
            };
            m383.Add();
            Movie m384 = new Movie()
            {
                Imdb_Id = "tt0163315",
                Title = "T-Bird Gang",
                Genre_Id = gen20.Id,
                Director = "Richard Harbinger",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/10/1959", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1959,
                Description = "A high school boy, out to find his father\'s killer, joins up with a gang of juvenile delinquents.",
                Duration = 65,
                Views_Count = 0
            };
            m384.Add();
            Movie m385 = new Movie()
            {
                Imdb_Id = "tt0053169",
                Title = "Pier 5, Havana",
                Genre_Id = gen1.Id,
                Director = "Edward L. Cahn",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/10/1959", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1959,
                Description = "A Yank comes to Havana in search of an old friend who disappeared during the Cuban Revolution, and discovers a group of Batista sympathizers plotting to overturn Castro.",
                Duration = 67,
                Views_Count = 0
            };
            m385.Add();
            Movie m386 = new Movie()
            {
                Imdb_Id = "tt0052077",
                Title = "Plan 9 from Outer Space",
                Genre_Id = gen18.Id,
                Director = "Edward D. Wood Jr.",
                Poster = "http://image.tmdb.org/t/p/original//3BKq4edzOFB4vOAHltrnXUPVztW.jpg",
                Youtube_Trailer = "XEoOb1Pmgfw",
                Release_Date = DateTime.ParseExact("22/07/1959", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1959,
                Description = "In California, an old man (Bela Lugosi) grieves the loss of his wife (Vampira) and on the next day he also dies. However, the space soldier Eros and her mate Tanna use an electric device to resurrect them both and the strong Inspector Clay (Tor Johnson) that was murdered by the couple. Their intention is not to conquer Earth but to stop mankind from developing the powerful bomb \"Solobonite\" that would threaten the universe. When the population of Hollywood and Washington DC sees flying saucers on the sky, a colonel, a police lieutenant, a commercial pilot, his wife and a policeman try to stop the aliens.",
                Duration = 79,
                Views_Count = 0
            };
            m386.Add();
            Movie m387 = new Movie()
            {
                Imdb_Id = "tt0051459",
                Title = "Cat on a Hot Tin Roof",
                Genre_Id = gen9.Id,
                Director = "Richard Brooks",
                Poster = "http://image.tmdb.org/t/p/original//wm7TBeMeuomoXW4kkDnsY2Na8pW.jpg",
                Youtube_Trailer = "rDk0JtQHc0A",
                Release_Date = DateTime.ParseExact("29/08/1958", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1958,
                Description = "The family of \"Big Daddy\" Pollitt convenes at his and Big Momma\'s vast 28,000 acre East Mississippi plantation for his sixty-fifth birthday, although it may as well be for his funeral on the belief that he is dying. Despite his latest medical report being clean, in reality he truly does have terminal colon cancer, something the doctor only tells Big Daddy\'s two sons, Gooper Pollitt, a lawyer, and Brick Pollitt, who recently left his job as a sportscaster. Brooding Brick and his wife Maggie Pollitt, who have driven up from New Orleans for the occasion, are going through a long rough patch in their marriage. Brick wanted to split, but Maggie convinced him to stay married on the condition that she not pressure him for sex. In their troubles, Brick has turned to the bottle, leading to a drunken incident which has left Brick currently on crutches. Maggie believes Gooper and his wife Mae Pollitt are trying to orchestrate Brick out of Big Daddy\'s will. Brick and Maggie\'s saving grace is Big Daddy has greater affinity for them than Gooper and Mae. Maggie is beautiful and Brick was a star athlete, specifically in football and track. As Gooper and Mae have a sixth child on the way, Maggie also believes they could combat anything Gooper and Mae could do by having a child of their own. In his current state, Brick has contempt for everyone and everything around him, which includes Big Daddy\'s money. All Brick and Maggie\'s problems seem to center on their respective relationships with Brick\'s high school friend and football partner, Skipper, and events in their lives just prior to Skipper\'s death. What happens not only with Brick and Maggie but the entire Pollitt family may depend on if Brick can reconcile himself with his life, much of which is currently in Big Daddy\'s house, including Maggie.",
                Duration = 108,
                Views_Count = 0
            };
            m387.Add();
            Movie m388 = new Movie()
            {
                Imdb_Id = "tt0051758",
                Title = "I Want to Live!",
                Genre_Id = gen6.Id,
                Director = "Robert Wise",
                Poster = "http://image.tmdb.org/t/p/original//cG0u5sdK1rA1BWGb7dxg43Recgz.jpg",
                Youtube_Trailer = "X_iQdDy3tr0",
                Release_Date = DateTime.ParseExact("03/12/1958", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1958,
                Description = "Barbara Graham is a woman with dubious moral standards, often a guest in seedy bars. She has been sentenced for some petty crimes. Two men she knows murder an older woman. When they get caught they start to think that Barbara has helped the police to arrest them. As a revenge they tell the police that Barbara is the murderer.",
                Duration = 120,
                Views_Count = 0
            };
            m388.Add();
            Movie m389 = new Movie()
            {
                Imdb_Id = "tt0052719",
                Title = "Daddy-O",
                Genre_Id = gen14.Id,
                Director = "Lou Place",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/03/1958", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1958,
                Description = "Phil, a part-time truck driver and singer who wears his pants far too high, meets a feisty platinum blonde who challenges him to a drag race through Griffith Park. When he is caught and loses his license, he meets up with the sketchy Frank Wooster who offers him a job singing in his new nightclub. When Phil discovers that his new job also includes drug running, he must fight to save his friends and himself.",
                Duration = 74,
                Views_Count = 0
            };
            m389.Add();
            Movie m390 = new Movie()
            {
                Imdb_Id = "tt0051020",
                Title = "The Strange World of Planet X",
                Genre_Id = gen13.Id,
                Director = "Gilbert Gunn",
                Poster = "http://image.tmdb.org/t/p/original//qAsiUbtrYfO2ToiO17gi92cF1ZX.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("31/12/1958", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1958,
                Description = "At a small, rural British lab, monomaniac Dr. Laird and his staff create ultra-intense magnetic fields. Inexplicably, the apparatus seems to be affecting distant objects, and to be drawing \"extra power\" from...somewhere. One night, after a \"freak\" storm, strange and deadly things start happening in Bryerly Woods, and a strange man from \"a long way off\" appears in the district...concerned about Laird\'s pulling down disaster from the skies.",
                Duration = 75,
                Views_Count = 0
            };
            m390.Add();
            Movie m391 = new Movie()
            {
                Imdb_Id = "tt0263015",
                Title = "4 Artists Paint 1 Tree: A Walt Disney 'Adventure in Art'",
                Genre_Id = gen6.Id,
                Director = "Wilfred Jackson, Charles A. Nichols",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("30/04/1958", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1958,
                Description = "Four Disney artists paint their own interpretations of a tree, and explain their techniques and methods.",
                Duration = 16,
                Views_Count = 0
            };
            m391.Add();
            Movie m392 = new Movie()
            {
                Imdb_Id = "tt0165076",
                Title = "The Adventures of Hal 5",
                Genre_Id = gen2.Id,
                Director = "Don Sharp",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/10/1958", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1958,
                Description = "A children\'s adventure. Hal V is a car owned (and loved) by the Hayward family and their children. Then a wicked garage owner tries to steal their beloved car to sell for lots of money, but...",
                Duration = 59,
                Views_Count = 0
            };
            m392.Add();
            Movie m393 = new Movie()
            {
                Imdb_Id = "tt0052228",
                Title = "Space Master X-7",
                Genre_Id = gen18.Id,
                Director = "Edward Bernds",
                Poster = "http://image.tmdb.org/t/p/original//d4BMCmtUZ5qRiT0jMakcKrmPatN.jpg",
                Youtube_Trailer = "mGT_ZiisEyw",
                Release_Date = DateTime.ParseExact("01/06/1958", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1958,
                Description = "A space probe returns to Earth covered with a strange fungus. The fungus is accidentally tinged with human blood and is transformed into an ever-growing pile of space rust, dubbed \"Blood Rust\". It is up to John Hand and Joe Rattigan to find the one woman who can stop the rust from spreading and taking over the world.",
                Duration = 71,
                Views_Count = 0
            };
            m393.Add();
            Movie m394 = new Movie()
            {
                Imdb_Id = "tt0050371",
                Title = "A Face in the Crowd",
                Genre_Id = gen14.Id,
                Director = "Elia Kazan",
                Poster = "http://image.tmdb.org/t/p/original//q6O6WxDtzv9MIzsmn5yPsugm0P1.jpg",
                Youtube_Trailer = "mJGUm9e_BLU",
                Release_Date = DateTime.ParseExact("01/06/1957", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1957,
                Description = "\"A Face in the Crowd\" charts the rise of a raucous hayseed named Lonesome Rhodes from itinerant Ozark guitar picker to local media rabble-rouser to TV superstar and political king-maker. Marcia Jeffries is the innocent Sarah Lawrence girl who discovers the great man in a back-country jail and is the first to fall under his spell.",
                Duration = 126,
                Views_Count = 0
            };
            m394.Add();
            Movie m395 = new Movie()
            {
                Imdb_Id = "tt0050204",
                Title = "Bombers B-52",
                Genre_Id = gen17.Id,
                Director = "Gordon Douglas",
                Poster = "http://image.tmdb.org/t/p/original//hOkWnWY67710x6xe7ZjIrB0TTga.jpg",
                Youtube_Trailer = "yE8CqFDR2e0",
                Release_Date = DateTime.ParseExact("26/12/1957", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1957,
                Description = "U.S Air Force Sgt. Chuck Brennan always disliked playboy and hotshot, Col. Jim Herlihy. He first met him in Korea, where his emergency arrival for repairs while enroute for what Chuck thought was the colonels \"hot date\" in Tokyo, caused the death of several of his crewmen. Now several years later when Chuck, while still in the Air Force, is now weighing continued enlistment or retirement, the base\'s new C.O. is none other than Col. Herlihy. Compounding his dislike is a budding romance with Chuck\'s daughter, Lois.",
                Duration = 106,
                Views_Count = 0
            };
            m395.Add();
            Movie m396 = new Movie()
            {
                Imdb_Id = "tt0050530",
                Title = "I Was a Teenage Werewolf",
                Genre_Id = gen10.Id,
                Director = "Gene Fowler Jr.",
                Poster = "http://image.tmdb.org/t/p/original//czpVPjEs0z5l3TqXAuJQ86ViKmr.jpg",
                Youtube_Trailer = "RsLOAS9MYdU",
                Release_Date = DateTime.ParseExact("19/06/1957", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1957,
                Description = "A troubled teenager seeks help through hypnotherapy, but his evil doctor uses him for regression experiments that transform him into a rampaging werewolf.",
                Duration = 76,
                Views_Count = 0
            };
            m396.Add();
            Movie m397 = new Movie()
            {
                Imdb_Id = "tt0051047",
                Title = "The Tall T",
                Genre_Id = gen20.Id,
                Director = "Budd Boetticher",
                Poster = "http://image.tmdb.org/t/p/original//ygvzJA3ffLQBXflwMQ9NxriODPf.jpg",
                Youtube_Trailer = "S4SJ_NS1fS8",
                Release_Date = DateTime.ParseExact("02/04/1957", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1957,
                Description = "Having lost his horse in a bet, Pat Brennan hitches a ride with a stagecoach carrying newlyweds, Willard and Doretta Mims. At the next station the coach and its passengers fall into the hands of a trio of outlaws headed by a man named Usher. When Usher learns that Doretta is the daughter of a rich copper-mine owner, he decides to hold her for ransom. Tension builds over the next 24 hours as Usher awaits a response to his demands and as a romantic attachment grows between Brennan and Doretta.",
                Duration = 78,
                Views_Count = 0
            };
            m397.Add();
            Movie m398 = new Movie()
            {
                Imdb_Id = "tt0122855",
                Title = "8 X 8: A Chess Sonata in 8 Movements",
                Genre_Id = gen12.Id,
                Director = "Jean Cocteau, Hans Richter",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("15/03/1957", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1957,
                Description = "It is a fairy tale for the subconscious based on the game of chess. Partly Sigmund Freud, partly Lewis Carroll.",
                Duration = 80,
                Views_Count = 0
            };
            m398.Add();
            Movie m399 = new Movie()
            {
                Imdb_Id = "tt0050873",
                Title = "Quatermass 2",
                Genre_Id = gen13.Id,
                Director = "Val Guest",
                Poster = "http://image.tmdb.org/t/p/original//A0JUHtVPgDYOMYTPBSrJpJYaYro.jpg",
                Youtube_Trailer = "vCwRzJQ0T7Y",
                Release_Date = DateTime.ParseExact("01/09/1957", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1957,
                Description = "Professor Quatermass, trying to gather support for Moon colonisation his project to colonize the Moon, is intrigued by the mysterious traces that have been showing up on his radar - meteorites crashing down?. Following them to the place where they should be landing he finds a destroyed village, a mysterious factory too close to his designs for the Moon colony for comfort, and some strange, aerodynamic objects containing a mysterious, ammonia-based gas that infects one of his assistants. Officially, the factory is producing synthetic food; but despite the veil of secrecy surrounding it Quatermass succeeds in finding out it harbours aliens with deadly designs on the Earth... Second in Hammer Films\' trio of screen versions for Nigel Kneale\'s classic 1950s BBC serials, with the same director and star as 1955\'s \"The Quatermass Experiment\".",
                Duration = 85,
                Views_Count = 0
            };
            m399.Add();
            Movie m400 = new Movie()
            {
                Imdb_Id = "tt0049117",
                Title = "D-Day the Sixth of June",
                Genre_Id = gen17.Id,
                Director = "Henry Koster",
                Poster = "http://image.tmdb.org/t/p/original//n7gYJlRnZGYdAZYKZwvsS9yBm3r.jpg",
                Youtube_Trailer = "lU398hJEMcQ",
                Release_Date = DateTime.ParseExact("29/05/1956", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1956,
                Description = "\'Twas the night before D-Day. One ship, carrying Special Force Six, leaves ahead of the main invasion on a dangerous mission. On board are British Colonel Wynter and American Captain Parker, who each, in flashback, reminisce about their separate involvements with beauteous Valerie Russell. Will the coming battle (confined to the film\'s last fifteen minutes) determine which one comes home to her?",
                Duration = 106,
                Views_Count = 0
            };
            m400.Add();
            Movie m401 = new Movie()
            {
                Imdb_Id = "tt0160592",
                Title = "O Dreamland",
                Genre_Id = gen5.Id,
                Director = "Lindsay Anderson",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("01/02/1956", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1956,
                Description = "Documentary on a famous amusement park, showing the irony of its manufactured fun.",
                Duration = 13,
                Views_Count = 0
            };
            m401.Add();
            Movie m402 = new Movie()
            {
                Imdb_Id = "tt0049967",
                Title = "X the Unknown",
                Genre_Id = gen18.Id,
                Director = "Leslie Norman, Joseph Losey",
                Poster = "http://image.tmdb.org/t/p/original//y7FF7zv8745LXYHhwXUzqzoY2sQ.jpg",
                Youtube_Trailer = "krz8ym_TdSs",
                Release_Date = DateTime.ParseExact("01/05/1957", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1957,
                Description = "British Army radiation drills at a remote Scottish base attract a subterranean, radioactive entity of unknown nature that vanishes, leaving two severely radiation-burned soldiers... and a \"bottomless\" crack in the earth. Others who meet the thing in the night suffer likewise, and with increasing severity; it seems to be able to \"absorb\" radiation from any source, growing bigger and bigger. What is it?? How do you destroy a thing that \"feeds\" on energy?",
                Duration = 81,
                Views_Count = 0
            };
            m402.Add();
            Movie m403 = new Movie()
            {
                Imdb_Id = "tt0049251",
                Title = "Gee Whiz-z-z-z-z-z-z",
                Genre_Id = gen3.Id,
                Director = "Chuck Jones",
                Poster = "http://image.tmdb.org/t/p/original//3Va25XdAI8AhZprgb9CNi7cLPpa.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("05/05/1956", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1956,
                Description = "Wile E. Coyote unsuccessfully chases the Road Runner using such contrivances as a rifle, a steel plate, a dynamite stick on an extending metal pulley, a painting of a collapsed bridge (which the Coyote falls into while Road Runner passes right through), and a jet motor.",
                Duration = 7,
                Views_Count = 0
            };
            m403.Add();
            Movie m404 = new Movie()
            {
                Imdb_Id = "tt0050087",
                Title = "5 Steps to Danger",
                Genre_Id = gen8.Id,
                Director = "Henry S. Kesler",
                Poster = "http://image.tmdb.org/t/p/original//wJU3EULBEiI6070jBYKNGlOBeEl.jpg",
                Youtube_Trailer = "tnGP6PJHLsU",
                Release_Date = DateTime.ParseExact("05/11/1956", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1956,
                Description = "When his car breaks down during a trip from Los Angeles to Texas John Emmett meets another motorist, Ann Nicholson, who offers him a lift. He learns that she is running away from her physician, Dr. Simmons, and the police, who want to question her about a murdered Central Intelligence Agent in Los Angeles. Anne, as it also turns out, is a native of Berlin, Germany. She had come into possession of a valuable secret formula for a 4000-mile-per-hour rocket, which is written on the reverse side of a small pocket mirror she carries. She wants to deliver this to a scientist in the United States. But, the scientist is an enemy agent as is her doctor and they, and the F.B.I are after her.",
                Duration = 81,
                Views_Count = 0
            };
            m404.Add();
            Movie m405 = new Movie()
            {
                Imdb_Id = "tt0049743",
                Title = "7 Men from Now",
                Genre_Id = gen22.Id,
                Director = "Budd Boetticher",
                Poster = "http://image.tmdb.org/t/p/original//xDApWc1RNqcdxlcOyH5Lfpwwa4d.jpg",
                Youtube_Trailer = "OIsB-PzMWpY",
                Release_Date = DateTime.ParseExact("04/08/1956", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1956,
                Description = "Ex-sheriff Ben Stride tracks the seven men who held up a Wells Fargo office and killed his wife. Stride is tormented by the fact that his own failure to keep his job was the cause of his wife\'s working in the express office and thus he is partly responsible for her death. Stride encounters a married couple heading west for California and helps them. Along the way they are joined by two n\'er-do-wells, Masters and Clete, who know that Stride is after the express-office robbers. They plan to let Stride lead them to the bandits, then make away with the loot themselves. But they aren\'t the only ones carrying a secret.",
                Duration = 78,
                Views_Count = 0
            };
            m405.Add();
            Movie m406 = new Movie()
            {
                Imdb_Id = "tt0048545",
                Title = "Rebel Without a Cause",
                Genre_Id = gen14.Id,
                Director = "Nicholas Ray",
                Poster = "http://image.tmdb.org/t/p/original//aFrfCpEwyyAhIbooDANgWiFzV9R.jpg",
                Youtube_Trailer = "1dWq360_T-I",
                Release_Date = DateTime.ParseExact("29/10/1955", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1955,
                Description = "Jim Stark is the new kid in town. He has been in trouble elsewhere; that\'s why his family has had to move before. Here he hopes to find the love he doesn\'t get from his middle-class family. Though he finds some of this in his relation with Judy, and a form of it in both Plato\'s adulation and Ray\'s real concern for him, Jim must still prove himself to his peers in switchblade knife fights and \"chickie\" games in which cars race toward a seaside cliff.",
                Duration = 111,
                Views_Count = 0
            };
            m406.Add();
            Movie m407 = new Movie()
            {
                Imdb_Id = "tt0048606",
                Title = "Sh-h-h-h-h-h",
                Genre_Id = gen5.Id,
                Director = "Tex Avery",
                Poster = "http://image.tmdb.org/t/p/original//h4J5xYOlGeZi0tJILz6iZkRYWfV.jpg",
                Youtube_Trailer = "9w0QoQX48kw",
                Release_Date = DateTime.ParseExact("06/06/1955", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1955,
                Description = "A mild-mannered man whose nerves are shot from incessant noise is sent to an exclusive, silent retreat with hilarious results.",
                Duration = 6,
                Views_Count = 0
            };
            m407.Add();
            Movie m408 = new Movie()
            {
                Imdb_Id = "tt0135630",
                Title = "Rock 'n' Roll Revue",
                Genre_Id = gen5.Id,
                Director = "Joseph Kohn",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("14/05/1956", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1956,
                Description = "Packed with music by the greats of the time.",
                Duration = 38,
                Views_Count = 0
            };
            m408.Add();
            Movie m409 = new Movie()
            {
                Imdb_Id = "tt0047993",
                Title = "Dial Red O",
                Genre_Id = gen8.Id,
                Director = "Daniel B. Ullman",
                Poster = "http://image.tmdb.org/t/p/original//ymUK8S9Z2IhmnIU55fjOLBlMZFr.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("13/03/1955", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1955,
                Description = "The first of the five films where Bill Elliott played a detective lieutenant in the L.A Sheriff\'s department, Dial Red \"O\" (the correct title with the number 0 (zero), as on a telephone dial, shown in \") opens with war-torn veteran Ralph Wyatt getting word that his wife is divorcing him, and he flees the psychiatric ward of the veteran\'s hospital, wanting to talk to her. His escape touches off an all-out manhunt, led by Lieutenant Andy Flynn of the sheriff\'s department. Wyatt\'s wife, Connie is having an affair with Norman Roper, a judo expert in Wyatt\'s old Marine unit. When Roper refuses to divorce his own wife (Regina Gibson) to marry Connie, they have a violent quarrel in Connie\'s apartment. Roper kills Connie and incriminates Wyatt, who is arrested and held on suspicion of homicide. Convinced that Roper is the real murderer, Wyatt escapes from his cell in the Hollywood Sheriff\'s office, and goes to Roper\'s home. Lt. Flynn has discovered evidence pointing to Roper as the killer, and arrives in time to prevent Wyatt from killing him. Jazzman Shorty Rogers (and his Giants) are also on hand as part of the Hollywood night life. The Elliott role name was changed to Andy Doyle for the following four films in the series, as there was a real Andy Flynn working in law enforcement in Los Angeles.",
                Duration = 63,
                Views_Count = 0
            };
            m409.Add();
            Movie m410 = new Movie()
            {
                Imdb_Id = "tt0048077",
                Title = "5 Against the House",
                Genre_Id = gen8.Id,
                Director = "Phil Karlson",
                Poster = "http://image.tmdb.org/t/p/original//i756gVSr2Bomr7MEkhchTksbMfM.jpg",
                Youtube_Trailer = "SI2wv99lYhg",
                Release_Date = DateTime.ParseExact("13/06/1955", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1955,
                Description = "Four college buddies enjoy a night at a Reno casino and overhear a cop saying that robbing the casino \"cannot be done.\" That gets the brainiest rich kid among them thinking up a plan for the perfect robbery. He convinces the others to join in when they hear that it will only be a college hoax, his plan being to let the police know where the money is afterwards. The thing is, one of his friends has a head injury from the war, and has no intention of returning a dime.",
                Duration = 84,
                Views_Count = 0
            };
            m410.Add();
            Movie m411 = new Movie()
            {
                Imdb_Id = "tt0047522",
                Title = "A Star Is Born",
                Genre_Id = gen14.Id,
                Director = "George Cukor",
                Poster = "http://image.tmdb.org/t/p/original//AlvKqnxlkWWYE6ngRLOWfYY3QuI.jpg",
                Youtube_Trailer = "XZ89oBOI3FI",
                Release_Date = DateTime.ParseExact("16/10/1954", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1954,
                Description = "Norman Maine, a movie star whose career is on the wane, meets showgirl Esther Blodgett when he drunkenly stumbles into her act one night. A friendship develops, then blossoms into romance before tensions increase as Esther\'s career takes off while Norman\'s continues to plummet.",
                Duration = 154,
                Views_Count = 0
            };
            m411.Add();
            Movie m412 = new Movie()
            {
                Imdb_Id = "tt0046912",
                Title = "Dial M for Murder",
                Genre_Id = gen20.Id,
                Director = "Alfred Hitchcock",
                Poster = "http://image.tmdb.org/t/p/original//jVMlfESb0TJ29w8CUDDofEprMmn.jpg",
                Youtube_Trailer = "IVLTgKsu_8s",
                Release_Date = DateTime.ParseExact("29/05/1954", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1954,
                Description = "In London, wealthy Margot Mary Wendice had a brief love affair with the American writer Mark Halliday while her husband and professional tennis player Tony Wendice was on a tennis tour. Tony quits playing to dedicate to his wife and finds a regular job. She decides to give him a second chance for their marriage. When Mark arrives from America to visit the couple, Margot tells him that she had destroyed all his letters but one that was stolen. Subsequently she was blackmailed, but she had never retrieved the stolen letter. Tony arrives home, claims that he needs to work and asks Margot to go with Mark to the theater. Meanwhile Tony calls Captain Lesgate (aka Charles Alexander Swann who studied with him at college) and blackmails him to murder his wife, so that he can inherit her fortune. But there is no perfect crime, and things do not work as planned.",
                Duration = 105,
                Views_Count = 0
            };
            m412.Add();
            Movie m413 = new Movie()
            {
                Imdb_Id = "tt0148646",
                Title = "Puss 'n' Boos",
                Genre_Id = gen9.Id,
                Director = "Seymour Kneitel",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/07/1954", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1954,
                Description = "Casper the Friendly Ghost saves three kittens and they accept the unpopular little ghost as their friend. They and Casper have a lot of fun and the level-headed little specter stays busy keeping them out of mischief. Casper finds a good home for the orphaned-kittens but, despite the comforts of their new home, the kittens escape and return to their ghost-friend.",
                Duration = 7,
                Views_Count = 0
            };
            m413.Add();
            Movie m414 = new Movie()
            {
                Imdb_Id = "tt0047582",
                Title = "3 Ring Circus",
                Genre_Id = gen19.Id,
                Director = "Joseph Pevney",
                Poster = "http://image.tmdb.org/t/p/original//doxIiVSZWQBDHKMgjq9PK7C7yMK.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("22/01/1955", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1955,
                Description = "Jerry and Pete are two friends with no money, looking for some job. They finally find one as workers in a circus, but Jerry has different dreams. He wants to become a clown.",
                Duration = 103,
                Views_Count = 0
            };
            m414.Add();
            Movie m415 = new Movie()
            {
                Imdb_Id = "tt1333023",
                Title = "Dogs 'n Ducks",
                Genre_Id = gen5.Id,
                Director = "Ford Beebe, Norman Wright",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("27/06/1953", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1953,
                Description = "A boy and his dogs, a dog and his ducks. Mike, a terrier, has it made until his master gets a golden retriever pup. Within a year, the pup, named Golden Prince, is hard at work learning the skills of his breed. We watch them practice, with Pete Smith providing the narration and Mike the comic relief. After a year and a half, Golden Prince is ready for his first competition: retrieving three live ducks from a marshy lake. How will he do, and how will Mike respond? The film finishes with Prince\'s first ocean retrieval.",
                Duration = 10,
                Views_Count = 0
            };
            m415.Add();
            Movie m416 = new Movie()
            {
                Imdb_Id = "tt0045464",
                Title = "The 5,000 Fingers of Dr. T.",
                Genre_Id = gen10.Id,
                Director = "Roy Rowland",
                Poster = "http://image.tmdb.org/t/p/original//kGXAJMZg7qh1yDBPH9RQa8nqkqZ.jpg",
                Youtube_Trailer = "jGMGGvWUb1Q",
                Release_Date = DateTime.ParseExact("01/07/1953", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1953,
                Description = "The bane of adolescent Bart Collins\' existence is the piano lessons he is forced to take under the tutelage of Dr. Terwilliker, the only person he admits he detests because of his dictatorial nature. Bart feels Dr. Terwilliker has undue influence for these lessons on his widowed mother, Heloise Collins. The one person who sympathizes with Bart, although quietly on the sidelines, is the Collins\' plumber, August Zabladowski. Bart hates his life associated with the piano so much he often daydreams when he practices and even during his lessons. His latest dream has him imprisoned in the fantastical Terwilliker Institute in the day before its grand opening. Terwilliker\'s second in command at the Institute is his mother, although she has been hypnotized into her position, which will also soon be as Mrs. Dr. Terwilliker. Bart tries to convince Mr. Zabladowski, who is there to install the Institute\'s plumbing, to save his mother and himself from Terwilliker. Bart also hopes that Zabladowski will become his father instead of Dr. Terwilliker. But Bart wants more than anything to ruin the Institute\'s grand opening, which has at its core Bart and 499 other boys like him playing one large piano simultaneously to a tune composed and directed by the evil Dr. T.",
                Duration = 89,
                Views_Count = 0
            };
            m416.Add();
            Movie m417 = new Movie()
            {
                Imdb_Id = "tt0047001",
                Title = "From A to Z-Z-Z-Z",
                Genre_Id = gen3.Id,
                Director = "Chuck Jones",
                Poster = "http://image.tmdb.org/t/p/original//fVtMKyE04kCBUYb3MEsyeADJbvW.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("16/10/1954", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1954,
                Description = "In his first of two Warner Bros. cartoons, schoolboy Ralph Phillips daydreams in class, the lessons inspiring his fantasy heroics, such as being a pony-express rider, a deep-sea diver, a boxing champion and even General Douglas MacArthur.",
                Duration = 7,
                Views_Count = 0
            };
            m417.Add();
            Movie m418 = new Movie()
            {
                Imdb_Id = "tt0045029",
                Title = "Phone Call from a Stranger",
                Genre_Id = gen11.Id,
                Director = "Jean Negulesco",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "ak8x7DTpMDo",
                Release_Date = DateTime.ParseExact("15/02/1952", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1952,
                Description = "On a flight from Chicago to Los Angeles via Iowa, lawyer David Trask gets to know three of his fellow passengers as one technical issue after another leads to delays and unscheduled stops along the way. Those three are physician Dr. Robert Fortness, struggling actress with the stage name Binky Gay, and loud salesman Eddie Hoke, who is both quick with a joke and quick to show off a photograph of his beautiful wife, Marie Hoke. Below the surface, the three have deeper stories, which are bringing them back to Los Angeles and which Dr. Fortness and Binky divulge to David. Dr. Fortness, an alcoholic, is returning to own up to his drunken part in the death of a friend, and his wife Claire\'s complicity in the matter. Binky, after being away in New York for a year, is returning to her husband, Mike Carr, hoping to take him away from his overbearing mother, former vaudeville star Sally Carr, who still basks in her former but no longer shining glory, and who is the cause of any marital problem she and Mike have had as she sees Binky as competition in every sense of the word. Because of an incident en route and his burgeoning friendship with them, David feels compelled to help them resolve their issues. Specifically in dealing with Eddie\'s life, David is forced to reflect on his own and the reason he left his home in Midland City, Iowa.",
                Duration = 105,
                Views_Count = 0
            };
            m418.Add();
            Movie m419 = new Movie()
            {
                Imdb_Id = "tt0045235",
                Title = "Three for Bedroom C",
                Genre_Id = gen15.Id,
                Director = "Milton H. Bren",
                Poster = "http://image.tmdb.org/t/p/original//6diFTIJcbQ9lOMpqmPls6AVjzhE.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("26/06/1952", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1952,
                Description = "A film star and her young daughter stow away on a cross-country train to California. The compartment they invade belongs to a celebrated biology professor; romance blossoms. The star\'s manager turns up; complications ensue.",
                Duration = 74,
                Views_Count = 0
            };
            m419.Add();
            Movie m420 = new Movie()
            {
                Imdb_Id = "tt0044981",
                Title = "O. Henry's Full House",
                Genre_Id = gen13.Id,
                Director = "Henry Hathaway, Howard Hawks, Henry King, Henry Koster, Jean Negulesco",
                Poster = "http://image.tmdb.org/t/p/original//aoIvfHdzEk2rxUMbasptim4xuTB.jpg",
                Youtube_Trailer = "c7FInmLD_F8",
                Release_Date = DateTime.ParseExact("27/10/1952", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1952,
                Description = "\"O. Henry\'s Full House\" is a film divided in five segments telling five tales in the beginning of the Twentieth Century. 1) \"The Cop and the Anthem\": the winter is coming and the homeless drifter Soapy wants to go to jail for three months to get shelter and food. His partner Horace suggests they look for shelter with the Salvation Army, but Soapy refuses. He forces many situations to be arrested but he is always forgiven. When he goes to the church, there is a miracle and Soapy decides to seek a job position. Will he succeed? 2) \"The Clarion Call\": when a thief kills a man, the police investigators do not have any lead to follow. Police Sergeant Barney Woods sees a pen that was found in the crime scene and he seeks out a man called Johnny Kernan. He finds Johnny that invites Barney to drink with him and they go to his hotel room. Johnny recalls their youth, when they were friends but Barney tells that he must arrest him since he recognized the pen that belonged to Johnny. However the criminal recalls that Barney owes him $ 1,000 that Barney lost in a card game. Barney unsuccessfully tries to raise the money to quit the debt. He decides to tell to the Chief of Police but out of the blue, he sees the spotlight on \"The Clarion Call\" and and runs to the newspaper. What did he see? 3) \"The Last Leaf\": When the lover of the twenty-one year-old Joanna Goodwin breaks up with her, she wanders on the snow and gets pneumonia. Her older sister Susan Goodwin finds that Joanna does not want to live anymore and is following the leaves that keep falling from a tree. Their upstairs neighbor, the painter Behrman, tries to help the girls the best he can. Will he be able to save Joanna? 4) \"The Ransom of Red Chief\": the con men Sam \'Slick\' Brown and Bill Peoria flee to the countryside in their car and plot to kidnap the boy J.B. Dorset to ask for ransom to his parents. But soon they find that the boy is a little devil. 5) \"The Gift of the Magi\": In Christmas Eve, Della and her beloved husband Jim are penniless and in love with each other. Jim dreams on giving a tiara to Della since she has a wonderful hair and Della wants to give a chain to the pocket watch of Jim. On the Christmas night, they find a way to buy the gifts.",
                Duration = 117,
                Views_Count = 0
            };
            m420.Add();
            Movie m421 = new Movie()
            {
                Imdb_Id = "tt0044563",
                Title = "Down Among the Z Men",
                Genre_Id = gen16.Id,
                Director = "Maclean Rogers",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "kv-zRc7Vip8",
                Release_Date = DateTime.ParseExact("01/10/1952", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1952,
                Description = "The cast of the popular radio program \"The Goon Show\" perform some of their favourite routines.",
                Duration = 82,
                Views_Count = 0
            };
            m421.Add();
            Movie m422 = new Movie()
            {
                Imdb_Id = "tt0043766",
                Title = "M",
                Genre_Id = gen11.Id,
                Director = "Joseph Losey",
                Poster = "http://image.tmdb.org/t/p/original//iAPzLnRjsKLix9WT1ppTstPxWAC.jpg",
                Youtube_Trailer = "IovfalMQ6lQ",
                Release_Date = DateTime.ParseExact("01/03/1951", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1951,
                Description = "There is a baby killer loose and the police can\'t find him. He is a sick, psychotic and confused individual, though guilty. The increased police activity trying to find the baby killer is interfering with the mob\'s criminal activities. The gangsters are not pleased the intense police attention so the mob decides to find him themselves. The mob bosses send the mobsters out to find him. He is found and the young girl he grabbed is saved. A mock trial is conducted in the basement of a parking garage in front of mass of gangsters who captured him and citizens demanding blood. The baby criminal is defended by a lawyer provided by the mob boss. As the police show up, the mob boss shoots the lawyer defending the baby killer because he is doing too good of a job defending the baby killer. Both the mob boss and the baby killer are taken into custody by the police for justice. As the movie ends and the guilty are led out of the parking garage, we hear the spooky single tune played on a flute that was single clue leading to the apprehension of the baby killer.",
                Duration = 88,
                Views_Count = 0
            };
            m422.Add();
            Movie m423 = new Movie()
            {
                Imdb_Id = "tt0043778",
                Title = "The Man from Planet X",
                Genre_Id = gen17.Id,
                Director = "Edgar G. Ulmer",
                Poster = "http://image.tmdb.org/t/p/original//y5oCf0MUfBVMdmwv9gX5lAYN4r5.jpg",
                Youtube_Trailer = "IEz-4H2tcu8",
                Release_Date = DateTime.ParseExact("27/04/1951", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1951,
                Description = "To study a rogue planet heading for a near-miss with Earth, Prof. Elliot sets up an observatory on the foggy moors of a remote Scottish island, with his pretty daughter and Dr. Mears, a former student with a shady past. Soon after arrival of reporter John Lawrence, a ship from Planet X just happens to land near the observatory. Is the visitor (who actually looks alien) benevolent? What are Mears\' real motives for trying to communicate with it?",
                Duration = 71,
                Views_Count = 0
            };
            m423.Add();
            Movie m424 = new Movie()
            {
                Imdb_Id = "tt0142854",
                Title = "Slingshot 6 7/8",
                Genre_Id = gen5.Id,
                Director = "Walter Lantz, Don Patterson, Paul J. Smith",
                Poster = "/Assets/images/shared/state/4xx/404poster.png",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("23/07/1951", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1951,
                Description = "Out west, tenderfoot Woody uses his slingshot against Indian Buzz Buzzard in a shooting contest.",
                Duration = 133,
                Views_Count = 0
            };
            m424.Add();
            Movie m425 = new Movie()
            {
                Imdb_Id = "tt0042593",
                Title = "In a Lonely Place",
                Genre_Id = gen11.Id,
                Director = "Nicholas Ray",
                Poster = "http://image.tmdb.org/t/p/original//8KToZKp0ptiLpdT6ChJlsiJTIPg.jpg",
                Youtube_Trailer = "Fu8E3LooDZo",
                Release_Date = DateTime.ParseExact("01/08/1950", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1950,
                Description = "Screenwriter Dixon Steele, faced with the odious task of scripting a trashy bestseller, has hat-check girl Mildred Atkinson tell him the story in her own words. Later that night, Mildred is murdered and Steele is a prime suspect; his record of belligerence when angry and his macabre sense of humor tell against him. Fortunately, lovely neighbor Laurel Gray gives him an alibi. Laurel proves to be just what Steele needed, and their friendship ripens into love. Will suspicion, doubt, and Steele\'s inner demons come between them?",
                Duration = 94,
                Views_Count = 0
            };
            m425.Add();
            Movie m426 = new Movie()
            {
                Imdb_Id = "tt0042191",
                Title = "All a Bir-r-r-d",
                Genre_Id = gen5.Id,
                Director = "Friz Freleng",
                Poster = "http://image.tmdb.org/t/p/original//4vYOh37dAGefQAkKI09RJ8qfLGw.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("24/06/1950", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1950,
                Description = "Sylvester Cat, Tweety Bird, and a bulldog are passengers on a train. Sylvester\'s attempts to catch Tweety are thwarted by the bulldog and a conscientious conductor.",
                Duration = 7,
                Views_Count = 0
            };
            m426.Add();
            Movie m427 = new Movie()
            {
                Imdb_Id = "tt0042588",
                Title = "I Was a Shoplifter",
                Genre_Id = gen8.Id,
                Director = "Charles Lamont",
                Poster = "http://image.tmdb.org/t/p/original//8yIw7P68fLX55T7qh4axH2dOYlt.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("13/05/1950", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1950,
                Description = "Police detective sergeant Jeff Andrews is working on a case involving a gang of shoplifters, and he allows himself to falsely arrested as a petty thief, in order to make contact with the gang. Meanwhile, Faye Burton, a petty shoplifter and the daughter of a prominent judge, is blackmailed by the gang into joining them on the promise that they will get back a confession signed when she was caught by a department store detective, who had her sign the document rather than calling the police. It takes Jeff and Faye a lot longer to figure out who is the \'brains\' behind the shoplifting gang than it does the audience, and the audience has less information than they do.",
                Duration = 74,
                Views_Count = 0
            };
            m427.Add();
            Movie m428 = new Movie()
            {
                Imdb_Id = "tt0042897",
                Title = "Rocketship X-M",
                Genre_Id = gen5.Id,
                Director = "Kurt Neumann",
                Poster = "http://image.tmdb.org/t/p/original//cthtBQ0UfjlIp0Q0ERXu4ozFJ2w.jpg",
                Youtube_Trailer = "tG9RD1lje_s",
                Release_Date = DateTime.ParseExact("02/06/1950", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1950,
                Description = "Astronauts (Lloyd Bridges, Osa Massen, John Emery, Noah Beery, Jr., and Hugh O\'Brien) blast off to explore the moon. Because of craft malfunction and some fuel calculations, they end up landing on Mars. On Mars, evidence of a once powerful civilization is found. The scientists determine that an atomic war destroyed most of the Martians (who surprisingly look like humans). Those that survived reverted to a caveman-like existence.",
                Duration = 77,
                Views_Count = 0
            };
            m428.Add();
            Movie m429 = new Movie()
            {
                Imdb_Id = "tt0042177",
                Title = "8 Ball Bunny",
                Genre_Id = gen3.Id,
                Director = "Chuck Jones",
                Poster = "http://image.tmdb.org/t/p/original//gY74E37lEl3sa6gO0ZTxjYw4lMp.jpg",
                Youtube_Trailer = "",
                Release_Date = DateTime.ParseExact("08/07/1950", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                Release_Year = 1950,
                Description = "Bugs helps a little penguin get home after the Ice Frolics show he was in is closed. They head south to New Orleans where the penguin gets on the Admiral Byrd, which it turns out is bound for Brooklyn. Their second attempt gets them to the Panama canal but they soon find themselves as the main course for a native dinner. They finally make it to the South Pole but Bugs too late just where home is.",
                Duration = 7,
                Views_Count = 0
            };
            m429.Add();

            Playlist pl1 = new Playlist() { Premium_Id = prem.Id, Title = "Playlist1" };
            pl1.Add();

            PlaylistMovie p1ml1 = new PlaylistMovie() { Movie_Id = m1.Id, Playlist_Id = pl1.Id };
            p1ml1.Add();

            PlaylistMovie p2ml1 = new PlaylistMovie() { Movie_Id = m2.Id, Playlist_Id = pl1.Id };
            p2ml1.Add();

            Rating r1 = new Rating() { User_Id = u1.Id, Movie_Id = m1.Id, Rating_ = 4 }; r1.Add();
            Rating r2 = new Rating() { User_Id = u2.Id, Movie_Id = m2.Id, Rating_ = 5 }; r2.Add();

            MovieRequest mr = new MovieRequest() { Premium_Id = prem.Id, Title = "Requested Movie", Note = "Note" };
            mr.Add();

            //ViewLog vl = new ViewLog() { User_Id = u3.Id, Movie_Id = m1.Id, Time_Stamp = DateTime.ParseExact("ddd dd/MM/yyyy HH:mm:ss", DateTime.Now.ToString("ddd dd/MM/yyyy HH:mm:ss"), System.Globalization.CultureInfo.InvariantCulture) };
            //vl.Add();
            
        }
    }
}
