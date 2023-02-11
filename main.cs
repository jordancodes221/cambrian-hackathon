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

            switch (menuSelection)
            {
                case 1:
                    Console.WriteLine("It's the morning of the hackathon! You s ");

                    string menuInput = Console.ReadLine();

                    if (menuInput == "")
                    {

                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    break;

                case 2:
                    Console.WriteLine("\nGoodbye!\n");
                    Environment.Exit(0);
                    break;


            }


                    Console.WriteLine("You're running late and looks like it snowed a lot last night! Do you: \n Get in your car and leave (1)");
            Console.WriteLine("Shovel the driveway (2)");
