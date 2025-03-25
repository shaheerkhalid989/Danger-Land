using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace frameworks.Movement
{
    public class keyBoard : IMovement
    {
        private int speed;
        private Point Boundary;
        private String keyAction;
        private int imageWidth;
        private int imageHeight;

        public keyBoard(int speed, Point Boundary, int imageWidth, int imageHeight)
        {
            this.speed = speed;
            this.Boundary = Boundary;
            this.imageWidth = imageWidth + 20;
            this.imageHeight = imageHeight;
            keyAction = null;
        }

        public void keyPressedByUser(Keys keyCode)
        {
            if(keyCode == Keys.Up)
            {
                keyAction = "up";
            }

            if (keyCode == Keys.Down)
            {
                keyAction = "down";
            }

            if (keyCode == Keys.Left)
            {
                keyAction = "left";
            }

            if (keyCode == Keys.Right)
            {
                keyAction = "right";
            }
        }

        public Point move(Point location)
        {
            if (keyAction != null)
            {
                if (keyAction == "up")
                {
                    if (location.Y >= 0)
                        location.Y -= speed;
                }

                if (keyAction == "down")
                {
                    if (location.Y + imageHeight <= Boundary.Y)
                        location.Y += speed;
                }

                if (keyAction == "left")
                {
                    if (location.X >= 0)
                        location.X -= speed;
                }
                if (keyAction == "right")
                {
                    if (location.X + imageWidth <= Boundary.X)
                        location.X += speed;
                }
                keyAction = null;
            }
            return location;
        }
     }
}
