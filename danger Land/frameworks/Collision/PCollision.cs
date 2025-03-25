using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworks.Collision
{
    public class PCollision : DieAction
    {
        private ObjectType ot1;
        private ObjectType ot2;
        private IAction action;

        public PCollision(ObjectType ot1, ObjectType ot2, IAction action)
        {
            this.Ot1 = ot1;
            this.Ot2 = ot2;
            this.action = action;
        }

        public ObjectType Ot1 { get => ot1; set => ot1 = value; }
        public ObjectType Ot2 { get => ot2; set => ot2 = value; }
    }
}
