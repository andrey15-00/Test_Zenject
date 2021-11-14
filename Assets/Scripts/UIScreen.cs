using Zenject;
using UnityEngine;

namespace UnityGame
{
    public class UIScreen : MonoBehaviour
    {
        [Inject] protected IEventDispatcher _eventHandler;
    }
}