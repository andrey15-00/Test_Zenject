using System;
using System.Collections.Generic;
using Zenject;

namespace UnityGame
{
    public interface IEvent
    {

    }

    public interface IEventDispatcher
    {
        public void Subscribe<T>(Action<T> subscriber) where T : IEvent;
    }

    public interface IEventPublisher
    {
        public event Action<IEvent> Publish;
    }

    public class EventDispatcher : IEventDispatcher
    {
        private Dictionary<Type, List<Action<IEvent>>> _subscribers = new Dictionary<Type, List<Action<IEvent>>>();

        [Inject]
        private EventDispatcher(IEventPublisher publisher)
        {
            publisher.Publish += Publish;
        }

        private EventDispatcher()
        {

        }

        private void Publish<T>(T message) where T : IEvent
        {
            Type type = message.GetType();

            List<Action<IEvent>> subscribers;
            if (_subscribers.TryGetValue(type, out subscribers))
            {
                foreach (var subscriber in subscribers)
                {
                    subscriber?.Invoke(message);
                }
            }
        }

        public void Subscribe<T>(Action<T> subscriber) where T : IEvent
        {
            Type type = typeof(T);

            List<Action<IEvent>> subscribers;

            Action<IEvent> action = (data) =>
            {
                subscriber?.Invoke((T)data);
            };

            if (_subscribers.TryGetValue(type, out subscribers))
            {
                subscribers.Add(action);
            }
            else
            {
                _subscribers[type] = new List<Action<IEvent>>()
                {
                    action
                };
            }
        }
    }
}