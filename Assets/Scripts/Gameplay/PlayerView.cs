using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class PlayerView : MonoBehaviour, ISpawnable
    {
        private IPlayer _model;

        public void Init(IPlayer model)
        {
            _model = model;
            LogWrapper.Log("[PlayerView] Init called!");
        }
    }
}
