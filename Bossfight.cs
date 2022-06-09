using System;

namespace DefeatTheLeerplichtAmbtenaar
{
    class Bossfight
    {
        public static void BossFight()
        {
            Boss();


            bool guessBool = true;
            do
            {
                int guess = GetGuess();
                if (guess == 3)
                {
                    Console.WriteLine("Your guess was correct!");
                    Defeat();
                    guessBool = false;
                }
            } while (guessBool);


            static void Boss()
            {
                Console.WriteLine("You enter the bossroom, your journey has finally come to it's conclusion. You ready your sword and shield. ");
                Console.WriteLine("WOW WOW WOW, calm down here. I'm just a teacher, you just have to.. uhm...FIGURE OUT MY PUZZLE!");
                Console.WriteLine("Uh, YES, THAT'S RIGHT. YOU HAVE TO GUESS THE NUMBER I HAVE IN MY HEAD! IT'S BETWEEN 1 TO 10");

            }
            static int GetGuess()
            {
                int guess = 0;
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a valid guess.");
                    guess = GetGuess();


                }
                return guess;

            }

        }

        static void Defeat()
        {

            Console.WriteLine("'Gigigitie gawnty goe, you defeated me! I'll return one day when this group can properly code! Goodbye!'");
            Console.WriteLine("Pront drops his key. You finally did it. Return to Wessel!");
        }
    }
}