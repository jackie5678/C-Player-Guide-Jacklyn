using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.TIC_TAC_TOE
{
    internal class Player
    {

        public PlayerType TYPE {  get; private set; }

        public Player(PlayerType type)
        {
            this.TYPE = type;
        }


    }
}

public enum PlayerType
{
    XPLayer,
    OPlayer
}