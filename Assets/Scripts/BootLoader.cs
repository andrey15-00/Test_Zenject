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
        [SerializeField] private List<GameObject> _spawnables;
        [Inject] private IGameStateMachine _stateMachine;
        [Inject] private IUISystem _uiSystem;
        [Inject] private ISpawnSystem _spawnSystem;
        [Inject] private IInputSystem _inputSystem;
        [Inject] private IPlayer _player;

        private void Awake()
        {
            LoadingState loadingState = new LoadingState(_stateMachine, _uiSystem);
            MainMenuState menuState = new MainMenuState(_stateMachine, _uiSystem);
            GameplayState gameplayState = new GameplayState(_stateMachine, _uiSystem, _inputSystem, _player);
            _stateMachine.Init(new List<IGameState>
            {
                loadingState,
                menuState,
                gameplayState,
            });

            _uiSystem.Init(_screens);

            Dictionary<Type, GameObject> spawnables = new Dictionary<Type, GameObject>();
            foreach(var item in _spawnables)
            {
                ISpawnable spawnable = item.GetComponent<ISpawnable>();
                if(spawnable != null)
                {
                    spawnables[spawnable.GetType()] = item;
                }
                else
                {
                    LogWrapper.LogError($"Spawnable {item.name} doesnt't have component with {typeof(ISpawnable)} interface!");
                }
            }
            _spawnSystem.Init(spawnables);

            LogWrapper.Log("[MainInstaller] Game initialized.");

            OnInitFinished();
        }

        private void OnInitFinished()
        {
            //TODO: Test.
            PlayerView playerView = _spawnSystem.Spawn<PlayerView>(null, Vector3.zero, Quaternion.identity);
            playerView.Init(_player, _inputSystem);


            _stateMachine.ChangeState<LoadingState>();
        }
    }
}