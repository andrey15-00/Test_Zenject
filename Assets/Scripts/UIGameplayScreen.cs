using Zenject;
using UnityEngine;

namespace UnityGame
{
    public class UIGameplayScreen : UIScreen
    {
        private void Start()
        {
            _eventHandler.Subscribe<TestEvent>(OnEvent);
        }

        private void OnEvent(TestEvent e)
        {
            LogWrapper.Log("[UIGameplayScreen] Received event. Event: " + e.GetType());
        }
    }
}