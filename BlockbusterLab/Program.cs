using System;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Blockbuster!");
          //  while (true) 
            {
                Console.WriteLine("Please Select a Movie from the list");
                Blockbuster b = new Blockbuster();
                b.PrintMovies();

                Movie selectedMoveie = b.CheckOut();

                Console.WriteLine($"Do you want to watch {selectedMoveie.Title} now?");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    selectedMoveie.Play();
                }




                

            }
        }
    }
}
