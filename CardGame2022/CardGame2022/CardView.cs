using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2022
{
    internal class CardView
    {
        public Point Position;
        public int Card;
        public int Malus {
            get {
                return CardsHandling.MalusValue(Card);
            }
        }
        public Size Taille = new Size(40, 55);

        public void Draw(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(Position.X, Position.Y, Taille.Width,Taille.Height);

            // Draw rectangle to screen.
            e.Graphics.FillRectangle(Brushes.DarkRed, rect);
            String s = "" + Card;
            if (Card < 10)
            {
                e.Graphics.DrawString(s, new Font("Arial", 15, FontStyle.Regular), Brushes.White, Position.X + 11, Position.Y + 13);

            } else if ( 10 <= Card && Card < 100 )
            {
                e.Graphics.DrawString(s, new Font("Arial", 15, FontStyle.Regular), Brushes.White, Position.X + 6, Position.Y + 13);
            }
            else
            {
                e.Graphics.DrawString(s, new Font("Arial", 15, FontStyle.Regular), Brushes.White, Position.X, Position.Y + 13);
            }
            String s2 = "" + Malus;
            e.Graphics.DrawString(s2, new Font("Arial", 10, FontStyle.Regular), Brushes.PeachPuff, Position.X + 15, Position.Y + 35);
        }


        public bool Contains(Point p)
        {
            Rectangle r = new Rectangle(Position, Taille);    
            return r.Contains(p);
        }
    }
}
