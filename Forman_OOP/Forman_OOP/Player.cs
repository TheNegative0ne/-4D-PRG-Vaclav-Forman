using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Forman_OOP
{
    internal class Player : GameObject
    {
        private Image _crouchingImage;
        private Image _standingImage;
        private Collider _crouchingCollider;
        private Collider _standingCollider;
        bool _crouching;
        bool _standing;
        private bool _grounded;

        public Player(Vector postion) : base(postion)
        {
            _standingImage = new Image(new string[,]{
                { "  ","  ","  ","  ","# ","# ","  ","  "},
                { "  ","  ","  ","  ","# ","# ","# ","# "},
                { "  ","  ","  ","  ","# ","# ","# ","# "},
                { "  ","  ","  ","  ","# ","# ","  ","  "},
                { "  ","  ","  ","# ","# ","# ","  ","  "},
                { "  ","  ","# ","# ","# ","# ","# ","  "},
                { "  ","# ","# ","# ","# ","# ","  ","  "},
                { "# ","# ","# ","# ","# ","# ","  ","  "},
                { "  ","  ","# ","  ","  ","# ","  ","  "},
                { "  ","  ","# ","# ","  ","# ","# ","  "}}, Position);

            _crouchingImage = new Image(new string[,]{
                { "  ","  ","  ","  ","# ","# ","  ","  "},
                { "  ","  ","  ","  ","# ","# ","# ","# "},
                { "  ","  ","  ","  ","# ","# ","# ","# "},
                { "  ","  ","  ","# ","# ","# ","  ","  "},
                { "  ","  ","# ","# ","# ","# ","# ","  "},
                { "# ","# ","# ","# ","# ","# ","  ","  "},
                { "  ","  ","# ","# ","  ","# ","# ","  "} }, Position);

            _standingCollider = new RectCollider(Position, _standingImage.Width, _standingImage.Height);
            _crouchingCollider = new RectCollider(Position, _crouchingImage.Width, _crouchingImage.Height);

            Image = _standingImage;
            Collider = _standingCollider;
        }

        public override void Move()
        {
            Speed.Y += 0.3f;
            base.Move();
            if (Collider.BottomEdge > MaxBounds.Y)
            {
                _grounded = true;
                Collider.BottomEdge = MaxBounds.Y;
                Speed.Y = 0;

            }
            else
            {
                _grounded = false;
            }
        }

        public void StandUp()
        {
            Image = _standingImage;
            Collider = _standingCollider;
            _crouching = false;
        }
        public void Jump()
        {
            if (_grounded == true)
            {
                StandUp();
                Speed.Y = -3;
            }
        }

        public void Crouch()
        {
            if (_crouching == false)
            {
                Image = _crouchingImage;
                Collider = _crouchingCollider;
                _crouching = true;
                Position.Y += _standingCollider.BottomEdge - _crouchingCollider.BottomEdge;
            }
        }

    }
}
