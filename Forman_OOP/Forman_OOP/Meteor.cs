using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forman_OOP
{
    internal class Meteor : GameObject
    {
        public Meteor(Vector postion) : base(postion)
        {
            Image = new Image(new string[,] {
                {"  ", "# ", "# ", "# ", "# ", "  ", "# "},
                {"# ", "  ", "  ", "# ", "  ", "# ", "  "},
                {"# ", "# ", "# ", "  ", "  ", "# ", "# "},
                {"# ", "  ", "  ", "# ", "  ", "# ", "  "},
                {"# ", "  ", "  ", "  ", "# ", "# ", "  "},
                {"  ", "# ", "# ", "# ", "# ", "  ", "# "}}, Position);

            Collider = new CircleCollider(Position, Image.Width / 2);
            Speed = new Vector(-1.4f, 0);
        }
        public override void Move()
        {
            base.Move();
            if (Collider.RightEdge < MinBounds.X)
            {
                OnDestroy();
            }
        }
    }
}
