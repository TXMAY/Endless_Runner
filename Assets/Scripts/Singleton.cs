using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get { return instance; }
        set { }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = (T)FindObjectOfType(typeof(T));
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
