using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Forman_OOP
{
    internal class Cactus : GameObject
    {
        public Cactus(Vector postion) : base(postion)
        {
            Image = new Image(new string[,] {
                { "# ", "# ", "  ", "# ", "# "},
                { "# ", "# ", "  ", "# ", "# "},
                { "# ", "# ", "# ", "# ", "# "},
                { "# ", "# ", "# ", "# ", "  "},
                { "  ", "# ", "# ", "  ", "  "},
                { "  ", "# ", "# ", "  ", "  "}}, Position);

            Collider = new RectCollider(Position, Image.Width, Image.Height);
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
