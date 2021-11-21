using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityGame
{
    public class MainMenuScreen : UIScreen
    {
        [SerializeField] private Button _play;

        private void Start()
        {
            _play.onClick.AddListener(OnPlayClicked);
        }

        private void OnPlayClicked()
        {
            _gameStateMachine.ChangeState<GameplayState>();
        }
    }
}
