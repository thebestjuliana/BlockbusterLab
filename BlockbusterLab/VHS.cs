using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            if(CurrentTime != 0)
            {
                Console.WriteLine($"Someone didn't rewind the movie, We're going to start this from this scene. \nScene: {CurrentTime}\n");
            }
            for (int i = CurrentTime; i < Scenes.Count; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine(Scenes[i]);
                
            }
            Console.WriteLine();
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
        public void NotRewind()
        {
            CurrentTime = Scenes.Count - 1;
        }
        public override void PlayWholeMovie()
        {
            base.PlayWholeMovie();
        }
    }
}
