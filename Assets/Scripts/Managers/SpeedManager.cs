using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] float speedMax = 50.0f;
    [SerializeField] float increaseValue = 5.0f;

    void Awake()
    {
        StartCoroutine(Accelerate());
    }

    public float Speed
    {
        get { return speed; }
    }

    IEnumerator Accelerate()
    {
        while (speed < speedMax)
        {
            yield return CoroutineCache.WaitForSecond(10);
            speed += increaseValue;
        }
    }
}
