using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
   public enum Genres
    {
        Drama = 1,
        Comedy,
        Horror,
        Romance,
        Action
    }
    
    abstract class Movie
    {
        public string Title;
        public Genres Genre;
        public int RunTime;
        public List<string> Scenes;

        public Movie() { }
        public Movie(string Title, Genres Genre, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        public virtual void PrintInfo() {
            Console.WriteLine($"\tName: {Title}");
            Console.WriteLine($"\tGenre: {Genre}");
            Console.WriteLine($"\tRun Time: {RunTime}");
            Console.WriteLine();
        }
        public virtual void PrintScenes() { }
        public virtual void Play() { }   
    }
}
