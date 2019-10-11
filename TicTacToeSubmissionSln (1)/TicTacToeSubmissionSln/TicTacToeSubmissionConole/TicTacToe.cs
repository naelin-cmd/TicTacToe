using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private const int V = 0;
        private TicTacToeConsoleRenderer _boardRenderer;
       private char[] boardPositions = new char[9];

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }
        public bool WhoHasWon(char charToCheck)
        {
            if ((boardPositions[0] == charToCheck) && (boardPositions[1] == charToCheck) && (boardPositions[0] == charToCheck))
                return true;
            // COLUMN 1
            if ((boardPositions[1] == charToCheck) && (boardPositions[4] == charToCheck) && (boardPositions[7] == charToCheck))
                return true;
            return false;
        }


        public void Run()
        {
           






            for (int i = 0; i <boardPositions.Length; i++)
            {
                var charToCheck = Console.ReadLine();
                































                // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

                Console.SetCursorPosition(2, 19);

                Console.Write("Player X");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);

                //
                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();
                
                

                Console.SetCursorPosition(2, 19);

                Console.Write("Player Y");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row2 = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                var column2 = Console.ReadLine();


                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)




                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);




                _boardRenderer.AddMove(int.Parse(row2), int.Parse(column2), PlayerEnum.X, true);
                
            }

            
                
            
        }

    }
}

