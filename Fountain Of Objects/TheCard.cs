using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Program;

namespace IntroductionToC_.Fountain_Of_Objects
{
    public class TheCard
    {

        public void RunCard()
        {
            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
            Rank[] ranks = new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.Dollar, Rank.Percent, Rank.Caret, Rank.And };

            foreach (Color color in colors)
            {
                foreach (Rank rank in ranks)
                {
                    Card card = new Card(color, rank);
                    Console.WriteLine($"Color: {card.MyColor}, Rank: {card.MyRank}");
                }
            }

            /// <summary>
            /// We were creating colors in The clor class for a huge rnage of colors , here we need only  4 colors and we dont nned to know thier rgb values , just thier name so we can use an enum for that.
        }


        public class Card
        {
            private Color _color;
            private Rank _rank;


            public Color MyColor
            {
                get { return _color; }
                set { _color = value; }
            }

            public Rank MyRank
            {
                get { return _rank; }
                set { _rank = value; }
            }


            public Card(Color color, Rank rank)
            {
                _color = color;
                _rank = rank;
            }


            public bool IsSymbol => MyRank == Rank.Dollar || MyRank == Rank.Percent || MyRank == Rank.Caret || MyRank == Rank.And;
            public bool IsNumber => !IsSymbol;

        }


        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
        }

        public enum Rank
        {
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Dollar = '$',
            Percent = '%',
            Caret = '^',
            And = '&',
        }






    }
}
