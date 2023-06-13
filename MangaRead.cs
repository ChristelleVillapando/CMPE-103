using System;
using System.Collections.Generic;
using System.Linq;
class MangaRead
{
    static void Main (string[] args)
    {
        string password = "707";
        while (true)
        {   
            Console.Write("Enter your password: ");
            string input = Console.ReadLine();
            if (input == password)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|    Hello! Welcome to MangaRead!        |");
                Console.WriteLine("-----------------------------------------");
                break;

            }
            else 
            {
                Console.WriteLine("Incorrect password. Please try again.");

            }

        }
        mangaView();


    }

    static void mangaView()
    {
        List<string> mangaTitle = new List<string>();
        List<Manga> mangaList = new List<Manga>();
      
        mangaTitle.Add("Attack on Titan");
        mangaTitle.Add("My Hero Acadmia");
        mangaTitle.Add("Fairy Tail");
        mangaTitle.Add("Spy x Family");
        mangaTitle.Add("One Punch Man");
        mangaTitle.Add("Evil Lady's Hero");
        mangaTitle.Add("Survive as the Hero's Wife");
        mangaTitle.Add("Miniamaru Kareshi");
        mangaTitle.Add("Isekai Kuimetsu no Same");
        mangaTitle.Add("Inuyasha");
        mangaTitle.Add("Hanabi wa Samenai Yume wo miru");
        mangaTitle.Add("Kamisama Kiss");
        mangaTitle.Add("The Wallflower");
        mangaTitle.Add("Ouran High School Host Club");
        mangaTitle.Add("Hotaru no Yomeiri");
        mangaTitle.Add("Kyuuseishu <<MESHIA>>~Isekai wo sukutta moto yuusha ga mamono no afureru genjitsu sekai wo musuo suru");
        mangaTitle.Add("Kaicho wa Maid-sama!");
        mangaTitle.Add("Meido no koi wa enma shidai");
        mangaTitle.Add("Yamada-kun to Lv999 No Koi wo Suru");
        mangaTitle.Add("Nurarihyon no Hanayome");
        mangaTitle.Add("Namaikizakari");
        mangaTitle.Add("Raise wa Tanin ga li");
        mangaTitle.Add("Sakamoto Days");
        mangaTitle.Add("Doctor Elise");
        mangaTitle.Add("The Reason Why Raelina Ended up at the Duke's Mansion");
        mangaTitle.Add("How to Get My Husband on My Side");
        mangaTitle.Add("Suddenly Became a Princess One Day");
        mangaTitle.Add("Eleceed");
        mangaTitle.Add("The Greatest Estate Designer");
        mangaTitle.Add("Solo Leveling");
        
        
        mangaList.Add(new Manga() {Title = "Attack on Titan", Genre = new List<string> {"Action", "Shounen", "Drama", "Fantasy" }});
        mangaList.Add(new Manga() {Title = "My Hero Academia", Genre = new List<string> { "Shounen", "Comedy", "Action" }});
        mangaList.Add(new Manga() {Title = "Fairy Tail", Genre = new List<string> {"Fantasy", "Comedy", "Action", "Shounen", "Adventure" }});
        mangaList.Add(new Manga() {Title = "Spy x Family", Genre = new List<string> {"Comedy", "Action" }});
        mangaList.Add(new Manga() {Title = "One Punch Man", Genre = new List<string> {"Adventure", "Action", "Comedy", "Fantasy" }});
        mangaList.Add(new Manga() {Title = "Evil Lady's Hero", Genre = new List<string> {"Romance", "Fantasy" }});
        mangaList.Add(new Manga() {Title = "Survive as the Hero's Wife", Genre = new List<string> {"Romance","Comedy" }});
        mangaList.Add(new Manga() {Title = "Miniamaru Kareshi", Genre = new List<string> {"Romance", "School Life", "Shoujo" }});
        mangaList.Add(new Manga() {Title = "Isekai Kuimetsu no Same", Genre = new List<string> {"Action", "Adventure","Comedy", "Fantasy", "Horror", "Supernatural" }});
        mangaList.Add(new Manga() {Title = "Inuyasha", Genre = new List<string> {"Adventure", "Comedy", "Fantasy", "Historical", "Romance", "Supernatural" }});
        mangaList.Add(new Manga() {Title = "Hanabi wa Samenai Yume wo miru", Genre = new List<string> { "Romance", "School Life" }});
        mangaList.Add(new Manga() {Title = "Kamisama Kiss", Genre = new List<string> {"Romance", "Comedy", "Fantasy" }});
        mangaList.Add(new Manga() {Title = "The Wallflower", Genre = new List<string> {"Romance", "Horror", "Action", "Comedy" }});
        mangaList.Add(new Manga() {Title = "Ouran High School Host Club", Genre = new List<string> {"Drama", "Romance", "Comedy" }});
        mangaList.Add(new Manga() {Title = "Hotaru no Yomeiri", Genre = new List<string> {"Historical", "Romance" }});
        mangaList.Add(new Manga() {Title = "Kyuuseishu <<MESHIA>>~Isekai wo sukutta moto yuusha ga mamono no afureru genjitsu sekai wo musuo suru", Genre = new List<string> {"Action", "Fantasy", "Romance" }});
        mangaList.Add(new Manga() {Title = "Kaicho wa Maid-sama! ", Genre = new List<string> {"Shoujo", "Romance", "Comedy" }});
        mangaList.Add(new Manga() {Title = "Meido no koi wa enma shidai", Genre = new List<string> {"Shoujo", "Comedy", "Fantasy", "Romance" }});
        mangaList.Add(new Manga() {Title = "Yamada-kun to Lv999 No Koi wo Suru", Genre = new List<string> {"Comedy", "Shoujo", "Romance", "Slice of Life" }});
        mangaList.Add(new Manga() {Title = "Nurarihyon no Hanayome", Genre = new List<string> {"Fantasy", "Historical", "Romance", "Shoujo", "Supernatural" }});
        mangaList.Add(new Manga() {Title = "Namaikizakari ", Genre = new List<string> {"Shoujo", "Comedy", "Romance", "School Life" }});
        mangaList.Add(new Manga() {Title = "Raise wa Tanin ga li", Genre = new List<string> {"Josei", "Romance", "Drama", "Psychological", "School Life", "Seinen" }});
        mangaList.Add(new Manga() {Title = "Sakamoto Days", Genre = new List<string> {"Shounen", "Action", "Comedy", "Slife of Life", "Supernatural" }});
        mangaList.Add(new Manga() {Title = "Doctor Elise", Genre = new List<string> {"Shoujo", "Fantasy", "Historical", "Romance" }});
        mangaList.Add(new Manga() {Title = "The Reason Why Raelina Ended up at the Duke's Mansion", Genre = new List<string> {"Completed", "Shoujo", "Fantasy", "Comedy", "Mystery", "Romance", "Historical", "Webtoon" }});
        mangaList.Add(new Manga() {Title = "How to Get My Husband on My Side", Genre = new List<string> {"Shoujo", "Historical", "Romance", "Drama", "Fantasy" }});
        mangaList.Add(new Manga() {Title = "Suddenly Became a Princess One Day", Genre = new List<string> {"Completed", "Shoujo", "Fantasy", "Historical", "Drama", "Webtoon" }});
        mangaList.Add(new Manga() {Title = "Eleceed", Genre = new List<string> {"Action", "Adventure", "Fantasy", "Shounen", "Webtoon"}});
        mangaList.Add(new Manga() {Title = "The Greatest Estate Designer", Genre = new List<string> {"Adventure", "Fantasy", "Shounen", "Comedy" }});
        mangaList.Add(new Manga() {Title = "Solo Leveling", Genre = new List<string> {"Action", "Adventure", "Fantasy", "Webtoon"}});

         

        while (true)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|    1. Manga Directory                  |");
            Console.WriteLine("|    2. Genre                            |");
            Console.WriteLine("|    0. Exit                             |");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Select an option:    ");
            string input = Console.ReadLine();
            


            if (input == "1")
            {
                Console.WriteLine(" -----------------------------------------");
                Console.WriteLine("|        Welcome to Manga Directory!      |");
                Console.WriteLine(" -----------------------------------------");
                // save and search for manga
                while (true)
                {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|    1. Search Manga.                    |");
                Console.WriteLine("|    2. Save Manga.                      |");
                Console.WriteLine("|    0. Return to Main Page.             |");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Select an option. ");
                string mangaDir = Console.ReadLine();
             
                if (mangaDir == "1")
                {
                    Console.WriteLine(" -----------------------------------------");
                    Console.WriteLine("| Enter the title you want to search:     |");
                    Console.WriteLine(" -----------------------------------------");
                    Console.Write("Manga Title:  ");
                    var mangaTitleSearch = Console.ReadLine();
                    if (mangaTitle.Contains(mangaTitleSearch))
                    {
                        Console.WriteLine("                                 ");
                        Console.WriteLine("Title found! ");
                        Console.WriteLine("                                 ");
                        // can add option, do you want to save?
                        //a seperate option for saved mangas
                    }
                    else 
                    {
                        Console.WriteLine("                                 ");
                        Console.WriteLine("Title not found");
                        Console.WriteLine("                                 ");
                        //"you might be looking for"
                        //list of manga with similar name or same key words
                    }        
                }
                else if (mangaDir == "2")
                {
                    //save manga
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("How many manga do you want to save?   ");
                    int numberOfManga = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i = 0; i < numberOfManga; i++ )
                    {
                        Console.Write($"Input the Title of Manga {i + 1} : ");
                        var title = Console.ReadLine();
                        mangaTitle.Add(title);
                    }
                }

                else if(mangaDir == "0")
                {

                    break;
                    //return to main page
                }
             
                else
                {
                    Console.WriteLine("                                 ");                   
                    Console.WriteLine("Invalid input. Try again");
                    Console.WriteLine("                                 ");
                }
              }                         
            }
            else if (input == "2")
            {
                Console.WriteLine(" -----------------------------------------");
                Console.WriteLine("|        Welcome to Genre!                |");
                Console.WriteLine(" -----------------------------------------");
                Console.WriteLine("                                 ");



                Console.WriteLine("     > Fantasy       > Romance");
                Console.WriteLine("     > One shot      > Shounen");
                Console.WriteLine("     > Drama         > Adventure");
                Console.WriteLine("     > Historical    > Comedy");
                Console.WriteLine("     > Shoujo        > Josei");
                Console.WriteLine("     > School Life   > Martial Arts");
                Console.WriteLine("     > Action        > Super Natural");
                Console.WriteLine("                                 ");



                Console.Write("Enter a Genre: ");
                string inputGenre = Console.ReadLine();
                var filterGenre = mangaList.Where(m => m.Genre.Any(genre => genre.Equals(inputGenre, StringComparison.OrdinalIgnoreCase)));
                if (filterGenre.Any())
                {
                    Console.WriteLine("Manga with genre '{0}'", inputGenre);
                    Console.WriteLine("                                 ");
                    
                    foreach(var manga in filterGenre)
                    {
                        Console.WriteLine($" > {manga.Title}");
                        Console.WriteLine("                                 ");
                    }
                }
                else
                {
                    Console.WriteLine("No manga found with genre '{0}' ", inputGenre);
                    Console.WriteLine("                                 ");
                }
                          

            }
            else if (input == "0")
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|    Thank you for using MangaRead!     |");
                Console.WriteLine("-----------------------------------------");
                
                break;
            }
            else 
            {
                Console.WriteLine("                                 ");
                Console.WriteLine("Invalid input. Please try again. ");
                Console.WriteLine("                                 ");

            }



        }
    }

class Manga
{
    public string Title { get; set; }
    public List<string> Genre { get; set; }
    // correction: public List string Genre { get; set; } to public List<string> Genre { get; set; }
    // the 'List<string> allows 'Genre' to store multiple genres
}
    
}
