int userChoice;

// do while: app should run once, then give the user the option to either terminate or loop the app
do {
    userChoice = 0;
    // The Menu //
    Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    Console.WriteLine("1. The Grade Checker");
    Console.WriteLine("2. The Dice Table");
    Console.WriteLine("3. The Score Report");
    Console.WriteLine("4. All Three");
    Console.WriteLine("5. Quit");
    Console.Write("Choose 1 through 5: ");
    userChoice = Convert.ToInt32(Console.ReadLine());
    
    // while: If the user's choice is invalid, they must be told so and enter a valid input
    while(userChoice < 1 || userChoice > 5)
    {
        Console.WriteLine("Choose a number 1 to 5.");
        Console.Write("Choose 1 through 5: ");
        userChoice = Convert.ToInt32(Console.ReadLine());
    }


    if (userChoice == 1 || userChoice == 4)
    {
        
        Excercise1();

    }

    if (userChoice == 2 || userChoice == 4)
    {
        
    }

    if (userChoice == 3 || userChoice == 4)
    {
        
    }

} while (userChoice != 5);

Console.WriteLine("\nGoodbye.");



static void Excercise1()
{
    Console.WriteLine("=== Excercise 1: The Grade Checker");

    Console.Write("Score: ");
    int score = Convert.ToInt32(Console.ReadLine());

    while (score < 0 || score > 100)
    {
        Console.WriteLine("A score must be between 0 and 100");
        Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());
    }
    

}