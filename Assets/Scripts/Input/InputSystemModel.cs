using System;
using UnityEngine;

namespace UnityGame
{
    public class InputSystemModel : IInputSystem
    {
        public event Action<Vector2> Move;

        public void PublishMove(Vector2 input)
        {
            Move?.Invoke(input);
        }
    }
}
