using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public DVD() { }
        public DVD(string Title, Genres Genre, int RunTime, List<string> Scenes, int CurrentTime) : base(Title, Genre, RunTime, Scenes)
        {
            
        }
        public override void Play()
        {
            Console.WriteLine("Which Scene of the DVD do you want to watch? (");
         
                
            

            for (int i=0; i<Scenes.Count; i++)
            {
                Console.WriteLine($"{Scenes[i]}");
            }
            Console.WriteLine("What scene would you like to watch?");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Scenes[input-1]);
        }
    }
}
