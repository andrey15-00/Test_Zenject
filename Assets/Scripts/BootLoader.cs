using Zenject;
using UnityEngine;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UnityGame
{
    public class BootLoader : MonoBehaviour
    {
        [SerializeField] private List<UIScreen> _screens;
        [Inject] private IGameStateMachine _stateMachine;
        [Inject] private IUISystem _uiSystem;

        private void Awake()
        {
            LoadingState loadingState = new LoadingState(_stateMachine, _uiSystem);
            MainMenuState menuState = new MainMenuState(_stateMachine, _uiSystem);
            GameplayState gameplayState = new GameplayState(_stateMachine, _uiSystem);
            _stateMachine.Init(new List<IGameState>
            {
                loadingState,
                menuState,
                gameplayState,
            });

            _uiSystem.Init(_screens);

            _stateMachine.ChangeState<LoadingState>();
            
            LogWrapper.Log("[MainInstaller] Game initialized.");
        }
    }
}