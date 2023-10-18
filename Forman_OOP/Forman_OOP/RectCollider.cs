using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forman_OOP
{
    internal class RectCollider : Collider
    {
        public float Width;
        public float Height;
        public RectCollider(Vector position, float width, float height) : base(position)
        {
            this.Width = width;
            this.Height = height;
        }

        public override float LeftEdge { get => Position.X; set => Position.X = value; }
        public override float RightEdge { get => Position.X + Width; set => Position.X = value - Width; }
        public override float TopEdge { get => Position.Y; set => Position.Y = value; }
        public override float BottomEdge { get => Position.Y + Height; set => Position.Y = value - Height; }



        public override bool CollideWith(Collider collider)
        {
            return collider.CollideWith(this);
        }

        public override bool CollideWith(RectCollider collider)
        {
            return CollisionDetection.CheckCollision(this, collider);
        }

        public override bool CollideWith(CircleCollider collider)
        {
            return CollisionDetection.CheckCollision(this, collider);
        }
    }
}
