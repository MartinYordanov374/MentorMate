using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
namespace SeaChess
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] gameBoard = new char[3,3]
            {
                {'-','-','-'},
                {'-', '-', '-'},
                {'-', '-', '-'}
            };

            int xCoord = 0;
            int yCoord = 0;
            int playerCounter = 0; // even numbers for player 1 and odd numbers for player 2
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    
                   Console.WriteLine("Enter x coordinate: ");
                   xCoord = promptUserForX(int.Parse(Console.ReadLine()));
                                   
                   Console.WriteLine("Enter y coordinate: ");
                   yCoord = promptUserForY(int.Parse(Console.ReadLine()));

                   List<dynamic> isTakenList = checkIfGameFieldTaken(xCoord, yCoord, gameBoard);

                   if(isTakenList[0] == false)
                   {
                        if(playerCounter % 2 == 0 )
                        {
                            gameBoard[isTakenList[1],isTakenList[2]] = 'X';
                        }
                        else
                        {
                            gameBoard[isTakenList[1],isTakenList[2]] = 'O';
                        }
                        if(checkIfWinningHorizontally(gameBoard) == true || checkIfWinningVertically(gameBoard) == true || checkIfWinningDiagonally(gameBoard) == true)
                        {
                            System.Console.WriteLine("WIN");
                            printBoard(gameBoard);
                            Environment.Exit(0);
                        }
                   }
                    printBoard(gameBoard);

                   playerCounter++;

                }
            }

        }
        static int promptUserForX(int xCoordinate)
        {
            
            if(xCoordinate > 2 || xCoordinate < 0)
            {
                Console.WriteLine("Please enter a valid x coordinate [0-2]: ");

                xCoordinate = int.Parse(Console.ReadLine());

                return promptUserForX(xCoordinate);
            }

            return xCoordinate;
        }

         static int promptUserForY(int yCoordinate)
        {

            if(yCoordinate > 2 || yCoordinate < 0)
            {
                Console.WriteLine("Please enter a valid y coordinate [0-2]: ");

                yCoordinate = int.Parse(Console.ReadLine());

                return promptUserForY(yCoordinate);
            }

            return yCoordinate;
        }

        static List<dynamic> checkIfGameFieldTaken(int xCoordinate, int yCoordinate, char[,] gameBoardState)
        {            
            bool isTaken = false;

            List<dynamic> coordinatesList = new List<dynamic>();

            if(gameBoardState[xCoordinate,yCoordinate] != '-')
            {
                isTaken = true;
                Console.WriteLine("That field is already taken !");
                        
                Console.WriteLine("Please enter a new x coordinate: ");
                xCoordinate = promptUserForX(int.Parse(Console.ReadLine()));

                Console.WriteLine("Please enter a new y coordinate: ");
                yCoordinate = promptUserForY(int.Parse(Console.ReadLine()));

                return checkIfGameFieldTaken(xCoordinate, yCoordinate, gameBoardState);
            }
            coordinatesList.Add(isTaken);
            coordinatesList.Add(xCoordinate);
            coordinatesList.Add(yCoordinate);

            return coordinatesList;
        }

        static bool checkIfWinningHorizontally(char[,] gameBoardState)
        {
            
            // check horizontally first
            string rowOne = "";
            string rowTwo = "";
            string rowThree = "";
            for (int i = 0; i < 3; i++)
            {
                rowOne += gameBoardState[0,i];
            }
            for (int i = 0; i < 3; i++)
            {
                rowTwo += gameBoardState[1,i];
            }
            for (int i = 0; i < 3; i++)
            {
                rowThree += gameBoardState[2,i];
            }
            if((rowOne == "XXX" || rowOne == "OOO") || 
                (rowTwo == "XXX" || rowTwo == "OOO") || 
                (rowThree == "XXX" || rowThree == "OOO"))
            {
                return true;
            }
            // check vertically second
            
            // finally check diagonally

            return false;
        }

        static bool checkIfWinningVertically(char[,] gameBoardState)
        {
            
            // check horizontally first
            string colOne = "";
            string colTwo = "";
            string colThree = "";
            for (int i = 0; i < 3; i++)
            {
                colOne += gameBoardState[i,0];
            }
            for (int i = 0; i < 3; i++)
            {
                colTwo += gameBoardState[i,1];
            }
            for (int i = 0; i < 3; i++)
            {
                colThree += gameBoardState[i,2];
            }
            if((colOne == "XXX" || colOne == "OOO") || 
                (colTwo == "XXX" || colTwo == "OOO") || 
                (colThree == "XXX" || colThree == "OOO"))
            {
                return true;
            }
            // check vertically second
            
            // finally check diagonally
            return false;
        }
        static bool checkIfWinningDiagonally(char[,] gameBoardState)
        {
            
            // check horizontally first
            string diagonalOne = "";
            string diagonalTwo = "";
            for (int i = 0; i < 3; i++)
            {
                if(gameBoardState[i,i] != '-')
                {
                    diagonalOne += gameBoardState[i,i];
                }
            }
            System.Console.WriteLine(diagonalOne);
            if((diagonalOne == "XXX" || diagonalOne == "OOO"))
            {
                return true;
            }
            
            return false;
        }

        static void printBoard(char[,] gameBoard)
        {
            for (int row = 0; row < gameBoard.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.GetLength(1); col++)
                {
                    
                    Console.Write(string.Format("{0} ", gameBoard[row, col]));
                }
                Console.Write("\n"+"\n");
            }
        }
    }
    
}
