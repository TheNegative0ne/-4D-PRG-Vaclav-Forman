using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forman_OOP
{
    abstract class Collider
    {
        public Collider(Vector position)
        {
            Position = position;
        }

        public Vector Position { get; }

        public abstract bool CollideWith(Collider collider);

        public abstract float LeftEdge { get; set; }
        public abstract float RightEdge { get; set; }
        public abstract float TopEdge { get; set; }
        public abstract float BottomEdge { get; set; }

        public abstract bool CollideWith(RectCollider collider);

        public abstract bool CollideWith(CircleCollider collider);
    }
}
