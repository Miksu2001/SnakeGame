using Godot;
using System;

namespace SnakeGame
{
    public partial class Snake : Node2D
    {
        [Export] private Sprite2D _head = null;





        public enum Direction
        {
            NONE,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }





        public override void _Ready()
        {
        }

        public override void _Process(double delta)
        {
            Direction direction;
            bool isTryingToTurn;

            direction = ReadInput(out isTryingToTurn);

            if (isTryingToTurn)
            {
                RotateHead(direction);
            }
        }




        /// <summary>
        /// Read the input from the player and return the direction.
        /// </summary>
        /// <param name="isInputDetected">true = input is detected, false = input is not detected</param>
        /// <returns></returns>
        private Direction ReadInput(out bool isInputDetected)
        {
            Direction direction;

            isInputDetected = true;

            if (Input.IsActionJustPressed(Config.ACTION_TURN_UP))
            {
                direction = Direction.UP;
            }
            else if (Input.IsActionJustPressed(Config.ACTION_TURN_DOWN))
            {
                direction = Direction.DOWN;
            }
            else if (Input.IsActionJustPressed(Config.ACTION_TURN_LEFT))
            {
                direction = Direction.LEFT;
            }
            else if (Input.IsActionJustPressed(Config.ACTION_TURN_RIGHT))
            {
                direction = Direction.RIGHT;
            }
            else
            {
                direction = Direction.NONE;
                isInputDetected = false;
            }

            return direction;
        }

        /// <summary>
        /// Rotate the head of the snake to the specified direction.
        /// </summary>
        /// <param name="direction">The direction the player is trying to head to.</param>
        private void RotateHead(Direction direction)
        {
            int rotation;

            switch (direction)
            {
                case Direction.UP: rotation = 0; break;
                case Direction.RIGHT: rotation = 90; break;
                case Direction.DOWN: rotation = 180; break;
                case Direction.LEFT: rotation = 270; break;
                default: rotation = 0; break;
            }

            _head.RotationDegrees = rotation;
        }
    }
}
