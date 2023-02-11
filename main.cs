namespace Hackathon
{
    internal class Program
    {
        static void Main(string[] args)
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

            //instantiates menuSelection for try - catch which handles any non integer input
            int menuSelection = -1;


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
                    string menuInput = Console.ReadLine();

                    if (menuInput == "1")
                    {
                        //50/50 chance of missing hackathon
                        Random snooze = new Random();
                        int wakeUp = snooze.Next(1, 3);
                        if (wakeUp == 1)
                        {
                            Console.WriteLine("When you wake up, it's much warmer. Checking the time, you realize that it is noon, and the realization sets in. You slept in, missing out on Hackathon.\r\n\n");
                            Console.WriteLine("\n\n------GAME OVER------\n\n");
                            Console.WriteLine("Try Again? (y/n)");
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
                            Console.WriteLine("As you wake up again, the air is a bit warmer than before, and the smell of toast still lingers. Reaching for your phone, you realize you don't have time to eat, and you're going to be late.\r\n\r\nRushing for your coat and bag, you pass by a window, getting a glimpse of the snow that had fallen just the day before.\r\n\n");
                            hunger = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nHaving had a full meal. You feel energized, but the time escapes you; now, it's getting late.\r\n\r\nAs you gather your bag and coat, you get a glimpse from the window of the snow that had fallen the day before. \r\n\n");
                        hunger = false;

                    }
                    break;

                case 2:
                    Console.WriteLine("\nGoodbye!\n");
                    Environment.Exit(0);
                    break;

            }

            Console.WriteLine("                  _.--\"\"'-----,   `\"--.._\r\n                       .-''   _/_      ; .'\"----,`-,\r\n                     .'      :___:     ; :      ;;`.`.\r\n                    .      _.- _.-    .' :      ::  `..\r\n                 __;..----------------' :: ___  ::   ;;\r\n            .--\"\". '           ___.....`:=(___)-' :--'`.\r\n          .'   .'         .--''__       :       ==:    ;\r\n      .--/    /        .'.''     ``-,   :         :   '`-.\r\n   .\"', :    /       .'-`\\\\       .--.\\ :         :  ,   _\\\r\n  ;   ; |   ;       /:'  ;;      /__  \\\\:         :  :  /_\\\\\r\n  |\\_/  |   |      / \\__//      /\"--\\\\ \\:         :  : ;|`\\|    \r\n  : \"  /\\__/\\____//   \"\"\"      /     \\\\ :         :  : :|'||\r\n[\"\"\"\"\"\"\"\"\"--------........._  /      || ;      __.:--' :|//|\r\n \"------....______         ].'|      // |--\"\"\"'__...-'`\\ \\//\r\n   `| WVE230L |__;_...--'\": :  \\    //  |---\"\"\"      \\__\\_/\r\n     \"\"\"\"\"\"\"\"\"'            \\ \\  \\_.//  /\r\n       `---'                \\ \\_     _'\r\n                             `--`---'  dp");
            Console.WriteLine("\nIt seemed to have snowed a lot last night.. What do you do: \n Take the risk, get in your car, and go. (1)");
            Console.WriteLine("Shovel your driveway with what little time you have left. (2)");

            int menuSelection2 = Convert.ToInt32(Console.ReadLine());

            switch (menuSelection2)
            {
                case 1:
                    Console.WriteLine("\"There isn't enough time,\" you think as you crawl into your car. Without much thought, you put your foot on the gas, but your vehicle does not move. You try again, but nothing is working; you're stuck.\r\n");
                    Console.WriteLine("You want to Hackathon, so you think of your only other options. Do you: \n Call your friend for a ride. (1)");
                    Console.WriteLine("Take the bus. (2)");
                    int menuInput = Convert.ToInt32(Console.ReadLine());

                    if (menuInput == 1)
                    {
                        //50/50 chance of missing hackathon
                        Random drive = new Random();
                        int crash = drive.Next(1, 3);
                        if (crash == 1)
                        {
                            Console.WriteLine("\nYour friend arrives, and you drive off together, but misfortune strikes. \r\n\r\nWith the snow-covered roads, your friend gets stuck halfway without any bus routes around and the tow truck coming. You end up missing out on Hackathon.\r\n\n");
                            Console.WriteLine("\n\n------GAME OVER------\n\n");
                            Console.WriteLine("Try Again? (y/n)");
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
                            Console.WriteLine("Your friend arrives just in time, and you head towards Hackathon. \r\n\r\nGetting to the venue was exciting; there were new faces and a prize amount of $500, which you couldn't wait to take your chance on winning.\r\n");

                        }
                    }

                    break;

                case 2:
                    Console.WriteLine("The bus arrives a few minutes after getting to the bus stop, and warmth finds your fingertips again. It's not too busy since it's still pretty early, but the bus is filled shortly after by people going through their day.\r\n\r\nAfter a while, the bus stops at Cambrian College, and you make your way toward the E-dome as the excitement takes over. There were a bunch of new faces and a prize amount of $500, which you couldn't wait to take your chance on winning.\r\n");
                    break;


            }

            Console.WriteLine("// \"\"--.._\r\n||  (_)  _ \"-._\r\n||    _ (_)    '-.\r\n||   (_)   __..-'\r\n \\\\__..--\"\"");

            Console.WriteLine("After a welcoming presentation, you begin your journey, and while deep in code, the pizza gets delivered for everybody to enjoy.\r\n");
            Console.WriteLine("You began to wonder if you should grab something to eat. Do you: \n Eat pizza (1)");
            Console.WriteLine("Trade pizza to coding professor for ultimate coding knowledge? (2)");
            int menuInput2 = Convert.ToInt32(Console.ReadLine());
            switch (menuInput2)
            {
                case 1:
                    if (hunger == true)
                    {
                        Console.WriteLine("It starts to get hard to focus, and the hunger becomes unbearable. You feel that your head gets heavier, and before you get up, darkness takes over. You passed out from low blood-sugar. You should've had some breakfast!");
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
            Console.WriteLine("\n\nYou get a slice of pizza and feel energized again! You get back to work- finding it easier to focus on the code.\r\nBut all of a sudden, a fearsome AI bot appears, intent on neutralizing all human coders.");
            Console.WriteLine("\"Beep Boop Bop... Greetings human... You must pass my challenges or be destroyed\"");
            Console.WriteLine("Do you:\n");
            Console.WriteLine("Attempt challenges (1)\n Fry Bot's circuit board (2)");

            int choice4 = Convert.ToInt32(Console.ReadLine());
            switch (choice4)
            {
                case 1:
                    {
                        Console.WriteLine("What is 3/5 of 155?\n");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        if (answer == 93)
                        {
                            Console.WriteLine("Correct.\n\n");
                            Console.WriteLine("3x + 5 = 23\nSolve for x");
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
