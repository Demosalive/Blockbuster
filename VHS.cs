using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS() { }
        public VHS(string Title, Genres Genre, int RunTime, List<string> Scenes, int CurrentTime):base(Title, Genre, RunTime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }
        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                string timeScene = Scenes[CurrentTime];
                Console.WriteLine(timeScene);
                CurrentTime++;
            }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
