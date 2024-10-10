using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour, IHitable
{
    public void Activate()
    {
        EventManager.Publisher(EventType.STOP);
    }
}
