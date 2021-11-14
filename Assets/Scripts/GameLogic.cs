using Zenject;
using UnityEngine;
using System;
using System.Threading.Tasks;

namespace UnityGame
{
    public class GameLogic : MonoBehaviour, IEventPublisher
    {
        public event Action<IEvent> Publish;

        private async void Start()
        {
            await Task.Delay(1000);
        }

        float t = 0;
        private void Update()
        {
            t += Time.deltaTime;
            if(t >= 1f)
            {
                t -= 1f;
                Publish?.Invoke(new TestEvent());
            }
        }
    }
}