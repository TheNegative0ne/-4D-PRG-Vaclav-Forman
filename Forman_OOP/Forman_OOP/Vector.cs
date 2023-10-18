using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forman_OOP
{
    class Vector
    {
        public float X;
        public float Y;

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public void Add(Vector other)
        {
            this.X += other.X;
            this.Y += other.Y;
        }

        public float SquareSize
        {
            get
            {
                return X * X + Y * Y;
            }
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
    }
}
