using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
namespace SeaChess
{
    class Program
    {
        const int BOARD_ROWS = 3;
        const int BOARD_COLUMNS = 3;
        const int MAX_NUMBER_OF_MOVES = BOARD_ROWS * BOARD_COLUMNS;
        const char PLAYER1MARK = 'X';
        const char PLAYER2MARK = 'O';
        static void Main(string[] args)
        {
            char[,] gameBoard = InitBoard();
            int xCoord = 0;
            int yCoord = 0;
            int playerCounter = 0; 
            int currentPlayer = 1;
            char currentPlayerMark = 'X';

            for (int i = 0; i < MAX_NUMBER_OF_MOVES; i++)
            {                    
                    currentPlayer = playerCounter % 2 == 0 ? 1 : 2; 

                    PrintBoard(gameBoard);
                    if(CheckForWinningMove(gameBoard,currentPlayerMark) || CheckDiagonals(gameBoard, currentPlayerMark))
                    {
                        PrintBoard(gameBoard);
                        Console.WriteLine($"Player {currentPlayerMark} wins");
                        break;
                    }
                    if(currentPlayer == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        currentPlayerMark = 'X';

                        Console.WriteLine("Player 1's turn. -> Place an X");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        currentPlayerMark = 'O';

                        Console.WriteLine("Player 2's turn -> Place a O");
                    }
            
                   Console.WriteLine("Enter x coordinate [0-2]: ");
                   xCoord = PromptUserForX(int.Parse(Console.ReadLine()), gameBoard, currentPlayerMark);
                                   
                   Console.WriteLine("Enter y coordinate [0-2]: ");
                   yCoord = PromptUserForY(int.Parse(Console.ReadLine()), gameBoard, currentPlayerMark);

                   List<dynamic> isTakenList = CheckIfGameFieldTaken(xCoord, yCoord, gameBoard,currentPlayerMark);

                   if(isTakenList[0] == false)
                   {
                        if(currentPlayer == 1)
                        {
                            gameBoard[isTakenList[1],isTakenList[2]] = 'X';
                        }
                        else
                        {
                            gameBoard[isTakenList[1],isTakenList[2]] = 'O';
                        }
                   }
                   playerCounter++;
            }
        }
        static bool CheckForWinningMove(char[,] board, char playerMark)
        {
            int playerMarkCounter = 0;

            for (int i = 0; i < BOARD_ROWS; i++)
            {
                for (int j = 0; j < BOARD_COLUMNS; j++)
                {
                    if(board[i, j] == playerMark)
                    {
                        playerMarkCounter++;
                    }
                }

                if(playerMarkCounter == BOARD_ROWS)
                {
                    return true;
                }

                playerMarkCounter = 0;
            }

            for (int i = 0; i < BOARD_COLUMNS; i++)
            {
                for (int j = 0; j < BOARD_ROWS; j++)
                {
                    if (board[i, j] == playerMark)
                    {
                        playerMarkCounter++;
                    }
                }

                if (playerMarkCounter == BOARD_COLUMNS)
                {
                    return true;
                }

                playerMarkCounter = 0;
            }

            if (BOARD_ROWS == BOARD_COLUMNS)
            {
                for (int i = 0; i < BOARD_ROWS; i++)
                {
                    if(board[i, i] == playerMark) // checking horizontally
                    {
                        playerMarkCounter++;
                    }

                    if (playerMarkCounter == BOARD_COLUMNS) 
                    {
                        return true;
                    }
                    playerMarkCounter = 0;
                }

            }
            return false;
        }
        
        static bool CheckDiagonals(char[,] board, char playerMark)
        {
            if (board[0,0] == playerMark && board[1,1] == playerMark && board[2,2] == playerMark)
            {
                return true;
            }  
            if (board[2,0] == playerMark && board[1,1] == playerMark && board[0,2] == playerMark)
            {
                return true;
            }  
            return false;
        }
        static List<dynamic> CheckIfGameFieldTaken(int xCoordinate, int yCoordinate, char[,] gameBoardState, char currentPlayerMark)
        {            
            bool isTaken = false;

            List<dynamic> coordinatesList = new List<dynamic>();

            if(gameBoardState[xCoordinate,yCoordinate] != '-')
            {
                isTaken = true;
                Console.WriteLine("That field is already taken !");
                        
                Console.WriteLine("Please enter a new x coordinate: ");
                xCoordinate = PromptUserForX(int.Parse(Console.ReadLine()), gameBoardState,currentPlayerMark);

                Console.WriteLine("Please enter a new y coordinate: ");
                yCoordinate = PromptUserForY(int.Parse(Console.ReadLine()), gameBoardState, currentPlayerMark);

                return CheckIfGameFieldTaken(xCoordinate, yCoordinate, gameBoardState, currentPlayerMark);
            }
            coordinatesList.Add(isTaken);
            coordinatesList.Add(xCoordinate);
            coordinatesList.Add(yCoordinate);

            return coordinatesList;
        }
        static int PromptUserForX(int xCoordinate, char[,] gameBoard, char currentPlayerMark)
        {
            if(xCoordinate > 2 || xCoordinate < 0)
            {
                Console.WriteLine("Please enter a valid x coordinate [0-2]: ");

                xCoordinate = int.Parse(Console.ReadLine());

                return PromptUserForX(xCoordinate,gameBoard,currentPlayerMark);
            }

            return xCoordinate;
        }

         static int PromptUserForY(int yCoordinate, char[,] gameBoard, char currentPlayerMark)
        {
            if(CheckForWinningMove(gameBoard,currentPlayerMark))
            {
                Console.WriteLine("WIN");
                PrintBoard(gameBoard);
                Environment.Exit(0);
            }
            if(yCoordinate > 2 || yCoordinate < 0)
            {
                Console.WriteLine("Please enter a valid y coordinate [0-2]: ");

                yCoordinate = int.Parse(Console.ReadLine());

                return PromptUserForY(yCoordinate, gameBoard, currentPlayerMark);
            }

            return yCoordinate;
        }
        static void PrintBoard(char[,] gameBoard)
        {
            Console.Clear();
            for (int row = 0; row < BOARD_ROWS; row++)
            {
                for (int col = 0; col < BOARD_COLUMNS; col++)
                {
                    
                    Console.Write(string.Format("{0} ", gameBoard[row, col]));
                }
                Console.Write("\n"+"\n");
            }
        }
        static char[,] InitBoard()
        {
            char[,] result = new char[BOARD_ROWS, BOARD_COLUMNS];
            for(int i = 0; i < BOARD_ROWS; i++)
            {
                for (int j = 0; j < BOARD_COLUMNS; j++)
                {
                    result[i, j] = '-';
                }
            }

            return result;
        }
    }
    
}
