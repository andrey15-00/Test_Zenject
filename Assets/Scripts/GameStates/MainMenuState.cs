using System;
using System.Runtime.Serialization;
using Zenject;

namespace UnityGame
{
    public class MainMenuState : IGameState
    {
        private IGameStateMachine _stateMachine;
        private IUISystem _uiSystem;
        private bool _loading;


        public MainMenuState(IGameStateMachine machine, IUISystem uiSystem)
        {
            _stateMachine = machine;
            _uiSystem = uiSystem;
        }

        public void Enter()
        {
            LogWrapper.Log("[MenuState] Enter.");
            _uiSystem.ShowScreen<MainMenuScreen>();
        }

        public void Exit()
        {
            LogWrapper.Log("[MenuState] Exit.");
            _uiSystem.HideScreen<MainMenuScreen>();
        }

        public void Tick(float deltaTime)
        {
            LogWrapper.Log($"[MenuState] Tick.");
        }
    }
}
