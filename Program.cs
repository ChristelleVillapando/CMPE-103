using System;

class Program
{
    static void Main(string[] args)
    {
        
        string password = "707";
        
        while (true)
        {
            Console.Write("Enter the password to access the manga website: ");
            string? input = Console.ReadLine();
            if (input == password)
            {
                Console.WriteLine("Welcome to MangaGo!");
                break;
            }
            else
            {
                Console.WriteLine("Wrong password. Try again.");
            }
        }


        while (true)
        {
            Console.WriteLine("Manga Website");
            Console.WriteLine("1. Manga directory");
            Console.WriteLine("2. Genre");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
            string? input = Console.ReadLine();

            if (input == "1")
            {
                
                Console.WriteLine("Manga Directory");
                Console.WriteLine("--------------------------");
                Console.WriteLine("A. Attack on Titan");
                Console.WriteLine("B. My Hero Academia");
                Console.WriteLine("C. Fairy Tail");
                Console.WriteLine("D. Spy x Family");
                Console.WriteLine("E. One Punch Man");
                Console.WriteLine("--------------------------");

                Console.Write("Enter your choice of Manga:  ");
                String? mangaChoice = Console.ReadLine();

              switch (mangaChoice) {

                case "A":
                Console.WriteLine("You have chosen: Attack on Titan!");
                Console.WriteLine("--------------------------");
                

                Console.WriteLine("Manga Website");
                Console.WriteLine("1. Manga directory");
                Console.WriteLine("2. Genre");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                input = Console.ReadLine();

                break;

                case "B":
                Console.WriteLine("You have chosen: My Hero Academia!");
                Console.WriteLine("--------------------------");
                
                Console.WriteLine("Manga Website");
                Console.WriteLine("1. Manga directory");
                Console.WriteLine("2. Genre");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                input = Console.ReadLine();
                break;

                case "C":
                Console.WriteLine("You have chosen: Fairy Tail!");
                Console.WriteLine("--------------------------");
                
                Console.WriteLine("Manga Website");
                Console.WriteLine("1. Manga directory");
                Console.WriteLine("2. Genre");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                input = Console.ReadLine();
                break;

                case "D":
                Console.WriteLine("You have chosen: Spy x Family!");
                Console.WriteLine("--------------------------");
                
                Console.WriteLine("Manga Website");
                Console.WriteLine("1. Manga directory");
                Console.WriteLine("2. Genre");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                input = Console.ReadLine();
                break;

                case "E":
                Console.WriteLine("You have chosen: One punch man!");
                Console.WriteLine("--------------------------");
                
                Console.WriteLine("Manga Website");
                Console.WriteLine("1. Manga directory");
                Console.WriteLine("2. Genre");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                input = Console.ReadLine();
                break;

                default:
                Console.WriteLine("Invalid data. Try again");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Manga Website");
                Console.WriteLine("1. Manga directory");
                Console.WriteLine("2. Genre");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                input = Console.ReadLine();

                break;


              }


            }
            else if (input == "2")
            {
                // display the genres of the manga
                Console.WriteLine("Genres");
                Console.WriteLine("A. Action");
                Console.WriteLine("B. Adventure");
                Console.WriteLine("C. Comedy");
                Console.WriteLine("D. Fantasy");
                Console.WriteLine("E. Shounen");

                Console.Write("Enter your choice of Genre: ");
                String? genreChoice = Console.ReadLine();
                switch (genreChoice)
                {
                    case "A":

                    Console.WriteLine("You have chosen Action!");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Action: Attack on Titan, My Hero Academia, One Punch Man, Fairy Tail, Spy x Family");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Manga Website");
                    Console.WriteLine("1. Manga directory");
                    Console.WriteLine("2. Genre");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select an option: ");
                    input = Console.ReadLine();

                    break;

                    case "B":
                    Console.WriteLine("You have chosen Adventure!");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Adveture: Fairy Tail");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Manga Website");
                    Console.WriteLine("1. Manga directory");
                    Console.WriteLine("2. Genre");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select an option: ");
                    input = Console.ReadLine();
                    break;

                    case "C":
                    Console.WriteLine("You have chosen Comedy!");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Comedy: My Hero Academia, One Punch Man, Fairy Tail, Spy x Family");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Manga Website");
                    Console.WriteLine("1. Manga directory");
                    Console.WriteLine("2. Genre");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select an option: ");
                    input = Console.ReadLine();
                    break;

                    case "D":
                    Console.WriteLine("You have chosen Fantasy!");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Fantasy: Attack on Titan, Fairy Tail");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Manga Website");
                    Console.WriteLine("1. Manga directory");
                    Console.WriteLine("2. Genre");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select an option: ");
                    input = Console.ReadLine();
                    break;

                    case "E":
                    Console.WriteLine("You have chosen Shounen!");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Action: Attack on Titan, My Hero Academia, Fairy Tail, Spy x Family");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Manga Website");
                    Console.WriteLine("1. Manga directory");
                    Console.WriteLine("2. Genre");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select an option: ");
                    input = Console.ReadLine();
                    break;

                    default:
                    break;
                }
               
            }
            else if (input == "0")
            {
                
                Console.WriteLine("Thank you for using MangaGo!");
                break;
            }
            else
            {
               
                Console.WriteLine("Invalid input. Please select a valid option.");
            }
        }
    }
}
