using Travel.Core.Entities;

namespace Travel.Infrastructure.Data
{
    public static class SeedData
    {
        public static Author[] GetAuthors()
        {
            return new[] {
                new Author {
                    Id = 1000000000,
                    FirstName = "Gabriel",
                    LastName = "Garcia Marquez"
                },
                new Author {
                    Id = 1000000001,
                    FirstName = "Cynthia",
                    LastName = "Hand"
                },
                new Author {
                    Id = 1000000002,
                    FirstName = "Brodi",
                    LastName = "Ashton"
                },
                new Author {
                    Id = 1000000003,
                    FirstName = "Jodi",
                    LastName = "Meadows"
                }
            };
        }

        public static Book[] GetBooks()
        {
            return new[]
            {
                new Book
                {
                    Isbn = 9780060114183,
                    EditorialId = 1000000000,
                    Title = "One Hundred Years of Solitude",
                    Synopsis = "A best seller and critical success in Latin America, Europe, and the United States, One Hundred Years of Solitude tells the story of the rise and fall, birth and death of teh mythical town of Macondo through the history of the Buendia family. It is a rich and billiant chronicle of life and death and the tragicomedy of man. In the noble, ridiculous, beautiful, and tawdry story of the Buendia family one sees all mankind, just as in the history, myths, growth, and decay of Macondo one sees all of Latin America.\nLove and lust, war and revolution, reiches and poverty, youth and senility--the variety of life, the endlessness fo death, the search for peace and truth--these, the universal themes, dominate the novel.Whether he is describing an affair of passion or the voracity of capitalism and the corruption of government, Garcia Marquez always writes with the simplicity, ease, and purity that are the mark fo a master.Inventive, amusing, magnetic, sad, alive with unforgettale men and women, and with a truth and understanding that strike the soul, One Hundred Years of Solitude is a masterpiece of the art of fiction.\n“synopsis” may belong to another edition of this title.",
                    Pages = "504"
                },
                new Book
                {
                    Isbn = 9781400034710,
                    EditorialId = 1000000001,
                    Title = "Chronicle of a Death Foretold",
                    Synopsis = "A man returns to the town where a baffling murder took place 27 years earlier, determined to get to the bottom of the story. Just hours after marrying the beautiful Angela Vicario, everyone agrees, Bayardo San Roman returned his bride in disgrace to her parents. Her distraught family forced her to name her first lover; and her twin brothers announced their intention to murder Santiago Nasar for dishonoring their sister.\nYet if everyone knew the murder was going to happen, why did no one intervene to stop it? The more that is learned, the less is understood, and as the story races to its inexplicable conclusion, an entire society--not just a pair of murderers—is put on trial.",
                    Pages = "128"
                },
                new Book
                {
                    Isbn = 9780062930040,
                    EditorialId = 1000000002,
                    Title = "My Contrary Mary",
                    Synopsis = "Long live the queen: The authors who brought you the New York Times bestselling My Lady Jane kick off an all-new historical trilogy with the classy, courtly tale of Mary, Queen of Scots.\nWelcome to Renaissance France, a place of poison and plots, of beauties and beasts, of mice and . . . queens?\nMary is the queen of Scotland and the jewel of the French court. Except when she’s a mouse. Yes, reader, Mary is an Eðian (shapeshifter) in a kingdom where Verities rule. It’s a secret that could cost her a head—or a tail.\nLuckily, Mary has a confidant in her betrothed, Francis. But things at the gilded court take a treacherous turn after the king meets a suspicious end. Thrust onto the throne, Mary and Francis face a viper’s nest of conspiracies, traps, and treason. And if Mary’s secret is revealed, heads are bound to roll.\nWith a royally clever sense of humor, Cynthia Hand, Brodi Ashton, and Jodi Meadows continue their campaign to turn history on its head in this YA fantasy that’s perfect for fans of A Gentleman’s Guide to Vice and Virtue.",
                    Pages = "512"
                }
            };
        }

        public static Editorial[] GetEditorials()
        {
            return new[]
            {
                new Editorial
                {
                    Id = 1000000000,
                    Name = "Harper & Row",
                    Headquarters = "North"
                },
                new Editorial
                {
                    Id = 1000000001,
                    Name = "Vintage",
                    Headquarters = "Main"
                },
                new Editorial
                {
                    Id = 1000000002,
                    Name = "Harper Teen",
                    Headquarters = "South"
                }
            };
        }

        public static object[] GetAuthorsBooks()
        {
            return new object[]
            {
                new
                {
                    AuthorsId = (long)1000000000,
                    BooksIsbn = 9780060114183
                },
                new
                {
                    AuthorsId = (long)1000000000,
                    BooksIsbn = 9781400034710
                },
                new
                {
                    AuthorsId = (long)1000000001,
                    BooksIsbn = 9780062930040
                },
                new
                {
                    AuthorsId = (long)1000000002,
                    BooksIsbn = 9780062930040
                },
                new
                {
                    AuthorsId = (long)1000000003,
                    BooksIsbn = 9780062930040
                }
            };
        }
    }
}
