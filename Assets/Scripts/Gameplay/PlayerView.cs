using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class PlayerView : MonoBehaviour, ISpawnable
    {
        public void Init(IPlayer model)
        {
            model.ShouldMove += Move;
        }

        private void Move(Vector2 input)
        {
            //LogWrapper.Log("[PlayerView] Move. Input: " + input);
        }
    }
}
