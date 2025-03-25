using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace frameworks.Movement
{
    public class Vertical : IMovement
    {
        private int speed;
        private Point Boundary;
        private String direction;
        private int imageHeight;

        public Vertical(int speed, Point Boundary, string direction, int imageHeight)
        {
            this.speed = speed;
            this.Boundary = Boundary;
            this.direction = direction;
            this.imageHeight = imageHeight + 10;
        }

        public Point move(Point location)
        {
            if (location.Y <= 0)
            {
                direction = "down";
            }

            if (location.Y + imageHeight >= Boundary.Y)
            {
                direction = "up";
            }

            if (direction == "down")
            {
                location.Y += speed;
            }

            if (direction == "up")
            {
                location.Y -= speed;
            }
            return location;
        }
    }
}
