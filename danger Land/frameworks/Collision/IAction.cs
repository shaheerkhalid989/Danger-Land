using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frameworks.Core;

namespace frameworks.Collision
{
    public interface IAction
    {
        void doAction(GameObject g1, GameObject g2, IGame g);
    }
}
