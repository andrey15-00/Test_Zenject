using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class PlayerView : MonoBehaviour, ISpawnable
    {
        private IPlayer _model;
        private IInputSystem _inputSystem;

        public void Init(IPlayer model, IInputSystem inputSystem)
        {
            _model = model;
            _inputSystem = inputSystem;
        }

        private void Update()
        {
            Vector2 input = _inputSystem.MoveInput;
            transform.position += new Vector3(input.x, input.y, 0);
        }
    }
}
