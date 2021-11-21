using Zenject;
using UnityEngine;

namespace UnityGame
{
    public class UIScreen : MonoBehaviour
    {
        [SerializeField] protected GameObject _screenRoot;
        [Inject] protected IGameStateMachine _gameStateMachine;

        [Inject]
        private void Init(IGameStateMachine stateMachine)
        {
            _gameStateMachine = stateMachine;
        }

        public void Hide()
        {
            _screenRoot.SetActive(false);
        }

        public void Show()
        {
            _screenRoot.SetActive(true);
        }
    }
}