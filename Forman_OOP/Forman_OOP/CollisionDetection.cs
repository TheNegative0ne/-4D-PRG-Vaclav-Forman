using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forman_OOP
{
    internal class CollisionDetection
    {
        public static bool CheckCollision(RectCollider rect1, RectCollider rect2)
        {
            return (rect1.RightEdge > rect2.LeftEdge)
                && (rect2.RightEdge > rect1.LeftEdge)
                && (rect1.BottomEdge > rect2.TopEdge)
                && (rect2.BottomEdge > rect1.TopEdge);
        }

        public static bool CheckCollision(CircleCollider circle1, CircleCollider circle2)
        {
            Vector center1 = new Vector(circle1.Position.X + circle1.Radius,
            circle1.Position.Y + circle1.Radius);
            Vector center2 = new Vector(circle2.Position.X + circle2.Radius,
            circle2.Position.Y + circle2.Radius);
            float dist = (center1 - center2).SquareSize;
            float radius = circle1.Radius + circle2.Radius;
            return dist < radius * radius;
        }

        public static bool CheckCollision(RectCollider rect, CircleCollider circle)
        {
            float X = circle.Position.X + circle.Radius;
            float Y = circle.Position.Y + circle.Radius;
            float closeX = X;
            float closeY = Y;
            if (closeX < rect.LeftEdge) closeX = rect.LeftEdge;
            else if (closeX > rect.RightEdge) closeX = rect.RightEdge;
            if (closeY < rect.TopEdge) closeY = rect.TopEdge;
            else if (closeY > rect.BottomEdge) closeY = rect.BottomEdge;
            X -= closeX;
            Y -= closeY;
            return X * X + Y * Y < circle.Radius * circle.Radius;
        }
    }
}

