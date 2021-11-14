using Zenject;
using UnityEngine;

namespace UnityGame
{
    public class UIMainScreen : UIScreen
    {
        private void Start()
        {
            _eventHandler.Subscribe<TestEvent>(OnEvent);
        }

        private void OnEvent(TestEvent e)
        {
            LogWrapper.Log("[UIMainScreen] Received event. Event: " + e.GetType());
        }
    }
}