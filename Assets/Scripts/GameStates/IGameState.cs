using System;
using System.Runtime.Serialization;
using Zenject;

namespace UnityGame
{
    public interface IGameState
    {
        void Enter();
        void Exit();
        void Tick(float deltaTime);
    }
}
