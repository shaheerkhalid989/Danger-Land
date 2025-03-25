using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using frameworks.Movement;
using frameworks.Collision;

namespace frameworks.Core
{
    public class GameObject
    {
        private PictureBox pb;
        private IMovement movement;
        private ObjectType otype;

        public PictureBox PB { get => pb; set => pb = value; }
        public IMovement Movement { get => movement; set => movement = value; }
        public ObjectType Otype { get => otype; set => otype = value; }

        public GameObject(Image img, ObjectType otype, int left, int top, IMovement movement)
        {
            pb = new PictureBox();
            pb.Image = img;
            pb.Width = img.Width;
            pb.Height = img.Height;
            pb.BackColor = Color.Transparent;
            pb.Left = left;
            pb.Top = top;
            this.otype = otype;
            this.movement = movement;
        }

        public void gameObjectMove()
        {
            pb.Location = movement.move(pb.Location);
        }
    }
}
