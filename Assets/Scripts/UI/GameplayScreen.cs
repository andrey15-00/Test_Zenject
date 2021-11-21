using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityGame
{
    public class GameplayScreen : UIScreen
    {
        [SerializeField] private Button _goHome;

        private void Start()
        {
            _goHome.onClick.AddListener(OnGoHomeClicked);
        }

        private void OnGoHomeClicked()
        {
            _gameStateMachine.ChangeState<MainMenuState>();
        }
    }
}
