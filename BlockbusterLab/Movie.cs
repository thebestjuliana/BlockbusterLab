using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    public enum Genre
    {
        Drama,
        Comedy, 
        Horror, 
        Romance,
        Action,
    }
    class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Title} \nCategory: {Category} \nRun time: {RunTime}");
        }
        public void PrintScenes()
        {
            int i = 0;
            foreach (string scene in Scenes)
            {
                Console.WriteLine( $"{i}) {scene} \n");
                i++;
            }
        }

        public virtual void Play()
        {

        }
    }
}
