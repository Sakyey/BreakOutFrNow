using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout134
{
    public class Boll
    {
        Texture2D bolltex;
        Vector2 bollPos;
        Vector2 bollDir;
        Rectangle bollRec;
        public bool crash;
        bool changeDir;
        int maximumX = 800;
        int maximumY = -600;
        int minimumX = 0;
        int minimumY = 0;
        public Boll(Texture2D bolltex, Vector2 bollPos)
        {
            this.bolltex = bolltex;
            this.bollPos = bollPos;
            bollRec = new Rectangle((int)bollPos.X, (int)bollPos.Y, 50, 50);
            crash = false;
            bollDir = new Vector2(7, -4);
            changeDir = false;
        }
        public void Update()
        {
            bollPos.X = bollPos.X + bollDir.X;
            bollPos.Y = bollPos.Y + bollDir.Y;
        }
        public void CheckCrash(Rectangle block)
        {
            if (bollRec.Intersects(block))
            {
                crash = true;
                if (bollPos.X < maximumX && bollPos.X> minimumX)
                {
                    changeDir = false;
                }
                else
                {
                    bollDir.X = bollDir.X * -1;
                    changeDir = true;
                }
                if (bollPos.Y > maximumY && bollPos.Y< minimumY)
                {
                    changeDir = false;
                }
                else
                {
                    bollDir.Y = bollDir.Y * -1; 
                    changeDir = true;
                }

            }
        }
    }
}
