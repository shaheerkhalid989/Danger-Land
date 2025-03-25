using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace frameworks.Movement
{
    public class EightDirectional : IMovement
    {
        private int speed;
        private String direction;

        public EightDirectional(int speed, string direction)
        {
            this.speed = speed;
            this.direction = direction;
        }

        public Point move(Point location)
        {
            if (direction == "left")
                location.X -= speed;

            if (direction == "right")
                location.X += speed;

            if (direction == "up")
                location.Y -= speed;

            if (direction == "down")
                location.Y += speed;

            if (direction == "ruDia")
            {
                location.X += speed;
                location.Y -= speed / 2;
            }

            if (direction == "rdDia")
            {
                location.X += speed;
                location.Y += speed / 2;
            }

            if (direction == "luDia")
            {
                location.X -= speed;
                location.Y -= speed / 2;
            }

            if (direction == "ldDia")
            {
                location.X -= speed;
                location.Y += speed / 2;
            }
            return location;
        }
    }
}
