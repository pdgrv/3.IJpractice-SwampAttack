﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyStateMachine : MonoBehaviour
{
    [SerializeField] private State _firtsState;

    private Player _target;
    private State _currentState;

    public State Current => _currentState;

    private void Start()
    {
        _target = GetComponent<Enemy>().Target;
    }

    private void Reset(State startState)
    {
        _currentState = startState;

        if (_currentState != null)
            _currentState.Enter(_target);
    }
}
