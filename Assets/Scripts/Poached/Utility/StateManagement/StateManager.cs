using System;
using System.Collections.Generic;
using Unity.Logging;
using UnityEngine;

namespace Poached.Utility.StateManagement
{
public abstract class StateMachine<TKeyType> : MonoBehaviour where TKeyType : Enum
{
    private Dictionary<TKeyType, StateItem> _states = new();
    private TKeyType _currentState = default(TKeyType);
    private TKeyType _nextState = default(TKeyType);
    private bool _isTransitionScheduled = false;

    public void RegisterState(TKeyType key, StateItem stateItem, bool setInitialState = false)
    {
        _states.Add(key, stateItem);
        if (setInitialState)
        {
            SetState(key, true);
        }
    }

    public void SetState(TKeyType key, bool setInitialState = false)
    {
        if (!_states.ContainsKey(key))
        {
            Log.Error("Could not locate state with key {key}", key.ToString());
        }

        if (setInitialState)
        {
            _currentState = key;
        }

        _nextState = key;
        _isTransitionScheduled = true;
    }

    protected virtual void Update()
    {
        if (!_states.ContainsKey(_currentState)) return;

        _states[_currentState].OnStateTick();

        if (!_isTransitionScheduled) return;
        _states[_currentState].OnStateExit();
        _currentState = _nextState;
        _states[_currentState].OnStateEnter();
        _isTransitionScheduled = false;
        _nextState = default;
    }

    protected void FixedUpdate()
    {
        _states[_currentState].OnStateFixedTick();
    }
}
}
