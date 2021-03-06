namespace BookService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
                new Author() { Id = 1, Name = "Jane Austen" },
                new Author() { Id = 2, Name = "Charles Dickens" },
                new Author() { Id = 3, Name = "Miguel de Cervantes" },
                new Author() { Id = 4, Name = "Thomas" },
                new Author() { Id = 5, Name = "Cookie Monster" },
                new Author() { Id = 6, Name = "Hugo" },
                new Author() { Id = 7, Name = "Muffin Monster" }
                );

            context.Genres.AddOrUpdate(x => x.Id,
                new Genre() { Id = 1, Name = "Comedy of manners"},
                new Genre() { Id = 2, Name = "Gothic parody" },
                new Genre() { Id = 3, Name = "Bildungsroman" },
                new Genre() { Id = 4, Name = "Picaresque" },
                new Genre() { Id = 5, Name = "Educational"},
                new Genre() { Id = 6, Name = "Drama", Description = "Ett l�sdrama �r ett litter�rt verk i dramatisk form, men som anses ol�mpligt att uppf�ras p� scenen, utan i st�llet �r t�nkt att l�sas. Begreppet l�sdrama har sitt ursprung i romantikens litteratur d� man g�rna blandade genrer. Dramer som ursprungligen skrevs som l�sdramer har med senare teknik och estetik gjorts spelbara p� teatern. Exempel p� detta �r Carl Jonas Love Almqvists Drottningens juvelsmycke och Amorina. Ett drama som ofta omtalats som l�sdrama �r Johann Wolfgang von Goethes Faust, speciellt del tv�. Goethe misslyckades sj�lv s�tta upp Faust (del ett) p� hovteatern i Weimar och tvivlade d�rf�r p� att det var m�jligt. Men redan under hans livstid gjordes upps�ttningar p� andra teatrar. 1819 uppf�rdes scener ur dramat p� lustslottet Monbijou i Berlin. F�rest�llningen regisserades av greve Carl von Br�hl och huvudrollen spelades av Pius Alexander Wolff som studerat den f�r Goethe sj�lv. 1829 skedde urpremi�ren av del ett i sin helhet p� hovteatern i Braunschweig i regi av August Klingemann. Denna f�rest�llning turnerade i Tyskland och en version av den uppf�rdes i Weimar i samband med Goethes 80-�rsdag."},
                new Genre() { Id = 7, Name = "Comedy", Description = "Refers to any discourse or work generally intended to be humorous or to amuse by inducing laughter, especially in theatre, television, film and stand-up comedy. The origins of the term are found in Ancient Greece. In the Athenian democracy, the public opinion of voters was influenced by the political satire performed by the comic poets at the theaters. The theatrical genre of Greek comedy can be described as a dramatic performance which pits two groups or societies against each other in an amusing agon or conflict. Northrop Frye depicted these two opposing sides as a Society of Youth and a Society of the Old,.[2] A revised view characterizes the essential agon of comedy as a struggle between a relatively powerless youth and the societal conventions that pose obstacles to his hopes. In this struggle, the youth is understood to be constrained by his lack of social authority, and is left with little choice but to take recourse in ruses which engender very dramatic irony which provokes laughter.[3] Satire and political satire use comedy to portray persons or social institutions as ridiculous or corrupt, thus alienating their audience from the object of their humor. Parody subverts popular genres and forms, critiquing those forms without necessarily condemning them. Other forms of comedy include Screwball comedy, which derives its humor largely from bizarre, surprising (and improbable) situations or characters, and Black comedy, which is characterized by a form of humor that includes darker aspects of human behavior or human nature. Similarly scatological humor, sexual humor, and race humor create comedy by violating social conventions or taboos in comic ways. A comedy of manners typically takes as its subject a particular part of society (usually upper class society) and uses humor to parody or satirize the behavior and mannerisms of its members. Romantic comedy is a popular genre that depicts burgeoning romance in humorous terms and focuses on the foibles of those who are falling in love."}

                );

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "Pride and Prejudice",
                    Year = 1813,
                    Price = 9.99M,
                    StockBalance = 1,
                    ISBN = "1234567890123"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Northanger Abbey",
                    Year = 1817,
                    Price = 12.95M,
                    StockBalance = 1,
                    ISBN = "1234567890002"
                },
                new Book()
                {
                    Id = 3,
                    Title = "David Copperfield",
                    Year = 1850,
                    Price = 15,
                    StockBalance = 1,
                    ISBN = "1234567890003"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Don Quixote",
                    Year = 1617,
                    Price = 8.95M,
                    StockBalance = 1,
                    ISBN = "1234567890004"
                },
                new Book()
                {
                    Id = 5,
                    Title = "The great adventure of C#",
                    Year = 2017,
                    Price = 5000,
                    StockBalance = 1,
                    ISBN = "1234567890005"
                },
                new Book()
                {
                    Id = 6,
                    Title = "That's the way the cookie crumbles!",
                    Year = 2050,
                    Price = 200,
                    StockBalance = 42,
                    ISBN = "1234567890006"
                },
                new Book()
                {
                    Id = 7,
                    Title = "Cookie Monster's guide for world domination!",
                    Year = 2042,
                    Price = 3000,
                    StockBalance = 42,
                    ISBN = "1234567890007"
                },
                new Book()
                {
                    Id = 8,
                    Title = "Hugo's guide to JavaScript!",
                    Year = 2016,
                    Price = 300,
                    StockBalance = 6,
                    ISBN = "1234567890008"
                }
                );
           /* context.BookGenreConnections.AddOrUpdate(x => x.Id,
              new BookGenreConnection() { Id = 1, BookId  = 1, GenreId = 1 },
              new BookGenreConnection() { Id = 2, BookId  = 2, GenreId = 1 },
              new BookGenreConnection() { Id = 3, BookId  = 3, GenreId = 2 },
              new BookGenreConnection() { Id = 4, BookId  = 4, GenreId = 2 },
              new BookGenreConnection() { Id = 5, BookId  = 5, GenreId = 7 }

              );

           context.BookAuthorConnections.AddOrUpdate(x => x.Id,
              new BookAuthorConnection() { Id = 1, BookId  = 1, AuthorId = 1 },
              new BookAuthorConnection() { Id = 2, BookId  = 2, AuthorId = 1 },
              new BookAuthorConnection() { Id = 3, BookId  = 3, AuthorId = 2 },
              new BookAuthorConnection() { Id = 4, BookId  = 4, AuthorId = 2 },
              new BookAuthorConnection() { Id = 5, BookId  = 5, AuthorId = 4 }

              );  */
            // Cookies!
        }
    }
}
