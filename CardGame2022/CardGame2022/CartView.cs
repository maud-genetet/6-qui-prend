using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame2022
{
    class CartView
    {
        Point Position;
        int Taille = 10;
        int Card;
        int Penalite;




        CartView(Point position, int card, int penalite)
        {
            this.Position = position;   
            this.Card = card;
            this.Penalite = CardsHandling.MalusValue(Card);
        }



        void Draw()
        {
                Rectangle r = new Rectangle(Position, Taille);
                 g.DrawRectangle(p, r);
            
        }

       





    }
}
