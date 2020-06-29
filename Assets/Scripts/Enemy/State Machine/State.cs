﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField] private List<Transition> _transitions;

    protected Player Target { get; set; }

    public void Enter(Player target)
    {
        if(enabled == false)
        {
            Target = target;
            enabled = true;
            foreach(var transition in _transitions)
            {
                transition.enabled = true;
                transition.Init(Target);
            }
        }
    }
}
