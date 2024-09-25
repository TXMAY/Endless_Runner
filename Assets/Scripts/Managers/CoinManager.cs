using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> coins;

    [SerializeField] float offset = 2.5f;
    [SerializeField] int createCount = 16;
    [SerializeField] int positionX = 4;
    void Awake()
    {
        coins.Capacity = 20;
        Create();
    }

    public void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.SetParent(gameObject.transform);
            clone.transform.localPosition = new Vector3(0, prefab.transform.position.y, offset * i);
            clone.SetActive(false);
            coins.Add(clone);
        }
    }

    public void InitializePosition()
    {
        transform.localPosition = new Vector3(Random.Range(-1, 2) * positionX, 0, 0);
        //for (int i = 0; i < coins.Count; i++)
        //{
        //    coins[i].SetActive(true);
        //    coins[i].transform.SetParent(gameObject.transform);
        //}
    }
}
