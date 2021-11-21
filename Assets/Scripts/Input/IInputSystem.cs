using System;
using UnityEngine;

namespace UnityGame
{
    public interface IInputSystem
    {
        event Action<Vector2> Move;

        void PublishMove(Vector2 input);
    }
}
