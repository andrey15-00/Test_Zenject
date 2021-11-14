using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private GameLogic _gameLogic;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameLogic>().FromInstance(_gameLogic).AsSingle();

            Container.BindInterfacesAndSelfTo<EventDispatcher>().FromNew().AsSingle();
        }
    }
}