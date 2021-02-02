using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }
        public override void Play()
        {
            while (true)
            {
                Console.WriteLine($"Which scene of the DVD {Title} would you like to watch?");
                PrintScenes();
                int index;
                bool play = int.TryParse(Console.ReadLine(), out index);
                Console.WriteLine();
                if (play)
                {
                    Thread.Sleep(500);

                    Console.WriteLine(Scenes[index]);
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Scene Selection, Try again. ");
                    continue;
                }
            }
        }
        public override void PlayWholeMovie()
        {
            base.PlayWholeMovie();
        }
    }
}
