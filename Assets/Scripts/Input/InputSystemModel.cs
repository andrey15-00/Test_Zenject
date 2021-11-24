using System;
using UnityEngine;

namespace UnityGame
{
    public class InputSystemModel : IInputSystem
    {
        public Vector2 MoveInput { get; private set; }

        public void PublishMove(Vector2 input)
        {
            MoveInput = input;
        }
    }
}
