using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Player
    {
        public string name;
        public PlayingPiece playingPiece;

        public Player(string name, PlayingPiece playingPiece)
        {
            this.name = name;
            this.playingPiece = playingPiece;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public PlayingPiece GetPlayingPiece()
        {
            return playingPiece;
        }

        public void setPlayingPiece(PlayingPiece playingPiece)
        {
            this.playingPiece = playingPiece;
        }
    }
}
