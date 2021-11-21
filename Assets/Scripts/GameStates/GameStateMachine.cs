using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class GameStateMachine : IGameStateMachine, ITickable
    {
        private List<IGameState> _states;
        private IGameState _currentState;
        private float _tickFrequency = 1f;
        private float _timeSinceLastTick = 0.5f;


        public void Init(List<IGameState> states)
        {
            _states = states;
        }

        public void ChangeState<T>() where T : IGameState
        {
            if(_currentState != null)
            {
                _currentState.Exit();
            }

            T state = GetState<T>();
            state.Enter();
            _currentState = state;
        }

        public void UpdateCurrentState(float deltaTime)
        {
            if(_currentState != null)
            {
                _currentState.Tick(deltaTime);
            }
        }

        private T GetState<T>() where T : IGameState
        {
            Type type = typeof(T);
            foreach(var state in _states)
            {
                if(state.GetType() == type)
                {
                    return (T)state;
                }
            }

            throw new Exception($"State with type {type} not found!");
        }

        public void Tick()
        {
            _timeSinceLastTick += Time.deltaTime;
            if (_timeSinceLastTick >= _tickFrequency)
            {
                _timeSinceLastTick -= _tickFrequency;
                UpdateCurrentState(Time.deltaTime);
            }
        }
    }
}
