using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes):base(Title, Category, RunTime, Scenes)
        {

        }
        public override void Play()
        {
            while (true)
            {
                Console.WriteLine("Which scene would you like to watch?");
                PrintScenes();
                int index;
                bool play = int.TryParse(Console.ReadLine(), out index);
                if (play)
                {
                    for (int i = index; i < Scenes.Count; i++)
                    {
                        Console.WriteLine(Scenes[index]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Scene Selection, Try again. ");
                    continue;
                }
            }
        }
    }
}
