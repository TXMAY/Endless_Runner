using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Road : MonoBehaviour, IInteractable
{
    [SerializeField] UnityEvent callback;

    public void Interact()
    {
        if(callback != null) callback.Invoke();
    }
}
