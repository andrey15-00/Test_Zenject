using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Zenject;

namespace UnityGame
{
    public class LoadingState : IGameState
    {
        private IGameStateMachine _stateMachine;
        private IUISystem _uiSystem;
        private bool _loading;


        public LoadingState(IGameStateMachine machine, IUISystem uiSystem)
        {
            _stateMachine = machine;
            _uiSystem = uiSystem;
        }

        public void Enter()
        {
            LogWrapper.Log("[LoadingState] Enter.");
            _loading = false;
        }

        public void Exit()
        {
            LogWrapper.Log($"[LoadingState] Exit.");
        }

        public async void Tick(float deltaTime)
        {
            LogWrapper.Log($"[LoadingState] Tick.");
            if (!_loading)
            {
                _loading = true;
                await CheckState();
                await DownloadData();
                _stateMachine.ChangeState<MainMenuState>();
            }
        }

        private async Task CheckState()
        {
            LogWrapper.Log($"[LoadingState] Check state start.");
            _uiSystem.ShowScreen<SplashScreen>();
            await Task.Delay(2000);
            _uiSystem.HideScreen<SplashScreen>();
            LogWrapper.Log($"[LoadingState] Check state end.");
        }


        private async Task DownloadData()
        {
            LogWrapper.Log($"[LoadingState] Download data start.");
            _uiSystem.ShowScreen<LoadingScreen>();
            await Task.Delay(2000);
            _uiSystem.HideScreen<LoadingScreen>();
            LogWrapper.Log($"[LoadingState] Download data end.");
        }
    }
}
