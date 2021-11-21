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

            LogWrapper.Log("[MainInstaller] InstallBindings finished.");
        }
    }
}