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
            VHS meanGirls = new VHS("Mean Girls", Genre.Comedy, 97,
                new List<string>() {"This girl was home schooled in Africa and then her parents moved home and she had to go to public school",
                "She makes some friends who give her a tour of the school cliques",
                "She infiltrates the plastics",
                "There's a book where you write mean things about each other",
                "They release the book, everyone goes CRAY!",
                "Everyone goes to therapy",
                "The End"},
                2);
            VHS cinderella = new VHS("Cinderella", Genre.Romance, 74,
                new List<string>() { "This girl's parents die", "Her stepmom and stepsisters are horrible", "They make her work so much", "There's a party, but she can't go since she's not fancy and she has too much work to do so she can get fance",
                "Don't worry: her mice/bird friends made her an outfit", "Her stepmom destroyed it", "OOOOH Bibbity bobbity boo! Fairy magic saves the day- she has a dress", "She goes to the party", "She falls in love but sadly he has a rare eye condition where he can't recognize her if she doesn't wear her shoes",
                "She lost her shoes", "Her mom locks her up when the dude comes trying to have all the girls try on the shoe", "She gets out", "They get married", "the end." }

                , 4);
            DVD hiddenFigures = new DVD("Hidden Figures", Genre.Drama, 127,
                new List<string>() { "It's 1961, people are racist",
                    "Katherine Johnson is assigned to assist the Space Task Group given mad geometry and math skillz",
                    "NASA installed IBM 7090 to replace human computer--Katherine teaches herslf how to use them and to make her team indispensable",
                    "She did some cool shit.",
                    "Mary became NASA's first female African-American engineer",
                    "She won the Presidential Medal of Freedom and in 2016 NASA dedicated a building in her honor",
                    "The End."});


            DVD psycho = new DVD("Psycho", Genre.Horror, 109,
                new List<string>(){"I don't really watch horror so I'm not actually sure what happens in this movie",
                "This lady is on the 'lam' for stealing from her boss",
                "She stops at the Bates motel",
                "He likes taxidermy and has a werid relationship with his mother"});
            DVD theBourneIdentity = new DVD("The Bourne Identity", Genre.Action, 119,
                new List<string>() {"So this dude", "He doesn't remember anything", "but he has mad skillz--he's like a super spy agent",
                "but he doesn't remember anything", "he's trying to figure out who he is while everyone is trying to kill him", "but he got this girl helping him out and he kinda likes her", "he gets away" });


            Movies.Add(theLionKing);
            Movies.Add(meanGirls);
            Movies.Add(psycho);
            Movies.Add(cinderella);
            Movies.Add(hiddenFigures);
            Movies.Add(theBourneIdentity);



        }

        public void PrintMovies()
        {
            int i = 0;
            foreach (Movie m in Movies)
            {
                Console.WriteLine($"{i}: {m.Title}");
                i++;
            }
            Console.WriteLine();

        }
        public Movie CheckOut()
        {
            while (true)
            {
                Console.WriteLine();
                PrintMovies();
                Console.WriteLine("Which movie would you like to check out?");
                int index;
                bool play = int.TryParse(Console.ReadLine(), out index);
                if (play)
                {
                    if (index > Movies.Count -1 || index <0 )
                    {
                        Console.WriteLine("Invalid Selection");
                        continue;
                    }
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
