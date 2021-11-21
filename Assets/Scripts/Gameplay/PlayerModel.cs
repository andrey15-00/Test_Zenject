using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class PlayerModel : IPlayer
    {
        private IInputSystem _inputSystem;

        [Inject]
        private void Init(IInputSystem inputSystem)
        {
            _inputSystem = inputSystem;
            LogWrapper.Log("[PlayerModel] Init called!");
        }
    }
}
