using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
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
            GameObject clone = ResourcesManager.Instance.Instantiate("Coin", gameObject.transform);

            clone.transform.localPosition = new Vector3(0, 0.825f, offset * i);

            clone.SetActive(false);

            coins.Add(clone);
        }
    }

    public void InitializePosition()
    {
        transform.localPosition = new Vector3(Random.Range(-1, 2) * positionX, 0, 0);

        foreach (GameObject clone in coins)
        {
            clone.SetActive(true);
        }
    }
}
