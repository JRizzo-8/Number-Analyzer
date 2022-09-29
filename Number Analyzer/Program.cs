Console.WriteLine("Hello, Could I please get your name before we begin:");
string userName = Console.ReadLine();

bool tryAgain = true;
while (tryAgain == true)
{



    Console.WriteLine($"Hello {userName}, now please enter a number between 1 and 100:");
    string userChoice = Console.ReadLine();
    int userNumber;
    int.TryParse(userChoice, out userNumber);

    if (userNumber >= 1 && userNumber <= 100)
    {
        if (userNumber % 2 != 0)
        {
            if (userNumber < 60)
            {
                Console.WriteLine($"{userNumber} is odd and less than 60");
            }
            else if (userNumber > 60)
            {
                Console.WriteLine($"{userNumber} is odd and greater than 60");
            }
        }
        else if (userNumber % 2 == 0)
        {
            if (userNumber >= 2 && userNumber <= 24)
            {
                Console.WriteLine($"{userNumber} is even and less than 25");
            }
            else if (userNumber >= 26 && userNumber <= 60)
            {
                Console.WriteLine($"{userNumber} is even and between 26 and 60");
            }
            else if (userNumber > 60)
            {
                Console.WriteLine($"{userNumber} is even and greater than 60");
            }
        }
    }
    else
    {
        Console.WriteLine($"{userName}, you must enter a number between 1 and 100, please press a key to exit and try again");
        break;
    }

    Console.WriteLine($"Would you like to try another number {userName}? please enter yes or y to go again, enter anything else to quit");
    string playAgain = Console.ReadLine().ToLower();

    if (playAgain == "yes" || playAgain == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine($" Thank you for using my number analyzer {userName} and don't have a good day, have a great day!");
        tryAgain = false;
    }

}


Console.ReadKey();
