using System;
using UnityEngine;

namespace UnityGame
{
    public interface IPlayer
    {
        event Action<Vector2> ShouldMove;
    }
}
