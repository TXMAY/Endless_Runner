using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [SerializeField] float offset = 2.5f;
    [SerializeField] int createCount = 16;
    void Awake()
    {
        Create();
    }

    public void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.SetParent(gameObject.transform);
            clone.transform.localPosition = new Vector3(0, prefab.transform.position.y, offset * i);
        }
    }

    public void InitializePosition()
    {

    }
}
