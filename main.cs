namespace Hackathon
{
    public class Program
    {
        public static bool inputOK(string inputAsString, int startRange, int endRange)
        {
            // Not null or empty
            if (string.IsNullOrEmpty(inputAsString))
            {
                Console.WriteLine("User input was empty. Try again.");
                return false;
            }

            // is Int
            int inputAsInt;
            bool parseSuccess = int.TryParse(inputAsString, out inputAsInt);
                if (!parseSuccess)
                {
                    Console.WriteLine("You did not enter an integer. Try again.");
                    return false;
                }

            // is within range - it is very elegant how we store inputAsInt and then use it here
            if (inputAsInt < startRange || inputAsInt > endRange)
            {
                Console.WriteLine("You entered an integer, but it does not match a valid option. Try again.");
                return false;
            }

            // Only make it here if all is good
            return true;
        }


        public static void Main(string[] args)
        {
        
            Start:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                         |\r\n                                         |\r\n                                         |\r\n                                         |\r\n   _______                   ________    |\r\n  |ooooooo|      ____       | __  __ |   |\r\n  |[]+++[]|     [____]      |/  \\/  \\|   |\r\n  |+ ___ +|     ]()()[      |\\__/\\__/|   |\r\n  |:|   |:|   ___\\__/___    |[][][][]|   |\r\n  |:|___|:|  |__|    |__|   |++++++++|   |\r\n  |[]===[]|   |_|_/\\_|_|    | ______ |   |\r\n_ ||||||||| _ | | __ | | __ ||______|| __|\r\n  |_______|   |_|[::]|_|    |________|   \\\r\n              \\_|_||_|_/               jro\\\r\n                |_||_|                     \\\r\n               _|_||_|_                     \\\r\n      ____    |___||___|                     \\\r\n     /  __\\          ____                     \\\r\n     \\( oo          (___ \\                     \\\r\n     _\\_o/           oo~)/\r\n    / \\|/ \\         _\\-_/_\r\n   / / __\\ \\___    / \\|/  \\\r\n   \\ \\|   |__/_)  / / .- \\ \\\r\n    \\/_)  |       \\ \\ .  /_/\r\n     ||___|        \\/___(_/\r\n     | | |          | |  |\r\n     | | |          | |  |\r\n     |_|_|          |_|__|\r\n     [__)_)        (_(___]");           
                Console.WriteLine("-----------------------------------------\n\t\t  Menu:\n-----------------------------------------");
                
                Console.WriteLine("-----------------------------------------\n-----------Hackathon Quest-----------\n" +
                    "--A Courageous Journey of Survival--");
                Console.WriteLine("     (1)        New Game        (1)");
                Console.WriteLine("        (2)       Exit      (2)");
            
                Console.WriteLine("\n     Enter a selection (1-2):\n");

                Console.ForegroundColor = ConsoleColor.White;

// READLINE 1
                //instantiates menuSelection for try - catch which handles any non integer input
                do
                {
                    string menuSelection = Console.ReadLine();
                } while (!inputOK(menuSelection))

                try
                {
                    menuSelection = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Command not recognized! Try again.");
                    goto Start;

                }

                if (menuSelection < 1 || menuSelection > 2)
                {
                    Console.WriteLine("Command not recognized! Try again.");
                    goto Start;
                }

                bool hunger = true;
                bool codingKnowledge = false;

                switch (menuSelection)
                {
                    case 1:
                        Console.WriteLine("      ()___ \r\n    ()//__/)_________________()\r\n    ||(___)//#/_/#/_/#/_/#()/||\r\n    ||----|#| |#|_|#|_|#|_|| ||\r\n    ||____|_|#|_|#|_|#|_|#||/||\r\njgs ||    |#|_|#|_|#|_|#|_||");
                        Console.WriteLine("\r\nThe smell of freshly made toast fills the room, waking you from sleep only to meet with the cold air that lingered from the night. As your eyes open, the morning light hits you...\r\n ");
                        Console.WriteLine("Do you: \n Sleep a bit longer (1)");
                        Console.WriteLine("Get up and eat breakfast(2)");

// READLINE 2                       
                        string menuInput = Console.ReadLine();

                        if (menuInput == "1")
                        {
                            //50/50 chance of missing hackathon
                            Random snooze = new Random();
                            int wakeUp = snooze.Next(1, 3);
                            if (wakeUp == 1)
                            {
                                Console.WriteLine("It's noon! You slept in! Looks like you missed the Hackathon!\n");
                                Console.WriteLine("\n\n------GAME OVER------\n\n");
                                Console.WriteLine("Try Again? (y/n)");

// READLINE 3
                                string tryAgain = Console.ReadLine();

                                if (tryAgain == "y")
                                {
                                    goto Start;
                                }
                                else
                                {
                                    Console.WriteLine("Goodbye!");
                                    Environment.Exit(0);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Wake up sleepyhead, there's no time for breakfast but if you hurry you'll make it in time!\n");
                                hunger = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou eat breakfast just in time. Time to go!\n");
                            hunger = false;

                        }
                        break;

                    case 2:
                        Console.WriteLine("\nGoodbye!\n");
                        Environment.Exit(0);
                        break;

                }

                Console.WriteLine("                  _.--\"\"'-----,   `\"--.._\r\n                       .-''   _/_      ; .'\"----,`-,\r\n                     .'      :___:     ; :      ;;`.`.\r\n                    .      _.- _.-    .' :      ::  `..\r\n                 __;..----------------' :: ___  ::   ;;\r\n            .--\"\". '           ___.....`:=(___)-' :--'`.\r\n          .'   .'         .--''__       :       ==:    ;\r\n      .--/    /        .'.''     ``-,   :         :   '`-.\r\n   .\"', :    /       .'-`\\\\       .--.\\ :         :  ,   _\\\r\n  ;   ; |   ;       /:'  ;;      /__  \\\\:         :  :  /_\\\\\r\n  |\\_/  |   |      / \\__//      /\"--\\\\ \\:         :  : ;|`\\|    \r\n  : \"  /\\__/\\____//   \"\"\"      /     \\\\ :         :  : :|'||\r\n[\"\"\"\"\"\"\"\"\"--------........._  /      || ;      __.:--' :|//|\r\n \"------....______         ].'|      // |--\"\"\"'__...-'`\\ \\//\r\n   `| WVE230L |__;_...--'\": :  \\    //  |---\"\"\"      \\__\\_/\r\n     \"\"\"\"\"\"\"\"\"'            \\ \\  \\_.//  /\r\n       `---'                \\ \\_     _'\r\n                             `--`---'  dp");
                        Console.WriteLine("\nLooks like it snowed a lot last night! Do you: \n Get in your car and leave (1)");
                Console.WriteLine("Shovel the driveway (2)");

// READLINE 4
                int menuSelection2 = Convert.ToInt32(Console.ReadLine());

                switch (menuSelection2)
                {
                    case 1:
                        Console.WriteLine("You got stuck in the driveway!");
                        Console.WriteLine("Do you: \n Call a friend? (1)");
                        Console.WriteLine("Take the bus (2)");

// READLINE 5
                        int menuInput = Convert.ToInt32(Console.ReadLine());

                        if (menuInput == 1)
                        {
                            //50/50 chance of missing hackathon
                            Random drive = new Random();
                            int crash = drive.Next(1, 3);
                            if (crash == 1)
                            {
                                Console.WriteLine("\nOh no! Your friend crashed! \n");
                                Console.WriteLine("\n\n------GAME OVER------\n\n");
                                Console.WriteLine("Try Again? (y/n)");

// READLINE 6                                
                                string tryAgain = Console.ReadLine();
                                if (tryAgain == "y")
                                {
                                    goto Start;
                                }
                                else
                                {
                                    Console.WriteLine("Goodbye!");
                                    Environment.Exit(0);
                                }
                                

                            }
                            else
                            {
                                Console.WriteLine("You made it to the Hackathon just in time!\n");
                                
                            }
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("You manage to not get stuck in the snow and make it to the hackathon\\n\");\n");                    
                        break;


                }

                Console.WriteLine("// \"\"--.._\r\n||  (_)  _ \"-._\r\n||    _ (_)    '-.\r\n||   (_)   __..-'\r\n \\\\__..--\"\"");

                Console.WriteLine("After a challenging morning of Hackathoning, it's time for a pizza lunch.");
                Console.WriteLine("Do you: \n Eat pizza (1)");
                Console.WriteLine("Trade pizza to coding professor for ultimate coding knowledge? (2)");

// READLINE 7
                int menuInput2 = Convert.ToInt32(Console.ReadLine());
                switch (menuInput2)
                {
                    case 1: 
                        if (hunger == true)
                        {
                            Console.WriteLine("You passed out from low blood-sugar. You should've had some breakfast!");
                            Console.WriteLine("\n\n---------GAME OVER---------\n\n");
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ultimate coding knowledge recieved!");
                        codingKnowledge = true;
                        break;
                }

                //Scenario 4 - AI Robot Battle 
                //Ascii art robot
                Console.WriteLine("           ___\r\n          |_|_|\r\n          |_|_|              _____\r\n          |_|_|     ____    |*_*_*|\r\n _______   _\\__\\___/ __ \\____|_|_   _______\r\n/ ____  |=|      \\  <_+>  /      |=|  ____ \\\r\n~|    |\\|=|======\\\\______//======|=|/|    |~\r\n |_   |    \\      |      |      /    |    |\r\n  \\==-|     \\     |  2D  |     /     |----|~~/\r\n  |   |      |    |      |    |      |____/~/\r\n  |   |       \\____\\____/____/      /    / /\r\n  |   |         {----------}       /____/ /\r\n  |___|        /~~~~~~~~~~~~\\     |_/~|_|/\r\n   \\_/        |/~~~~~||~~~~~\\|     /__|\\\r\n   | |         |    ||||    |     (/|| \\)\r\n   | |        /     |  |     \\       \\\\\r\n   |_|        |     |  |     |\r\n              |_____|  |_____|\r\n              (_____)  (_____)\r\n              |     |  |     |\r\n              |     |  |     |\r\n              |/~~~\\|  |/~~~\\|\r\n              /|___|\\  /|___|\\\r\n             <_______><_______>");
                Console.WriteLine("\n\nAll of a sudden, a fearsome AI bot appears, intent on neutralizing all human coders.");
                Console.WriteLine("\"Beep Boop Bop... Greetings human... You must pass my challenges or be destroyed\"");
                Console.WriteLine("Do you:\n");
                Console.WriteLine("Attempt challenges (1)\n Fry Bot's circuit board (2)");
                
// READLINE 8                
                int choice4 = Convert.ToInt32(Console.ReadLine());
                switch (choice4)
                {
                    case 1:
                        {
                            Console.WriteLine("What is 3/5 of 155?\n");

// READLINE 9                            
                            int answer = Convert.ToInt32(Console.ReadLine());
                            if (answer == 93)
                            {
                                Console.WriteLine("Correct.\n\n");
                                Console.WriteLine("3x + 5 = 23\nSolve for x");

// READLINE 10                             
                                int answer2 = Convert.ToInt32(Console.ReadLine());
                                if (answer2 == 6)
                                {
                                    Console.WriteLine("You did it! You defeated the AI bot with your supreme coding knowledge");
                                }
                                else
                                {
                                    Console.WriteLine("WRONG.");
                                    Console.WriteLine("---------GAME OVER---------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("WRONG.");
                                Console.WriteLine("---------GAME OVER---------");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (codingKnowledge == true)
                            {
                                Console.WriteLine("You did it! You defeated the AI bot with your supreme coding knowledge");
                            }
                            else
                            {
                                Console.WriteLine("OH NO! You were terminated. \nWithout the ultimate coding knowledge, you were no match for the AI bot.");
                            }
                            break;
                        }
                }
        }
    }
}






