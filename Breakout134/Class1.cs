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
        public Texture2D bollTex;
        public Vector2 bollPos;
        public Vector2 bollDir;
        public Rectangle bollRec;
        public bool crash;
        public bool changeDir;
        public int maximumX = 800;
        public int maximumY = -600;
        public int minimumX = 0;
        public int minimumY = 0;
        public Boll(Texture2D bollTex, Vector2 bollPos)
        {
            this.bollTex = bollTex;
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
