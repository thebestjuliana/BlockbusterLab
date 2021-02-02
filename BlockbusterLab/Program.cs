using System;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Blockbuster!");
            Blockbuster b = new Blockbuster();
            while (true)
            {
                Console.WriteLine("Please Select a Movie from the list");


                Movie selectedMovie = b.CheckOut();

                Console.WriteLine($"Do you want to watch {selectedMovie.Title} now (Press 'Y' to play and 'N' tp return to the previous menu)?");
                bool answer = YesNoValidation();

                if (answer == true)
                { 
                    selectedMovie.Play();
                }
                else
                {
                    continue;
                }
                Console.WriteLine("Would you like to play the whole movie from the beginning? (Y/N)");
                answer = YesNoValidation();
                if (answer == true)
                { 
                    selectedMovie.PlayWholeMovie();
                }
                
                VHS selectedVHS;
                DVD selectedDVD;
                if (selectedMovie is VHS)
                {
                    selectedVHS = (VHS)selectedMovie;
                    Console.WriteLine("Would you like to rewind the movies for the next user?(Y/N)");
                    answer = YesNoValidation();
                    if (answer == true)
                    {
                        Console.WriteLine("Thank you for rewinding!");
                        selectedVHS.Rewind();
                    }
                    else if (answer == false)
                    {
                        selectedVHS.NotRewind();
                        Console.WriteLine("Boo! Now we'll charge you an extra fee!");
                    }
                }
                if (selectedMovie is DVD)
                {
                    selectedDVD = (DVD)selectedMovie;
                    bool playAnotherScene = true;
                    while (playAnotherScene == true)
                    {
                        Console.WriteLine("Would you like to watch another scene? (Y/N)");

                        playAnotherScene = YesNoValidation();
                        if (playAnotherScene == true)
                        {
                            selectedDVD.Play();
                            continue;
                        }
                       
                    }
                }

                Console.WriteLine("Would you like to watch another movie? Y/N");
                answer = YesNoValidation();

                if (answer == true)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for watching! Goodbye!");
                    break;
                }







            }
        }

        public static bool YesNoValidation()
        {
            while (true)
            {
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    return true;
                }
                else if (answer.ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid response. Y/N. Try again!");
                    continue;
                }
            }

        }
    }
}
