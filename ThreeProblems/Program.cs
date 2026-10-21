/*
* Name:         Lucas Williams
* Course:       CSCI 1250, Section 002
* Assignment:   Lab 06, Three Short Problems
* Date:         October 21, 2026
* Description:  A menu that keeps running until the user quits, offering three
*               independent exercises or all three at once. Each exercise
*               practices decisions and one of the four loops.
*/

Random rng = new Random(4000);
int userChoice;

// do while: app should run once, then give the user the option to either terminate or loop the app
do {
    userChoice = 5;
    // The Menu //
    Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
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
        Console.WriteLine("Choose a number from 1 to 5.");
        Console.Write("Choose 1 through 5: ");
        userChoice = Convert.ToInt32(Console.ReadLine());
    }

    // Exercise 1 //
    if (userChoice == 1 || userChoice == 4)
    {
        
        Console.WriteLine("\n=== Excercise 1: The Grade Checker ===");

        Console.Write("Score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        // while: If the user's score is invalid, they must be told so and enter a valid input
        while (score < 0 || score > 100)
        {
            Console.WriteLine("A score must be between 0 and 100.");
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());
        }

        string letterGrade = "an F";
        if (score >= 90)
        {
            letterGrade = "an A";
        } 
        else if (score >= 80)
        {
            letterGrade = "a B";
        }
        else if (score >= 70)
        {
            letterGrade = "a C";
        }
        else if (score >= 60)
        {
            letterGrade = "a D";
        }

        Console.WriteLine($"{score} earns {letterGrade}.");

    }

    // Exercise 2 //
    if (userChoice == 2 || userChoice == 4)
    {
        Console.WriteLine("\n=== Excecise 2: The Dice Table ===");

        int totalRolls = 0;
        int totalWins = 0;
        string response;
        // do while: user must roll dice at least once, and they must be asked to roll again. Only if they decline will they exit.
        do
        {
            int roll1 = rng.Next(1, 7);
            int roll2 = rng.Next(1, 7);
            int total = roll1 + roll2;
            
            totalRolls++;

            string result = "";
            if (roll1 == 1 && roll2 == 1 )
            {
                result = " Snake eyes.";
            } 
            else if (roll1 == roll2)
            {
                result = " Doubles!";
            } 
            else if (total == 7 || total == 11)
            {
                result = " A winner.";
                totalWins++;
            }

            Console.WriteLine($"Roll {totalRolls}: {roll1} and {roll2}, total {total}.{result}");

            Console.Write("Roll again? (y/n): ");
            response = Console.ReadLine()?.ToUpper() ?? "";
        } while (response != "N");

        Console.WriteLine($"You rolled {totalRolls} time{(totalRolls != 1 ? "s" : "")} and won {totalWins}");
    }

    // Excercise 3 //
    if (userChoice == 3 || userChoice == 4)
    {
        Console.WriteLine("\n=== Excercise 3: The Score Report ===");

        int[] scores = new int[5];

        // for: must ask for a score to fill up the scores array, so it needs to know which score it is for the position and the question
        for(int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }


        // foreach: must run the logic for each score in the scores list, but there is no need for an index
        int totaledScores = 0;
        int highestScore = 0;
        int totalPassingScores = 0;
        foreach(int score in scores)
        {
            totaledScores += score;

            highestScore = Math.Max(highestScore, score);

            if (score >= 60)
            {
                totalPassingScores++;
            }
        }

        double averageScore = (double)totaledScores / scores.Length;

        Console.WriteLine($"\nScores entered: {scores.Length}");
        Console.WriteLine($"Total: {totaledScores}");
        Console.WriteLine($"Average: {averageScore}");
        Console.WriteLine($"Highest: {highestScore}");
        Console.WriteLine($"Passing: {totalPassingScores} of {scores.Length}");
    }

} while (userChoice != 5);

Console.WriteLine("\nGoodbye.");