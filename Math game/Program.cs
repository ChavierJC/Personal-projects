/* Menu with 4 types of games : sum, substraccion,mult,divi
5 questions per game
list of previous games */

using System.Reflection.Metadata;

string? userInput;

string[] gameHistory = new string[10];
int[] scoreHistory = new int[10];
int[] difficultyHistory = new int [10];

bool exitGame = false;
int count = 0;

while (!exitGame)
{
    Console.WriteLine("Welcome to the math game");
    Console.WriteLine($"Write the number of the option you whish to select. (or type 'exit' to close the game)\n");

    Console.WriteLine("1. Summ game.");
    Console.WriteLine("2. Substraction game.");
    Console.WriteLine("3. Multiplication game.");
    Console.WriteLine("4. Division game.");
    Console.WriteLine("5. View game history.");
    userInput = Console.ReadLine();
    if (userInput != null)
    {
        userInput = userInput.ToLower();

        switch (userInput)
        {
            case "1":
                SummGame(count);
                count++;
                break;

            case "2":
                SubstrGame(count);
                count++;
                break;

            case "3":
                MultGame(count);
                count++;
                break;

            case "4":
                DivisGame(count);
                count++;
                break;

            case "5":
                GameHistory();
                break;

            case "exit":
                exitGame = true;
                break;

            default:
                Console.WriteLine("Please choose a valid option");
                break;
        }
    }
}

Console.Clear();

//Create 5 summs, present to the player one at a time and recive input
void SummGame(int count)
{
    gameHistory[count] = "Summ game";
    Console.WriteLine("Choose a difficulty level (Easy / Medium / Hard)");
    userInput = Console.ReadLine();
    string difficulty= userInput;
    int score = 0;
    for (int i = 0; i <= 4; i++)
    {
        int firstNumber = GameDifficulty(difficulty);
        int secondNumber = GameDifficulty(difficulty);
        int result = firstNumber + secondNumber;
        int answer;


        Console.WriteLine("Addition game");
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        userInput = Console.ReadLine();
        if (userInput != null)
        {
            if (int.TryParse(userInput, out answer))
            {
                if (result == answer)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
    scoreHistory[count] = score;
}

void SubstrGame(int count)
{
    gameHistory[count] = "Substraction game";
    Random random = new Random();
    int score = 0;
    for (int i = 0; i <= 4; i++)
    {
        int firstNumber = random.Next(0, 10);
        int secondNumber = random.Next(0, 10);
        int result = firstNumber - secondNumber;
        int answer;


        Console.WriteLine("Substraction game");
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        userInput = Console.ReadLine();
        if (userInput != null)
        {
            if (int.TryParse(userInput, out answer))
            {
                if (result == answer)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
    scoreHistory[count] = score;
}

void MultGame(int count)
{
    gameHistory[count] = "Multiplication game";
    Random random = new Random();
    int score = 0;
    for (int i = 0; i <= 4; i++)
    {
        int firstNumber = random.Next(0, 10);
        int secondNumber = random.Next(0, 10);
        int result = firstNumber * secondNumber;
        int answer;


        Console.WriteLine("Multiplication game");
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        userInput = Console.ReadLine();
        if (userInput != null)
        {
            if (int.TryParse(userInput, out answer))
            {
                if (result == answer)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
    scoreHistory[count] = score;
}

void DivisGame(int count)
{
    Random random = new Random();
    gameHistory[count] = "Division game";
    int score = 0;
    for (int i = 0; i <= 4; i++)
    {
        //To ensure divisibility and low number generation
        int firstNumber = random.Next(0, 10);
        int dividend = random.Next(0, 6);
        int result = firstNumber * dividend;
        int answer;


        Console.WriteLine("Multiplication game");
        Console.WriteLine($"{result} / {firstNumber}");
        userInput = Console.ReadLine();
        if (userInput != null)
        {
            if (int.TryParse(userInput, out answer))
            {
                if (dividend == answer)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
    scoreHistory[count] = score;
}

//shows game history to users.
void GameHistory()
{
    Console.WriteLine("The game history is as follows");

    for (int i = 0; i <= 10; i++)
    {
        if (gameHistory[i] != null)
        {
            Console.WriteLine($"Game {i + 1}: {gameHistory[i]} \t score: {scoreHistory[i]} \t difficulty: {difficultyHistory[i]}");
        }
        else
        {
            Console.WriteLine("Enter any key to exit game history");
            Console.ReadKey();
            Console.Clear();
            return;
        }
    }
    Console.WriteLine("Enter any key to exit game history");
    Console.ReadKey();
    Console.Clear();
    return;
}

int GameDifficulty(string difficulty)
{
    if (difficulty !=null)
    {
        difficulty.ToLower();
        Random random = new Random();
        switch (difficulty)
        {
            case "easy":
            return (random.Next(1,5));

            case "medium":
            return (random.Next(6,20));

            case "hard":
            return (random.Next(21,40));

            default:
            return 0;
        }
    }
    return 0;
}
