using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        public int size;
        public PlayingPiece[,] board;

        public Board(int size)
        {
            this.size = size;
            board = new PlayingPiece[size, size];
        }

        public Boolean addPiece(int row, int column, PlayingPiece playingPiece)
        {
            if(board[row, column] != null)
            {
                return false;
            }
            board[row, column] = playingPiece;
            return true;
        }

        public List<KeyValuePair<int, int>> getFreeCells()
        {
            List<KeyValuePair<int, int>> freeCells = new List<KeyValuePair<int, int>>();

            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    if(board[i, j] == null)
                    {
                        KeyValuePair<int, int> rowColumn = new KeyValuePair<int, int>();
                        freeCells.Add(rowColumn);
                    }
                }
            }

            return freeCells;
        }

        public void printBoard()
        {
            for(int i=0; i<size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(board[i, j] != null)
                    {
                        Console.Write(board[i, j].pieceType);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }

    }
}
