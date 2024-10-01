using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum EventType
{
    START,
    CONTINUE,
    PAUSE,
    STOP
}

public class EventManager
{
    private static readonly IDictionary<EventType, UnityEvent> dictionary =
        new Dictionary<EventType, UnityEvent>();

    public static void Subscribe(EventType eventType, UnityAction unityAction)
    {
        UnityEvent unityEvent;

        if (dictionary.TryGetValue(eventType, out unityEvent))
        {
            unityEvent.AddListener(unityAction);
        }
        else
        {
            unityEvent = new UnityEvent();
            unityEvent.AddListener(unityAction);
            dictionary.Add(eventType, unityEvent);
        }
}
}

