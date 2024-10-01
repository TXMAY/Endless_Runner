using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField] protected bool state;


    protected void OnEnable()
    {
        Debug.Log("Event Register");
    }

    protected void OnExecute()
    {
        state = true;
    }

    protected void OnStop()
    {
        state = false;
    }

    protected void OnDisable()
    {
        Debug.Log("Event Release");
    }
}
