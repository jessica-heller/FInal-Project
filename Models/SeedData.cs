using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.User.Any())
                {
                    return;
                }

                List<User> users = new List<User> {
                    new User {FirstName="Tessa", LastName="Stewart",
                    Biography = "Hi, I'm Tessa. I'm passionate about reading books that empower women and encourage social change. I work as a social worker and love using my knowledge to connect with the characters and themes in the books I read. When I'm not reading, I enjoy cooking and volunteering at my local community center.",
                    Email = "tessastewart@gmail.com"},
                    
                    new User {FirstName="Rachel", LastName="Diggs", 
                    Biography = "Hi, I'm Rachel! I'm a big fan of historical fiction and mysteries. When I'm not reading, I enjoy hiking and trying new restaurants with my book club friends. I work as a librarian and love helping others find their next favorite book.",
                    Email = "racheldiggs@icloud.com"},
                    
                    new User {FirstName="Oliver", LastName="Jackson",
                    Biography ="Hey there, my name is Oliver. I'm an avid sci-fi reader and enjoy discussing the latest technology and scientific discoveries with my book club buddies. In my free time, I like tinkering with electronics and playing video games.",
                    Email = "oliverjackson@gmail.com"},
                    
                    new User {FirstName="Liam", LastName="Faulkner",
                    Biography = "Hi, my name is Liam. I love reading books that explore the depths of the human psyche and push the boundaries of traditional storytelling. I work as a psychologist and enjoy applying my knowledge to the characters and themes in the books I read. In my free time, I like playing chess and hiking in nature.",
                    Email = "liamfaulkner@yahoo.com"},
                    
                    
                    new User {FirstName="Jennifer", LastName="Torres",
                    Biography ="Hi, I'm Lily. I'm a big fan of romance novels and enjoy discussing the latest plot twists and character developments with my book club friends. When I'm not reading, I enjoy writing my own romance stories and spending time with my family and pets. I work as a marketing manager and love using my creativity to come up with new ideas.",
                    Email = "jennifertorres@icloud.com"},
                    
                    new User {FirstName="Cindy", LastName="Gates",
                    Biography = "Hi there! I'm Cindy, a book lover from San Francisco. I've been an avid reader since I was a little girl, and my love for books has only grown stronger over the years. I enjoy all kinds of genres, from romance and mystery to science fiction and fantasy. I joined this book club to meet other people who share my passion for reading, and I'm so excited to discuss our next book together!",
                    Email = "cindygates@gmail.com"},
                    
                    new User {FirstName="William", LastName="Johnston",
                    Biography ="Hey, I'm William. I'm originally from New York but moved to Seattle a few years ago for work. I'm a huge fan of historical fiction and non-fiction books, but I also enjoy thrillers and mysteries. I joined this book club to broaden my reading horizons and meet new people in my new city. I'm looking forward to getting to know everyone and discussing our latest book selection.",
                    Email = "williamjohnston@yahoo.com"},
                    
                    new User {FirstName="Aaron", LastName="Rosales",
                    Biography ="Hi, I'm Aaron. I'm a recent college graduate from Chicago, and I've always loved reading. My favorite genres are science fiction and fantasy, but I'm always willing to try something new. I joined this book club to meet other book lovers and explore different literary worlds. I'm excited to hear everyone's thoughts on our next book!",
                    Email = "aaronrosales@gmail.com"},
                    
                    new User {FirstName="Abbie", LastName="Hernandez",
                    Biography ="Hi, my name is Abbie. I'm a retired teacher living in a small town in Texas. I love reading historical fiction, biographies, and memoirs. I joined this book club to stay active and engage with other people who love to read. I'm really excited to dive into our next book and share my thoughts with everyone.",
                    Email ="abbiehernandez@gmail.com"},
                    
                    new User {FirstName="Billy", LastName="Hutcherson",
                    Biography = "Howdy, y'all! My name is Billy, and I'm from a small town in Georgia. I've always been a fan of thrillers and mysteries, but I'm open to reading all kinds of books. I joined this book club to meet new people and have some lively discussions about books. I'm excited to see what our next selection will be!",
                    Email ="billyhutcherson@yahoo.com"},
                    
                    new User {FirstName="Brenna", LastName="Scott",
                    Biography = "Hi, I'm Brenna! I'm a 28-year-old high school English teacher and avid reader. Some of my favorite genres include historical fiction, romance, and fantasy. When I'm not teaching or reading, you can usually find me hiking in the mountains or trying out new recipes in the kitchen.",
                    Email="brennascott@gmail.com"},
                    
                    new User {FirstName="Chad", LastName="Perry",
                    Biography = "My name is Chad and I'm a 32-year-old software engineer. I've always loved reading, and some of my favorite authors include Stephen King, Neil Gaiman, and J.K. Rowling. In my free time, I enjoy playing video games and watching movies.",
                    Email ="chadperry@gmail.com"},
                    
                    new User {FirstName="Jessica", LastName="Morrow",
                    Biography = "Hey there, I'm Jessica! I'm a 26-year-old graphic designer and book lover. I'm particularly fond of young adult fiction, but I also enjoy reading memoirs and non-fiction. When I'm not reading or designing, you can usually find me playing board games with my friends.",
                    Email ="jessicamorrow@icloud.com"},
                    
                    new User {FirstName="Grace", LastName="Lancaster",
                    Biography = "My name is Grace and I'm a 30-year-old librarian. As you can probably guess, I'm a huge bookworm and love all kinds of genres. I'm particularly interested in LGBTQ+ literature and books about social justice issues. When I'm not reading or working at the library, I enjoy hiking and camping.",
                    Email ="gracelancaster@icloud.com"},
                    
                    new User {FirstName="Chris", LastName="Scott",
                    Biography = "Hi, I'm Chris! I'm a 29-year-old freelance writer and aspiring novelist. I love reading and writing science fiction and fantasy, but I also enjoy mysteries and thrillers. In my free time, I like to play guitar and practice martial arts.",
                    Email = "chrisscott@gmail.com"},
                    
                    new User {FirstName="Hannah", LastName="Grauer",
                    Biography ="Hi, my name is Hannah and I'm an avid reader. I grew up in a small town and spent most of my childhood at the local library. I've always had a love for books and I knew from a young age that I wanted to work with them. I'm now a librarian and I'm so grateful to be surrounded by books every day. In my free time, I enjoy reading mystery novels and attending book clubs with my friends.",
                    Email = "hannahgrauer@gmail.com"},
                    
                    new User {FirstName="Joseph", LastName="McKinney",
                    Biography ="My name is Joseph and I've been a book lover for as long as I can remember. I grew up in a family that always encouraged reading, and I spent countless hours at the library as a child. As I got older, I started to appreciate the power of storytelling and the impact that books can have on people's lives. Now, as a member of a book club, I love discussing books with others and getting different perspectives on the stories we read.",
                    Email = "josephmckinney@icloud.com"},
                    
                    new User {FirstName="Cody", LastName="King",
                    Biography = "Hi, I'm Cody and I'm a book nerd. I've always been drawn to the world of literature, and I spend most of my free time reading. I love everything from classic literature to contemporary fiction, and I'm always on the lookout for my next great read. Being a part of a book club has been an amazing experience for me, as I get to share my love of books with others and hear their thoughts on the stories we read.",
                    Email ="codyking@gmail.com"},
                    
                    new User {FirstName="Dillon", LastName="Riley",
                    Biography = "My name is Dillon and I've always been a bit of a bookworm. I grew up with a love of reading and it's something that's stayed with me into adulthood. I find that books have a way of transporting me to another world and helping me forget about the stresses of everyday life. Being a part of a book club has been a great way to connect with other book lovers and share our thoughts and feelings about the stories we read.",
                    Email = "dillonriley@yahoo.com"},
                    
                    new User {FirstName="Haleigh", LastName="Caldwell",
                    Biography ="Hi, I'm Haleigh and I'm passionate about books. I've always been a reader, but it wasn't until college that I realized how much I loved literature. I studied English and became fascinated with the power of words and storytelling. Now, as a member of a book club, I love being able to share my thoughts and opinions on the books we read, and I'm always excited to discover new authors and stories.",
                    Email = "haleighcaldwell@gmail.com"},

                };
                context.AddRange(users);

                List<Book> books = new List<Book> {
                    new Book {Title = "The Silent Patient", Author = "Alex Michaelides", Publisher = "Celadon Books", 
                    PublicationDate = new DateOnly(2019, 2,5), ISBN = "987-1250301697", Genre = "Psychological Thriller",
                    BookDescription ="A psychotherapist tries to unravel the mytery of a patient who refuses to speak."},

                    new Book {Title = "An American Marriage", Author = "Tayari Jones", Publisher = "Algonquin Books",
                    PublicationDate = new DateOnly(2018, 2,6), ISBN = "978-1616208776", Genre = "Literary Fiction",
                    BookDescription = "A newlywed couple's marriage is tested when the husband is wronfully imprisoned."},

                    new Book {Title = "The Hunger Games", Author = "Suzanne Collins", Publisher = "Scholastic Press",
                    PublicationDate = new DateOnly(2008,9,14), ISBN = "978-0439023481", Genre ="Young Adult Dystopian Fiction",
                    BookDescription = "A teenage girl fights for survival in a government-controlled competition where only one can come out alive."},

                    new Book {Title = "The 7 Habits of Highly Effective People", Author = "Stephen Covey", Publisher = "Simon & Schuster",
                    PublicationDate = new DateOnly(1989,8,15), ISBN = "978-0671708634", Genre ="Self-help",
                    BookDescription = "A guide to achieving success and happiness through personal and professional development."},

                    new Book {Title = "Becoming", Author = "Michelle Obama", Publisher = "Crown Publishing Group",
                    PublicationDate = new DateOnly(2018,11,13), ISBN = "978-1524763138", Genre ="Memoir",
                    BookDescription = "The former First Lady of the United States shares her life story and reflects on her experiences in the White House."},

                    new Book {Title = "The Girl with the Dragon Tattoo", Author = "Stieg Larsson", Publisher="Vintage Crime/Black Lizard",
                    PublicationDate = new DateOnly(2008,9,16), ISBN = "987-0307454546", Genre = "Crime Fiction",
                    BookDescription = "A journalist and a young computer hacker team up to investigate a decades-old disappearance"},

                    new Book {Title = "To Kill a Mockingbird", Author = "Harper Lee", Publisher = "J.B. Lippincott & Co.", 
                    PublicationDate = new DateOnly(1960,7,11), ISBN = "978-0446310789", Genre = "Literary Fiction",
                    BookDescription = "A young girl learns about racism and injustice in her small Alabama town during the 1930s."},

                    new Book {Title = "1984", Author = "George Orwell", Publisher = "Secker and Warburg", 
                    PublicationDate = new DateOnly(1949,6,8), ISBN = "978-0452284234", Genre = "Dystopian Fiction",
                    BookDescription = "A man rebels against a totalitarian regime that seeks to control every aspect of people's lives."},

                    new Book {Title = "The Martian", Author = "Andy Weir", Publisher = "Crown Publishing Group", 
                    PublicationDate = new DateOnly(2014,2,11), ISBN = "978-0553418026", Genre = "Science Fiction",
                    BookDescription = "An astronaut is stranded on Mars and must use his knowledge and resourcefulness to survive."},
                    
                    new Book {Title = "The Alchemist", Author = "Paulo Coelho", Publisher = "HarperCollins", 
                    PublicationDate = new DateOnly(1988,5,2), ISBN = "978-0061122415", Genre = "Inspirational Fiction",
                    BookDescription = "A young shepherd embarks on a journey to fulfill his destiny and discovers the importance of following his dreams."},

                    new Book {Title = "The Catcher in the Rye", Author = "J.D. Sallinger", Publisher ="Little, Brown and Company",
                    PublicationDate = new DateOnly(1951,3,6), ISBN = "978-0316769488", Genre = "Coming-of-age Fiction",
                    BookDescription = "A teenage boy navigates the challenges of adolescence and struggles to find his place in the world."},

                    new Book {Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Publisher = "Charles Scribner's Sons", 
                    PublicationDate = new DateOnly(1925,6,1), ISBN = "978-0743273565", Genre = "Jazz Age Fiction",
                    BookDescription = "A mysterious millionaire throws extravagant parties in an attempt to win back the love of his life."},

                    new Book {Title = "The Handmaid's Tale", Author = "Margaret Atwood", Publisher = "McClelland and Stewart",
                    PublicationDate = new DateOnly(1985,6,3), ISBN = "978-0385490818", Genre = "Dystopian Fiction", 
                    BookDescription = "In a future society where fertility rates have plummeted, a woman is forced to serve as a handmaid and bear children for a powerful couple."},

                    new Book {Title = "The Silent Patient", Author = "Alex Michaelides", Publisher = "Celadon Books", 
                    PublicationDate = new DateOnly(2019,8,25), ISBN = "978-1250301697", Genre = "Psychological Thriller",
                    BookDescription = "A woman is accused of murdering her husband and stops speaking altogether, leading her therapist to uncover the dark secrets of her past."},

                    new Book {Title = "Gone Girl", Author = "Gillian Flynn", Publisher = "Crown Publishing Group",
                    PublicationDate = new DateOnly(2012,6,5), ISBN = "978-0307588364", Genre = "Psychological Thriller",
                    BookDescription = "On their fifth wedding anniversary, Nick's wife Amy disappears. As the police investigate, secrets and lies are exposed that lead Nick to wonder whether he ever truly knew his wife at all."},

                    new Book {Title = "Ender's Game", Author = "Orson Scott Card", Publisher = "Tor Books",
                    PublicationDate = new DateOnly(1985,1,15), ISBN = "978-0812550702", Genre = "Science Fiction",
                    BookDescription = "In a future where humanity is threatened by an alien race, young Ender Wiggin is recruited to attend Battle School, where he trains to become a commander capable of defeating the enemy."},

                    new Book {Title = "The Notebook", Author = "Nicholas Sparks", Publisher = "Warner Books",
                    PublicationDate = new DateOnly(1996,10,1), ISBN = "978-0446605236", Genre = "Romance",
                    BookDescription = "A man reads a notebook to an elderly woman in a nursing home, telling the story of two young lovers separated by war and class differences, who must overcome obstacles to be together."},

                    new Book {Title = "The Calculating Stars", Author = "Mary Robinette Kowal", Publisher = "Tor Books", 
                    PublicationDate = new DateOnly(2018,7,3), ISBN = "978-0765378385", Genre = "Science Fiction", 
                    BookDescription = "A meteorite strikes Earth in the 1950s and causes catastrophic damage, leading a former WASP pilot to join the effort to colonize space."},

                    new Book {Title = "Dune", Author = "Frank Herbert", Publisher = "Chilton Books",
                    PublicationDate = new DateOnly(1965,8,1), ISBN = "978-0441172719", Genre = "Science Fiction",
                    BookDescription = "In a distant future, noble families fight for control of the desert planet Arrakis, the only source of the spice melange, a drug that grants heightened abilities and is essential for interstellar travel."},

                    new Book {Title = "Dune", Author = "Frank Herbert", Publisher = "Chilton Books",
                    PublicationDate = new DateOnly(1965,8,1), ISBN = "978-0441172719", Genre = "Science Fiction",
                    BookDescription = "In a distant future, noble families fight for control of the desert planet Arrakis, the only source of the spice melange, a drug that grants heightened abilities and is essential for interstellar travel."},

                    new Book {Title = "The Woman in the Window", Author = "A.J. Finn", Publisher = "William Morrow",
                    PublicationDate = new DateOnly(2018,1,2), ISBN = "978-0062799555", Genre = "Psychological Thriller",
                    BookDescription = "An agoraphobic woman spends her days watching her neighbors, and when she witnesses a crime, no one believes her due to her mental illness."},

                    new Book {Title = "The Time Traveler's Wife", Author = "Audrey Niffenegger", Publisher = "MacAdam/Cage",
                    PublicationDate = new DateOnly(2003,9,1), ISBN = "978-1931561464", Genre = "Romance",
                    BookDescription = "A man with a genetic disorder that causes him to time travel involuntarily falls in love with a woman, and they must navigate the difficulties of their relationship across time."},

                    new Book {Title = "The Haunting of Hill House", Author = "Shirley Jackson", Publisher = "Viking Press",
                    PublicationDate = new DateOnly(1959,10,16), ISBN = "978-0143039983", Genre = "Psychological Thriller",
                    BookDescription = "Four people spend a summer in a haunted mansion to study supernatural phenomena, but the house's influence begins to drive them to madness and despair."},


                    new Book {Title = "Recursion", Author = "Blake Crouch", Publisher = "Crown Publishing Group",
                    PublicationDate = new DateOnly(2019,6,11), ISBN = "978-1524759780", Genre = "Science Fiction",
                    BookDescription = "A scientist creates a technology that allows people to go back in time and relive their memories, but the consequences are disastrous."},

                    new Book {Title = "Behind Closed Doors", Author = "B.A. Paris", Publisher = "St. Martin's Press",
                    PublicationDate = new DateOnly(2016,8,9), ISBN = "978-1250121004", Genre = "Psychological Thriller",
                    BookDescription = "A seemingly perfect couple has a dark and disturbing secret behind closed doors."},

                    new Book {Title = "The Nightingale", Author = "Kristin Hannah", Publisher = "St. Martin's Press",
                    PublicationDate = new DateOnly(2015,2,3), ISBN = "978-0312577223", Genre = "Romance",
                    BookDescription = "Two sisters in Nazi-occupied France fight to survive and resist the German occupation in different ways."},

                    new Book {Title = "The Bone Clocks", Author = "David Mitchell", Publisher = "Random House",
                    PublicationDate = new DateOnly(2014,9,2), ISBN = "978-1400065677", Genre = "Science Fiction",
                    BookDescription = "A young woman discovers she has psychic powers and becomes embroiled in a secret war between two immortal factions."},

                    new Book {Title = "The Couple Next Door", Author = "Shari Lapena", Publisher = "Penguin Books",
                    PublicationDate = new DateOnly(2016,8,23), ISBN = "978-0735221086", Genre = "Psychological Thriller",
                    BookDescription = "A couple's baby is kidnapped while they attend a dinner party next door, and they become the prime suspects in the investigation."},

                    new Book {Title = "Ready Player Two", Author = "Ernest Cline", Publisher = "Ballantine Books",
                    PublicationDate = new DateOnly(2020,11,24), ISBN = "978-1524761332", Genre = "Science Fiction",
                    BookDescription = "In this sequel to Ready Player One, the protagonist must once again navigate a virtual world filled with puzzles and danger."},

                    new Book {Title = "The Seven Husbands of Evelyn Hugo", Author = "Taylor Jenkins Reid", Publisher = "Atria Books",
                    PublicationDate = new DateOnly(2017,6,13), ISBN = "978-1501139239", Genre = "Romance",
                    BookDescription = "A legendary Hollywood actress recounts her tumultuous life and loves to a young journalist."},

                    new Book {Title = "The Testaments", Author = "Margaret Atwood", Publisher = "Nan A. Talese",
                    PublicationDate = new DateOnly(2019,9,10), ISBN = "978-0385543781", Genre = "Science Fiction",
                    BookDescription = "A sequel to The Handmaid's Tale, this novel follows the lives of three women living in Gilead."},

                    new Book {Title = "The Starless Sea", Author = "Erin Morgenstern", Publisher = "Doubleday",
                    PublicationDate = new DateOnly(2019,11,5), ISBN = "978-0385541213", Genre = "Fantasy",
                    BookDescription = "A graduate student discovers a mysterious book that leads him on a journey through a magical underground library."},

                    new Book {Title = "The Vanishing Half", Author = "Brit Bennett", Publisher = "Riverhead Books",
                    PublicationDate = new DateOnly(2020,6,2), ISBN = "978-0525536291", Genre = "Historical Fiction",
                    BookDescription = "Twin sisters run away from their small town and go on to lead very different lives, one passing as white."},

                    new Book {Title = "The Memory Police", Author = "Yoko Ogawa", Publisher = "Pantheon",
                    PublicationDate = new DateOnly(2019,8,13), ISBN = "978-1101870600", Genre = "Science Fiction",
                    BookDescription = "In a world where objects disappear and memories are erased, a young writer fights to hold on to her own memories and identity."},

                    new Book {Title = "The Guest List", Author = "Lucy Foley", Publisher = "William Morrow",
                    PublicationDate = new DateOnly(2020,6,2), ISBN = "978-0062868930", Genre = "Psychological Thriller",
                    BookDescription = "A wedding on a remote island turns deadly when one of the guests is murdered, and everyone becomes a suspect."},

                    new Book {Title = "Daisy Jones & The Six", Author = "Taylor Jenkins Reid", Publisher = "Ballantine Books",
                    PublicationDate = new DateOnly(2019,3,5), ISBN = "978-1524798628", Genre = "Romance",
                    BookDescription = "The rise and fall of a fictional 1970s rock band, told through interviews with the band members and those close to them."},

                    new Book {Title = "Recursion", Author = "Blake Crouch", Publisher = "Crown Publishing Group",
                    PublicationDate = new DateOnly(2019,6,11), ISBN = "978-1524759780", Genre = "Science Fiction",
                    BookDescription = "A scientist develops a technology that can preserve memories and allows people to relive their lives, but the consequences are dire."},

                    new Book {Title = "The Nightingale", Author = "Kristin Hannah", Publisher = "St. Martin's Press",
                    PublicationDate = new DateOnly(2015,2,3), ISBN = "978-0312577223", Genre = "Romance",
                    BookDescription = "Two sisters struggle to survive and resist during the German occupation of France in World War II."},

                    new Book {Title = "The Hunting Party", Author = "Lucy Foley", Publisher = "William Morrow",
                    PublicationDate = new DateOnly(2019,2,12), ISBN = "978-0062868909", Genre = "Psychological Thriller",
                    BookDescription = "A group of friends gather at a remote hunting lodge for New Year's Eve, but their celebrations turn deadly when one of them is murdered."},

                    new Book {Title = "The Three-Body Problem", Author = "Liu Cixin", Publisher = "Tor Books",
                    PublicationDate = new DateOnly(2014,11,11), ISBN = "978-0765377067", Genre = "Science Fiction",
                    BookDescription = "An alien civilization is discovered and threatens to invade Earth, forcing humans to confront their place in the universe."},

                    new Book {Title = "The Wedding Date", Author = "Jasmine Guillory", Publisher = "Berkley Books",
                    PublicationDate = new DateOnly(2018,1,30), ISBN = "978-0399587665", Genre = "Romance",
                    BookDescription = "Two strangers meet in an elevator and spontaneously agree to be each other's date for a wedding, but their fake relationship soon becomes real."},

                    new Book {Title = "The Midnight Library", Author = "Matt Haig", Publisher = "Canongate Books", 
                    PublicationDate = new DateOnly(2020,8,13), ISBN = "978-1786892737", Genre = "Magical Realism", 
                    BookDescription = "A woman who attempts suicide is transported to a library where each book represents a different life she could have lived."},

                    new Book {Title = "The Year of the Flood", Author = "Margaret Atwood", Publisher = "Nan A. Talese", 
                    PublicationDate = new DateOnly(2009,9,22), ISBN = "978-0307397980", Genre = "Dystopian Fiction", 
                    BookDescription = "A companion novel to Oryx and Crake, following two women who survive a global pandemic and are members of a religious group called God's Gardeners."},

                    new Book {Title = "The Power", Author = "Naomi Alderman", Publisher = "Viking", 
                    PublicationDate = new DateOnly(2016,10,27), ISBN = "978-0670919963", Genre = "Science Fiction", 
                    BookDescription = "In a world where women develop the ability to release electrical jolts from their fingertips, gender roles are reversed and society is upended."},

                    new Book {Title = "The Water Dancer", Author = "Ta-Nehisi Coates", Publisher = "One World", 
                    PublicationDate = new DateOnly(2019,9,24), ISBN = "978-0399590597", Genre = "Historical Fiction", 
                    BookDescription = "A young enslaved man with a mysterious power is recruited into the Underground Railroad and discovers a magical world beyond imagination."},

                    new Book {Title = "The Overstory", Author = "Richard Powers", Publisher = "W. W. Norton & Company", 
                    PublicationDate = new DateOnly(2018,4,3), ISBN = "978-0393635522", Genre = "Environmental Fiction", 
                    BookDescription = "An epic novel about nine Americans whose unique life experiences with trees bring them together to fight for the last remaining forests."},
                    };
                context.AddRange(books);

                List<UserBook> bookshelf = new List<UserBook> {
                    new UserBook {UserId = 1, BookId = 1},
                    new UserBook {UserId = 1, BookId = 2},
                    new UserBook {UserId = 2, BookId = 3},
                    new UserBook {UserId = 3, BookId = 4},
                    new UserBook {UserId = 4, BookId = 5},
                    new UserBook {UserId = 4, BookId = 6},
                    new UserBook {UserId = 5, BookId = 7},
                    new UserBook {UserId = 6, BookId = 8},
                    new UserBook {UserId = 7, BookId = 9},
                    new UserBook {UserId = 7, BookId = 10},
                    new UserBook {UserId = 7, BookId = 11},
                    new UserBook {UserId = 8, BookId = 12},
                    new UserBook {UserId = 9, BookId = 13},
                    new UserBook {UserId = 9, BookId = 14},
                    new UserBook {UserId = 10, BookId = 15},
                    new UserBook {UserId = 11, BookId = 16},
                    new UserBook {UserId = 12, BookId = 17},
                    new UserBook {UserId = 13, BookId = 18},
                    new UserBook {UserId = 13, BookId = 19},
                    new UserBook {UserId = 14, BookId = 20},
                    new UserBook {UserId = 15, BookId = 21},
                    new UserBook {UserId = 16, BookId = 22},
                    new UserBook {UserId = 16, BookId = 23},
                    new UserBook {UserId = 16, BookId = 24},
                    new UserBook {UserId = 16, BookId = 25},
                    new UserBook {UserId = 17, BookId = 26},
                    new UserBook {UserId = 18, BookId = 27},
                    new UserBook {UserId = 19, BookId = 28},
                    new UserBook {UserId = 20, BookId = 29},
                    new UserBook {UserId = 20, BookId = 30},
                    new UserBook {UserId = 20, BookId = 31},
                    new UserBook {UserId = 20, BookId = 32},
                    new UserBook {UserId = 20, BookId = 33},
                    new UserBook {UserId = 2, BookId = 34},
                    new UserBook {UserId = 2, BookId = 35},
                    new UserBook {UserId = 2, BookId = 36},
                    new UserBook {UserId = 3, BookId = 37},
                    new UserBook {UserId = 6, BookId = 38},
                    new UserBook {UserId = 5, BookId = 39},
                    new UserBook {UserId = 10, BookId = 40},
                    new UserBook {UserId = 11, BookId = 41},
                    new UserBook {UserId = 15, BookId = 42},
                    new UserBook {UserId = 16, BookId = 43},
                    new UserBook {UserId = 18, BookId = 44},
                    new UserBook {UserId = 9, BookId = 45},
                    new UserBook {UserId = 9, BookId = 46},
                    new UserBook {UserId = 5, BookId = 1},
                    new UserBook {UserId = 5, BookId = 2},

                };
                context.AddRange(bookshelf);

                context.SaveChanges();
            }
        }
    }
}