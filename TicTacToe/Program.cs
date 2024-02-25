using System.Runtime.CompilerServices;
using TicTacToe;

// Main game

string[] arr = { "", " ", " ", " ", " ", " ", " ", " ", " ", " " };
bool gameRunning = true;
string player;
string player2;
Console.WriteLine("Welcome to my TicTacToe game!");
Thread.Sleep(1000);
Console.WriteLine("Who do you want to play as?");
player = Console.ReadLine();

MainGame(arr, player, ref gameRunning, "O");



static void MainGame(string[] arr, string player, ref bool gameRunning, string player2)
{
    while (gameRunning)
    {
        

        Console.WriteLine($"You are playing as {player}");
        Console.WriteLine("Where do you want to play? 1-9");
        GameBoardPrinter.PrintBoard(arr);
        string moveInput = Console.ReadLine();
        int move = Int32.Parse(moveInput);

        arr[move] = player;
        GameBoardPrinter.PrintBoard(arr);
        CheckWin(arr, player, ref gameRunning);

        Console.WriteLine($"Now is {player2}'s turn ");
        moveInput = Console.ReadLine();
        move = Int32.Parse(moveInput);
        arr[move] = player2;
        GameBoardPrinter.PrintBoard(arr);




    }
}


switch (gameRunning == false)
{
    case false:
        Console.WriteLine("Would you like to play again? Y/N");
        string finalChoice = Console.ReadLine();
        switch (finalChoice)
        {
            case "Y":
                MainGame(arr, "", ref gameRunning, "O");
                break;
        }
        break;
}

// Game logic

static void CheckWin(string[] arr, string player, ref bool gameRunning)
{
    // Check win horizontal

    if (arr[1] == player && arr[2] == player && arr[3] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[4] == player && arr[5] == player && arr[6] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[7] == player && arr[8] == player && arr[9] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }

    // Check win vertical
    if (arr[1] == player && arr[4] == player && arr[7] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[2] == player && arr[5] == player && arr[8] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[3] == player && arr[6] == player && arr[9] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }

    // Check win diagonal

    if (arr[1] == player && arr[5] == player && arr[9] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[3] == player && arr[5] == player && arr[7] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
}

static void SwitchPlayer(ref string player, ref string player2)
{
    switch (player)
    {
        case "X":
            player = player;
            player2 = "O";
            break;

        case "O":
            player = player;
            player2 = "X";
            break;

        default:
            break;
    }
}


















//Console.WriteLine("Would you like to play? Y/N");
//string choice1 = Console.ReadLine();


/*
 * 
 * while (choice1 != "Y" && choice1 != "N")
{
    Console.WriteLine("You have to type Y or N!");
    choice1 = Console.ReadLine();

    if (choice1 == "N" && choice1 == "Y")
    {
        break;
    }
}

if (choice1 == "Y")
{
    GameLogic.Game();
}

else if (choice1 == "N")
{
    Console.WriteLine("Exiting the application...");
    Thread.Sleep(1000);
    Environment.Exit(0);
}





Console.WriteLine("Test");
 */







