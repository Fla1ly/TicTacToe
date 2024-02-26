using System.Runtime.CompilerServices;
using TicTacToe;

// Main game

string[] arr = { "", " ", " ", " ", " ", " ", " ", " ", " ", " " };
bool gameRunning = true;
string player;
string player2 = string.Empty;
Console.WriteLine("Welcome to my TicTacToe game!");
Thread.Sleep(1000);
Console.WriteLine("Who do you want to play as?");
player = Console.ReadLine();
Console.WriteLine($"You are playing as {player}");



MainGame(arr, player, ref gameRunning, player2);




static void MainGame(string[] arr, string player, ref bool gameRunning, string player2)
{
    while (gameRunning)
    {
        bool spotTaken = false;

        if (player == "X")
        {
            player2 = "O";
        }
        else if (player == "O")
        {
            player2 = "X";
        }

        Console.WriteLine("Where do you want to play? 1-9");
        GameBoardPrinter.PrintBoard(arr);
        string moveInput = Console.ReadLine();
        int move = Int32.Parse(moveInput);
        bool firstMoveDone = true;
        arr[move] = player;
        GameBoardPrinter.PrintBoard(arr);
        // CheckWin(arr, player, player2, ref gameRunning);

        while (firstMoveDone)
        {
            Console.WriteLine($"Now is {player2}'s turn ");
            moveInput = Console.ReadLine();
            move = Int32.Parse(moveInput);
            arr[move] = player2;
            GameBoardPrinter.PrintBoard(arr);

            Console.WriteLine($"Now is {player}'s turn ");
            moveInput = Console.ReadLine();
            move = Int32.Parse(moveInput);
            arr[move] = player;
            GameBoardPrinter.PrintBoard(arr);

            if (arr[move] == player || arr[move] == player2)
            {
                spotTaken = true;
                Console.WriteLine("Spot already taken, choose another spot");

            }


            while (spotTaken == true)
            {
                moveInput = Console.ReadLine();
                move = Int32.Parse(moveInput);

                if (arr[move] == "")
                {
                    arr[move] = player;
                    GameBoardPrinter.PrintBoard(arr);
                    break;
                }
                else
                {
                    Console.WriteLine("Spot is still taken");
                }
            }
        }


       

        



        


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
                MainGame(arr, "", ref gameRunning, "");
                break;
        }
        break;
}

// Game logic

static void CheckWin(string[] arr, string player, string player2, ref bool gameRunning)
{
    // Check win horizontal

    if (arr[1] == player && arr[2] == player && arr[3] == player ||
        arr[4] == player && arr[5] == player && arr[6] == player ||
        arr[7] == player && arr[8] == player && arr[9] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[1] == player2 && arr[2] == player2 && arr[3] == player2 ||
             arr[4] == player2 && arr[5] == player2 && arr[6] == player2 ||
             arr[7] == player2 && arr[8] == player2 && arr[9] == player2)
    {
        Console.WriteLine($"Player {player2} won!");
        gameRunning = false;
    }

    // Check win vertical
    if (arr[1] == player && arr[4] == player && arr[7] == player ||
        arr[2] == player && arr[5] == player && arr[8] == player ||
        arr[3] == player && arr[6] == player && arr[9] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[1] == player2 && arr[4] == player2 && arr[7] == player2 ||
             arr[2] == player2 && arr[5] == player2 && arr[8] == player2 ||
             arr[3] == player2 && arr[6] == player2 && arr[9] == player2)
    {
        Console.WriteLine($"Player {player2} won!");
        gameRunning = false;
    }

    // Check win diagonal

    if (arr[1] == player && arr[5] == player && arr[9] == player ||
        arr[3] == player && arr[5] == player && arr[7] == player)
    {
        Console.WriteLine($"Player {player} won!");
        gameRunning = false;
    }
    else if (arr[1] == player2 && arr[5] == player2 && arr[9] == player2 ||
             arr[3] == player2 && arr[5] == player2 && arr[7] == player2)
    {
        Console.WriteLine($"Player {player2} won!");
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







