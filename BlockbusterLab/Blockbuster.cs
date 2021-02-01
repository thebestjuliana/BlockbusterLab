using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
       public List<Movie> Movies { get; set; }
        public Blockbuster()
        {
            Movies = new List<Movie>();
            List<string> lionKingScenes = new List<string>();
            string lKScene1 = "There was a baby Lion named Simba";
            string lKScene2 = "Simba's uncle, Scar, kills Simba's dad, Mufasa";
            string lKScene3 = "Simba runs away and becomes friends with Timone and Pumba, a meerkat and warthod";
            string lKScene4 = "Hukuna Matata";
            string lKScene5 = "Simba's childhood friend/love interest finds Simba and tells him to come home";
            string lKScene6 = "Simba comes home and defeats Scar and they live happily ever after";
            string lKScene7 = "The End.";

            lionKingScenes.Add(lKScene1);
            lionKingScenes.Add(lKScene2);
            lionKingScenes.Add(lKScene3);
            lionKingScenes.Add(lKScene4);
            lionKingScenes.Add(lKScene5);
            lionKingScenes.Add(lKScene6);
            lionKingScenes.Add(lKScene7);

            VHS theLionKing = new VHS("The Lion King", Genre.Drama, 85, lionKingScenes, 3);

            Movies.Add(theLionKing);


        }

        public void PrintMovies()
        {
            int i = 0;
            foreach (Movie m in Movies)
            {
                Console.WriteLine($"{i}: {m.Title} \n");
            }
           
        }
        public Movie CheckOut()
        {
            while (true)
            {
                Console.WriteLine("Which movie would you like to check out?");
                PrintMovies();
                int index;
                bool play = int.TryParse(Console.ReadLine(), out index);
                if (play)
                {
                    for (int i = index; i < Movies.Count; i++)
                    {
                        Movies[index].PrintInfo();
                        return Movies[index];

                    }
                }
                else
                {
                    Console.WriteLine("Invalid Movie Selection, Try again. ");
                    continue;
                }
            }
            
        }
    }
}
