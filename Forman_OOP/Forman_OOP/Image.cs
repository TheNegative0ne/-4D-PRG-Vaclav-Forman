using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forman_OOP
{
    internal class Image : IDrawable
    {
        public void Draw(string[,] scene)
        {
            int sceneHeight = scene.GetLength(0);
            int sceneWidth = scene.GetLength(1);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    int X = (int)(_position.X + i);
                    int Y = (int)(_position.Y + j);

                    if (X >= 0 && X < sceneWidth && Y >= 0 && Y < sceneHeight)
                    {
                        scene[Y, X] = _image[j, i];
                    }
                }
            }
        }

        private string[,] _image;
        private Vector _position;
        public int Width;
        public int Height;

        public Image(string[,] image, Vector position)
        {
            _image = image;
            _position = position;
            Width = image.GetLength(1);
            Height = image.GetLength(0);
        }


    }
}
