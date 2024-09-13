using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    public Action action;

    void Update()
    {
        if (!Input.anyKey) return;
        
        if (action != null) action.Invoke();

    }
}
