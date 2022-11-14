using System;

namespace NumberGuesser
{
    //main class
    class Program
    {
            //entry point method
        static void Main(string[] args)
        {
            getAppInfo(); //run getAppInfo funtion to get info

            greetUser(); //Ask for users name


            while (true)
            {
                // Set correct number, later i will try with a random number
              //int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1,10);

                //Init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //MAKE SURE ITS A NUMBER
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                      
                        //keep going
                        continue;
                    }


                    //CaSt to int and put in guess 
                    guess = Int32.Parse(input);

                    //match guess to correct number

                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT! You guessed it");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //GET ANSWER
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else {
                    return;
                }
           
            }

        }
        //Get and display app info
        static void getAppInfo()
        {
            // set app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ema Perkovic";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;


            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }
        /// <summary>
        /// ask users name  
        /// </summary>
        static void greetUser()
        {
            //ask users name
            Console.WriteLine("What is you name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //print color message

        static void PrintColorMessage(ConsoleColor color ,string message)
        {
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);
             
            //reset text color
            Console.ResetColor();
        }

    }
}
