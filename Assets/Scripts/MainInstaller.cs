using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<UISystem>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<GameStateMachine>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<SpawnSystem>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<InputSystem>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerModel>().FromNew().AsSingle();

            LogWrapper.Log("[MainInstaller] InstallBindings finished.");
        }
    }
}