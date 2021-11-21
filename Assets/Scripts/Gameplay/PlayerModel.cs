using System;
using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class PlayerModel : IPlayer
    {
        public event Action<Vector2> ShouldMove;

        [Inject]
        private void Init(IInputSystem inputSystem)
        {
            inputSystem.Move += OnShouldMove;
        }

        private void OnShouldMove(Vector2 input)
        {
            ShouldMove?.Invoke(input);
        }
    }
}
