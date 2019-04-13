namespace Get_Movies.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Get_Movies.Data;
    using Get_Movies.Models;
    //Get_Movies.Migrations.Configuration
    internal sealed class Configuration : DbMigrationsConfiguration<Get_Movies.Data.GetMoviesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(GetMoviesContext context)
        {
            User u1 = new User
            {
                Email = "user1@gmail.com",
                Username = "user1",
                Password = "12345678",
                First_Name = "user 1",
                Last_Name = "xxxx",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_000906.jpg",
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
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_002441.jpg",
                Verified = 0
            };
            u2.Add();
            Premium prem = new Premium() { User_Id = u2.Id };prem.Add();

            User u3 = new User
            {
                Email = "user3@gmail.com",
                Username = "user3",
                Password = "12345678",
                First_Name = "user 3",
                Last_Name = "xxxx",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_005341.jpg",
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
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_005609.jpg",
                Verified = 0
            };
            u4.Add();
            new Blacklist() { User_Id = u4.Id, Reason = "Ban Testing", End_Date = "04/06/2019" }.Add();

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

            //Inital URL for movie_poster :   https://upload.wikimedia.org/wikipedia/ 

            Movie m1 = new Movie()
            {
                Title = "RED",
                Genre_Id = gen1.Id,
                Director = "Robert Schwentke",
                Release_Date = "12/05/2010",
                Poster = "en/4/41/Red_ver7.jpg",
                Description = "Frank Moses (Willis), retired black-ops CIA agent, lives alone in Cleveland, Ohio. Lonely, Frank creates opportunities to talk to Sarah Ross (Parker), a worker at the General Services Administration's pension office in Kansas City, Missouri, by tearing up his pension checks and calling to say they haven't arrived.One night, an assassination squad raids Frank's house and attempts to kill him but he easily wipes them out. Knowing they will have tapped his phone, he believes Sarah will be targeted. In Kansas City Sarah refuses to go with him so he kidnaps her. Meanwhile CIA agent William Cooper (Urban) is assigned by his boss Cynthia Wilkes (Pidgeon) to hunt down and kill Frank.To find out who is targeting him Frank tracks down his old associates for help. He goes to New Orleans, Louisiana, and visits his CIA mentor Joe Matheson (Freeman), who tells him the same hit squad murdered a New York Times reporter. An agent posing as a police officer tries to abduct Sarah but Frank returns in time. Cooper chases them but Frank tricks the police into arresting Cooper and escapes with Sarah. The two head to New York City and find clues left by the reporter which lead them to a hit list.They find Marvin Boggs (Malkovich), another old associate and a paranoid conspiracy theorist, who tells them the people on the list, including Frank and Marvin, are connected to a secret 1981 mission in Guatemala. A pilot on the list, Gabriel Singer (Remar), tells them the mission involved extracting a person from a Guatemalan village. Singer is shot by a helicopter-borne machine-gunner and the team escapes as Cooper closes in.Ex-Russian secret agent Ivan Simanov (Cox), in return for a favor, helps Frank infiltrate the CIA headquarters archive. Henry the records keeper (Borgnine) has much respect for Frank and simply hands him the Guatemala file. Frank confronts Cooper in his office and the two fight. Frank is wounded, and Joe arrives to help extract the team. They hide out in the home of former wetwork agent Victoria Winslow (Mirren), who treats Frank's wound and joins the team.The file leads them to Alexander Dunning (Dreyfuss), an arms trafficker. Joe poses as a buyer and enters Dunning's mansion with Frank and Marvin while Victoria and Sarah keep watch outside. They interrogate Dunning, who tells them the target for extraction was Lieutenant Robert Stanton (McMahon), whose Senator father organised the extraction via Dunning. Stanton is now Vice President and has ordered the assassination of people involved in the mission to hide the fact that he massacred village civilians.The FBI surround Dunning's mansion. Cooper tries to negotiate Frank's surrender, and Frank tells him about the Vice President's treachery. The terminally ill Joe pretends to be Frank, walks outside, and is killed by the Vice President's bodyguard squad. The confusion, as well as Victoria's cover fire, buys the team time to leave the mansion but Sarah is captured. Frank calls Cooper from Cooper's own family's home phone and warns him against harming Sarah.The team kidnaps Stanton to trade for Sarah. Dunning arrives at the meeting point. Dunning injures Stanton, revealing himself and Wilkes to be behind the assassinations and that Stanton was never involved. Disgusted with Wilkes' corruption, Cooper pretends to arrest Frank but instead shoots Wilkes. Marvin and Victoria kill Dunning's bodyguards, and Frank crushes Dunning's windpipe. Cooper lets Frank's team go. As they leave, Sarah is eager to accompany Frank on a new mission.Ivan reminds Frank of his favor. A few months later, Frank and Marvin are fleeing Moldovan troops with a stolen nuclear device, with Marvin wearing a dress in a wooden wheelbarrow being pushed by Frank.",
                Duration = 100,
                Rating_Count = 0,
                View_Count = 0
            };
            m1.Add();
            Movie m2 = new Movie()
            {
                Title = "RED 2",
                Genre_Id = gen1.Id,
                Director = "Dean Parisot",
                Release_Date = "12/05/2016",
                Poster = "en/9/9e/RED_2_poster.jpg",
                Description = "Three years after the events of the previous film, ex-CIA operative Frank Moses tries to lead a normal life with girlfriend Sarah Ross. He dismisses Marvin Boggs\u2019 claims that enemies are still after them; Marvin drives off and his car explodes. Although Frank is unconvinced Marvin is dead, Sarah convinces him to attend Marvin's funeral where he delivers a tearful eulogy. Government agents interrogate Frank at an FBI Yankee White facility. Corrupt agent Jack Horton and a team of private military contractors ambush the facility; he threatens to torture Sarah until Frank gives him the information he needs. Frank evades Horton, and with the help of the still living Marvin, goes on the run with Sarah. Marvin explains he and Frank have been targeted as members of Operation Nightshade, a clandestine operation during the Cold War to smuggle a nuclear weapon into Russia. Horton convinces international agencies that Frank and his associates are terrorists on the run. Frank\u2019s old ally Victoria notifies him that she has been contracted by MI6 to kill the fugitives. Another top contract killer, Han Cho-Bai, is also hired, seeking revenge against Frank. Frank, Marvin, and Sarah steal Han's plane and fly to Paris to find \"The Frog\", with the Americans and Han in pursuit. They are met by Katja Petrokovich, a Russian secret agent with whom Frank had a relationship, who is also investigating Nightshade. They interrogate the Frog and Sarah, hoping to one-up Katja, seduces him. The Frog gives them the key to his security box, which Katja takes after drugging Frank; Marvin, anticipating her double-cross, provided Frank with a similar key to give her. Marvin, Frank, and Sarah search the box themselves and find documents pointing to physicist Dr. Edward Bailey as the creator of the Nightshade bomb.They discover Bailey is alive, held for thirty-two years in a maximum security asylum for the criminally insane in London. Victoria, alerted by Marvin, ambushes the trio, but helps fake their deaths and infiltrate the asylum. They find the hyperactive Bailey, incapacitated by mind-fogging drugs, and bring him to Marvin\u2019s safehouse, where Bailey remembers the location of the bomb. In Moscow, Bailey concludes he hid the bomb in the Kremlin. There, the team locates the suitcase bomb, powered by red mercury. Katja stops them, but Frank persuades her to join their mission. They escape, but a call from Victoria, who has broken out of MI6 confinement for failing to kill him, reveals that Bailey was imprisoned because he wanted to detonate the bomb. Holding Frank at gunpoint, Bailey confirms Victoria's message, admitting he made a deal to give Horton the bomb. He shoots Katja, frames Frank, and leaves with the bomb. Horton reneges on their deal, intending to torture Bailey for all his secrets, but Bailey deploys a nerve gas and escapes to the Iranian embassy in London. In pursuit, Frank is attacked by Han. Reaching a standoff, Frank urges Han to join him in stopping Bailey; Han relents, and the five enact a plan to recapture the bomb. Sarah seduces the Iranian ambassador and takes him hostage. Marvin poses as a potential defector, causing a diversion in the embassy that allows the team to enter disguised as plumbers. They learn the bomb\u2019s location, but Bailey has already triggered the timer and killed Horton. Bailey takes Sarah hostage and flees to Han\u2019s plane to escape the imminent explosion. Frank, Marvin, Victoria, and Han give chase, but Marvin\u2019s attempts to disarm the suitcase bomb cause the timer to count down even faster. Frank boards the plane and confronts Bailey with the suitcase; he forces Frank to leave with Sarah and the suitcase. They rejoin the others and wait for the suitcase to detonate as the plane takes off \u2013 high in the sky, it explodes. Frank reveals that he hid the bomb aboard the plane and confronted Bailey with the empty case. Han angrily demands $30 million for his plane and $20 million for not killing Frank. The film ends as Sarah enjoys herself on a mission in Caracas with Frank and Marvin.",
                Duration = 120,
                Rating_Count = 0,
                View_Count = 0
            };
            m2.Add();

            Movie m3 = new Movie()
            {
                Title = "Shazam",
                Genre_Id = 2,
                Director = "David F. Sandberg",
                Release_Date = "23/03/2019",
                Poster = "/en/6/60/Shazam%21_theatrical_poster.jpg",
                Description = "A boy is given the ability to become an adult superhero in times of need with a single magic word",
                Duration = 132,
                Rating_Count = 0,
                View_Count = 0
            };
            m3.Add();

            Movie m4 = new Movie()
            {
                Title = "Captain Marvel",
                Genre_Id = 1,
                Director = "Ryan Fleck",
                Release_Date = "03/06/2019",
                Poster = "/en/8/85/Captain_Marvel_poster.jpg",
                Description = "Carol Danvers becomes one of the universe's most powerful heroes when Earth is caught in the middle of a galactic war between two alien races. ",
                Duration = 123,
                Rating_Count = 0,
                View_Count = 0
            };
            m4.Add();

            Movie m5 = new Movie()
            {
                Title = "Dumbo",
                Genre_Id = 2,
                Director = "Tim Burton",
                Release_Date = "27/03/201",
                Poster = "/en/9/91/Dumbo_%282019_film%29.png",
                Description = "A young elephant, whose oversized ears enable him to fly, helps save a struggling circus, but when the circus plans a new venture, Dumbo and his friends discover dark secrets beneath its shiny veneer. ",
                Duration = 112,
                Rating_Count = 0,
                View_Count = 0
            };
            m5.Add();

            Movie m6 = new Movie()
            {
                Title = "Cars",
                Genre_Id = 3,
                Director = "John Lasseter",
                Release_Date = "08/06/2006",
                Poster = "en/3/34/Cars_2006.jpg ",
                Description = "A hot-shot race-car named Lightning McQueen gets waylaid in Radiator Springs, where he finds the true meaning of friendship and family. ",
                Duration = 117,
                Rating_Count = 0,
                View_Count = 0
            };
            m6.Add();

            Movie m7 = new Movie()
            {
                Title = "Ralph Breaks the Internet",
                Genre_Id = 3,
                Director = " Phil Johnston",
                Release_Date = "20/11/2018",
                Poster = "en/0/0b/Ralph_Breaks_the_Internet_%282018_film_poster%29.png",
                Description = "Ralph and Vanellope, now friends, discover a wi-fi router in their arcade, leading them into a new adventure. ",
                Duration = 111,
                Rating_Count = 0,
                View_Count = 0
            };
            m7.Add();

            Movie m8 = new Movie()
            {
                Title = "Annabelle",
                Genre_Id = 13,
                Director = "John R. Leonetti",
                Release_Date = "02/10/2014",
                Poster = "en/9/90/Annabelle_film_poster.jpg",
                Description = "A couple begins to experience terrifying supernatural occurrences involving a vintage doll shortly after their home is invaded by satanic cultists. ",
                Duration = 99,
                Rating_Count = 0,
                View_Count = 0
            };
            m8.Add();

            Movie m9 = new Movie()
            {
                Title = "Annabelle Comes Home",
                Genre_Id = 13,
                Director = "Gary Dauberman",
                Release_Date = "03/08/2017",
                Poster = "en/2/2f/AnnabelleComesHome.jpeg",
                Description = "Determined to keep Annabelle from wreaking more havoc, demonologists Ed and Lorraine Warren bring the possessed doll to the locked artifacts room in their home, placing her "safely" behind sacred glass and enlisting a priest's holy blessing. But an unholy night of horror awaits as Annabelle awakens the evil spirits in the room, who all set their sights on a new target-the Warrens' ten-year-old daughter, Judy, and her friends.",
                Duration = 000,
                Rating_Count = 0,
                View_Count = 0
            };
            m9.Add();

            Movie m10 = new Movie()
            {
                Title = "Annabelle: Creation ",
                Genre_Id = 13,
                Director = "David F. Sandberg",
                Release_Date = "03/08/2017",
                Poster = "en/0/08/Annabelle_Creation.jpg",
                Description = "Twelve years after the tragic death of their little girl, a doll-maker and his wife welcome a nun and several girls from a shuttered orphanage into their home, where they become the target of the doll-maker's possessed creation, Annabelle. ",
                Duration = 109,
                Rating_Count = 0,
                View_Count = 0
            };
            m10.Add();


            Movie m11 = new Movie()
            {
                Title = "Harry Potter and the Sorcerer's Stone",
                Genre_Id = 18,
                Director = "Chris Columbus",
                Release_Date = "16/11/2001",
                Poster = "en/7/7a/Harry_Potter_and_the_Philosopher%27s_Stone_banner.jpg",
                Description = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world. ",
                Duration = 152,
                Rating_Count = 0,
                View_Count = 0
            };
            m11.Add();

            Movie m12 = new Movie()
            {
                Title = "Doctor Strange",
                Genre_Id = 18,
                Director = "Chris Columbus",
                Release_Date = "25/10/2016",
                Poster = "en/c/c7/Doctor_Strange_poster.jpg",
                Description = "While on a journey of physical and spiritual healing, a brilliant neurosurgeon is drawn into the world of the mystic arts.",
                Duration = 115,
                Rating_Count = 0,
                View_Count = 0
            };
            m12.Add();

            Movie m13 = new Movie()
            {
                Title = "War Of The Worlds",
                Genre_Id = 21,
                Director = "Steven Spielberg",
                Release_Date = "28/06/2005",
                Poster = "en/8/83/War_of_the_Worlds_2005_poster.jpg",
                Description = "As Earth is invaded by alien tripod fighting machines, one family fights for survival.",
                Duration = 116,
                Rating_Count = 0,
                View_Count = 0
            };
            m13.Add();







            Playlist pl1 = new Playlist() { Premium_Id = prem.Id, Title = "Playlist1" };
            pl1.Add();

            MoviePlaylist m1pl1 = new MoviePlaylist() { Movie_Id = m1.Id, Playlist_Id = pl1.Id };
            m1pl1.Add();

            MoviePlaylist m2pl1 = new MoviePlaylist() { Movie_Id = m2.Id, Playlist_Id = pl1.Id };
            m2pl1.Add();

            Rating r1 = new Rating() { User_Id = u1.Id, Movie_Id = m1.Id, Rating_ = 4 }; r1.Add();
            Rating r2 = new Rating() { User_Id = u2.Id, Movie_Id = m2.Id, Rating_ = 5 }; r2.Add();

            MovieRequest mr = new MovieRequest() { Premium_Id = prem.Id, Title = "Requested Movie", Note = "Note" };
            mr.Add();

            AdRequest ar = new AdRequest() { Email = "proposer@gmail.com", Note = "Negotiation Terms", Image = "www.text2image.com/user_images/text2image_A31887_20190406_022910.jpg", Start_Date = "10/10/2019", Approved = 0 };
            ar.Add();

            ViewLog vl = new ViewLog() { User_Id = 3, Movie_Id = 1, Time_Stamp = DateTime.Now.ToString("dddd, dd MMMM yyyy")};
            vl.Add();
        }
    }
}
