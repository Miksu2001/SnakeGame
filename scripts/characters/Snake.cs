using Godot;
using System;

namespace SnakeGame
{
    public partial class Snake : Node2D
    {
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
    }
}
