using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes, int CurrentTime) : base(Title, Category, RunTime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }

        public override void Play()
        {
            
            for (int i = CurrentTime; i < Scenes.Count; i++)
            {
                Console.WriteLine(Scenes[i]);
            }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }

    }
}
