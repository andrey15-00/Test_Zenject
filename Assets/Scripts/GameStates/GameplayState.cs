using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Zenject;

namespace UnityGame
{
    public class GameplayState : IGameState
    {
        private IGameStateMachine _stateMachine;
        private IUISystem _uiSystem;


        public GameplayState(IGameStateMachine machine, IUISystem uiSystem)
        {
            _stateMachine = machine;
            _uiSystem = uiSystem;
        }

        public void Enter()
        {
            LogWrapper.Log("[GameplayState] Enter.");
            _uiSystem.ShowScreen<GameplayScreen>();
        }

        public void Exit()
        {
            LogWrapper.Log($"[GameplayState] Exit.");
            _uiSystem.HideScreen<GameplayScreen>();
        }

        public async void Tick(float deltaTime)
        {
            LogWrapper.Log($"[GameplayState] Tick.");
        }
    }
}
