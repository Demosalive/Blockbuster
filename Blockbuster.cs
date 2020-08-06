using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class Blockbuster
    {
        
         public List<Movie> Movies = new List<Movie>()
       {
            new DVD( "A Few Good Men",Genres.Drama, 138, new List<string>(){"Opening", "Second Act", "Third Act", "Ending" },0),
            new DVD( "BASEketball",Genres.Comedy, 108, new List<string>(){"Opening", "Second Act", "Third Act", "Ending" },0),
            new VHS( "The Thing",Genres.Horror, 109, new List<string>(){"Opening", "Second Act", "Third Act", "Ending" },0),
            new DVD( "The Princess Bride",Genres.Romance, 98, new List<string>(){"Opening", "Second Act", "Third Act", "Ending" },0),
            new VHS( "Demolition Man",Genres.Action, 115, new List<string>(){"Opening", "Second Act", "Third Act", "Ending" },0),
            new VHS( "Predator",Genres.Action, 107, new List<string>(){"Opening", "Second Act", "Third Act", "Ending" },0),
       };
      
        
       public void PrintMovies()
        {
            
            
            for (int i =0; i< Movies.Count;i++)
            {
                Console.WriteLine("Index: " +(i+1));
                Movies[i].PrintInfo();
            }
        }

        public Movie CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Which movie would you like to see?");
            int input = int.Parse(Console.ReadLine());
            Movies[input - 1].PrintInfo();
            return Movies[input-1];
        }

    } 
            
}
   

