using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Library;

namespace ListMoviesByCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONST VARIABLE 
            const string LINE_SHORT = "--------------------------------------";
            const string LINE_MEDIUMM = "--------------------------------------------------------";

            //Welcome header 
            Console.WriteLine($"{LINE_MEDIUMM}\n\tWelcome to the Movie List Application!\n\t There are 100 movies in this list\n{LINE_MEDIUMM}");

            //start looping program
            do
            {
               // message to the user what's going on
                Console.Write("\nWhat category are you interested in? ");
                string userInput = Console.ReadLine();

                //Start switch condition logic here
                switch (userInput.ToLower())
                {
                    case "scifi":
                        //pass the movie into moviList using loop then print it
                        Console.WriteLine($"\n\nMovies are available in Scifi: \n{LINE_SHORT}");
                        GetScifiMovies();
                   
                        break;
                    case "funny":
                        Console.WriteLine($"\n\nMovies are available in Funny: \n{LINE_SHORT}");
                        GetFunnyMovies();
                        break;

                    case "horror":
                        Console.WriteLine($"\n\nMovies are available in Horror: \n{LINE_SHORT}");
                        GetHorrorMovies();
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }           
            } while (ShouldContinue());


            Console.ReadKey();
        }

        //Horror movie
        private static void GetHorrorMovies()
        {
            List<Movie> horrorMovie = new List<Movie>
           {
               new Horror ("Lord of the Ring"),
               new Horror ("Get Out"),
               new Horror ("Train to Busan"),
           };

            foreach (Movie movie in horrorMovie)
            {
                if ("horror" == movie.GetCategory())
                {
                    Console.WriteLine(movie.GetTitle());
                }
            }
        }

        //Funny movie
        private static void GetFunnyMovies()
        {
            List<Movie> funnyMovie = new List<Movie>
            {
                new Funny("Old School"),
                new Funny("Hush"),
                new Funny("The Hangover")
            };

            foreach (Movie movie in funnyMovie)
            {
                if ("funny" == movie.GetCategory())
                {
                    Console.WriteLine(movie.GetTitle());
                }
            }
        }

        //Scifi movie
        private static void GetScifiMovies()
        {
            List<Movie> scifiMovie = new List<Movie>
            {
                new Scifi("Star War"),
                new Scifi("A space odyssey"),
                new Scifi("E.T. The Extra-terrestrial"),
                new Scifi("A Clockwork Orange")
            };

            foreach (Movie movie in scifiMovie)
            {
                if ("scifi" == movie.GetCategory())
                {
                    Console.WriteLine(movie.GetTitle());
                }
            }
        }

        //continue run program
        public static bool ShouldContinue()
        {
            do
            {
                Console.Write("\nWould you like to continue (y/n)?");
                var userResponse = Char.ToLower(Console.ReadKey().KeyChar);

                if (userResponse != 'y' && userResponse != 'n')
                {
                    continue;
                }
                else
                {
                    return userResponse == 'y';
                }
            } while (true);
        }
    }
}
