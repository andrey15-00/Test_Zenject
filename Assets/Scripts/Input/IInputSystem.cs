using System;
using UnityEngine;

namespace UnityGame
{
    public interface IInputSystem
    {
        Vector2 MoveInput { get; }

        void PublishMove(Vector2 input);
    }
}
