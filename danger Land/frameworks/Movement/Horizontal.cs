using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace frameworks.Movement
{
    public class Horizontal : IMovement
    {
        private int speed;
        private Point Boundary;
        private String direction;
        private int imageWidth;

        public Horizontal (int speed, Point Boundary, string direction, int imageWidth)
        {
            this.speed = speed;
            this.Boundary = Boundary;
            this.direction = direction;
            this.imageWidth = imageWidth + 10;
        }

        public Point move(Point location)
        {
            if (location.X <= 0)
            {
                direction = "Right";
            }

            if(location.X + imageWidth >= Boundary.X)
            {
                direction = "Left";
            }

            if(direction == "Right")
            {
                location.X += speed;
            }

            if (direction == "Left")
            {
                location.X -= speed;
            }
            return location;
        }
    }
}
