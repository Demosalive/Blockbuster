using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster name = new Blockbuster();
            
            List<Movie> movieList = name.Movies;
            DVD dvd = new DVD();
            VHS tape = new VHS();
          

            Console.WriteLine("Welcome to GC Blockbuster");
       
            
            Movie movie = name.CheckOut();
            string answer = "";

            Console.WriteLine("\nDo you want to watch the movie? Y/N");
            answer = Console.ReadLine().ToLower();


            if (answer == "y")
            {
                movie.Play();
            }
            else if (answer == "n")
            {
                
            }
            

        } 
            
    }
}
