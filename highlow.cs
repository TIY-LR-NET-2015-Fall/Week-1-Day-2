static void Main(string[] args)
        {
            //psuedo code: 

            //high low game
            //general play: 
            //Computer thinks of a number
            //We ask user for their guess
            // if the number is higher than what we picked, tell them too high and ask them again
            // if the number is lower than what we picked, tell them too low and ask them again
            // if the number is spot on, we tell them good guess! and exit the game.


            int numberToGuess = 30; //we'll figure out how to randomize this guy;


            bool hasMadeACorrectGuess = false;

            //game loop
            while (!hasMadeACorrectGuess)
            {
                Console.WriteLine("Please enter a number:");
                
                int usersGuess = int.Parse(Console.ReadLine());


                if (usersGuess == numberToGuess)
                {
                    Console.WriteLine("Your guess was correct. You win!");
                    hasMadeACorrectGuess = true;
                }
                else if (usersGuess < numberToGuess)
                {
                    Console.WriteLine("Your number is too low, guess again.");
                }
                else
                {
                    Console.WriteLine("Your number is too high, guess again.");
                }

            }

            Console.ReadLine();

        }
