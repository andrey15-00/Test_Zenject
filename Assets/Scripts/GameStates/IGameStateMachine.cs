using System;
using System.Collections.Generic;

namespace UnityGame
{
    public interface IGameStateMachine
    {
        void Init(List<IGameState> states);
        void ChangeState<T>() where T: IGameState;
        void UpdateCurrentState(float deltaTime);
    }
}
