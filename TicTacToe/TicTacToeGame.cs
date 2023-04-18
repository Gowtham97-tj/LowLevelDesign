using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        LinkedList<Player> players;
        Board gameBoard;
        int size;

        public TicTacToeGame(int size)
        {
            this.size = size;
        }

        public void initializeGame()
        {
            players = new LinkedList<Player>();
            PlayingPieceX crossPiece = new PlayingPieceX();
            Player player1 = new Player("Player1", crossPiece);
            PlayingPieceO noughtsPiece = new PlayingPieceO();
            Player player2 = new Player("Player2", noughtsPiece);
            players.AddLast(player1);
            players.AddLast(player2);

            gameBoard = new Board(3);
        }
        public string startGame()
        {
            bool noWinner = true;

            while(noWinner)
            {
                Player playerTurn = players.First.Value;
                players.RemoveFirst();

                gameBoard.printBoard();
                List<KeyValuePair<int, int>> freeSpaces = gameBoard.getFreeCells();

                if(freeSpaces.Count == 0)
                {
                    noWinner = false;
                    continue;
                }

                Console.WriteLine("Player " + playerTurn.name + " Enter row, column: ");
                string input = Console.ReadLine();
                string[] strArray = input.Split(',');
                int inputRow = int.Parse(strArray[0]);
                int inputColumn = int.Parse(strArray[1]);

                if (inputRow >= size || inputColumn >= size)
                {
                    Console.WriteLine("Invalid input");
                    break;
                }

                bool pieceAddedSuccessfully = gameBoard.addPiece(inputRow, inputColumn, playerTurn.playingPiece);
                if (!pieceAddedSuccessfully)
                {
                    Console.WriteLine("Incorredt possition chosen, try again");
                    players.AddFirst(playerTurn);
                    continue;
                }
                players.AddLast(playerTurn);

                bool winner = isThereWinner(inputRow, inputColumn, playerTurn.playingPiece.pieceType);
                if (winner)
                {
                    return playerTurn.name;
                }

            }
            return "tie";
        }

        public bool isThereWinner(int row, int column, PieceType pieceType)
        {

            bool rowMatch = true;
            bool columnMatch = true;
            bool diagonalMatch = true;
            bool antiDiagonalMatch = true;

            //need to check in row
            for (int i = 0; i < gameBoard.size; i++)
            {

                if (gameBoard.board[row, i] == null || gameBoard.board[row, i].pieceType != pieceType)
                {
                    rowMatch = false;
                }
            }

            //need to check in column
            for (int i = 0; i < gameBoard.size; i++)
            {

                if (gameBoard.board[i, column] == null || gameBoard.board[i, column].pieceType != pieceType)
                {
                    columnMatch = false;
                }
            }

            //need to check diagonals
            for (int i = 0, j = 0; i < gameBoard.size; i++, j++)
            {
                if (gameBoard.board[i, j] == null || gameBoard.board[i, j].pieceType != pieceType)
                {
                    diagonalMatch = false;
                }
            }

            //need to check anti-diagonals
            for (int i = 0, j = gameBoard.size - 1; i < gameBoard.size; i++, j--)
            {
                if (gameBoard.board[i, j] == null || gameBoard.board[i, j].pieceType != pieceType)
                {
                    antiDiagonalMatch = false;
                }
            }

            return rowMatch || columnMatch || diagonalMatch || antiDiagonalMatch;
        }


    }
}
