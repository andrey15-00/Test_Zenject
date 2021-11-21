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
        private IInputSystem _inputSystem;
        private IPlayer _player;


        public GameplayState(IGameStateMachine machine, IUISystem uiSystem, IInputSystem inputSystem, IPlayer player)
        {
            _stateMachine = machine;
            _uiSystem = uiSystem;
            _inputSystem = inputSystem;
            _player = player;
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

        public void Tick(float deltaTime)
        {
            LogWrapper.Log($"[GameplayState] Tick.");
        }
    }
}
