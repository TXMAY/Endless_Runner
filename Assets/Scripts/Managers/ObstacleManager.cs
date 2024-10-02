using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] List<GameObject> obstacles;

    [SerializeField] int createCount = 5;

    void Awake()
    {
        obstacles.Capacity = 20;
        Create();
    }

    public void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject clone = ResourcesManager.Instance.Instantiate("Cone", gameObject.transform);

            clone.SetActive(false);

            obstacles.Add(clone);
        }
    }

    public bool ExamineActive()
    {
        for (int i = 0; i < createCount; i++)
        {
            if (obstacles[i].activeSelf == false) return false;
        }
        return true;
    }

    public IEnumerator ActiveObstacle()
    {
        while (true)
        {
            yield return CoroutineCache.WaitForSecond(2.5f);
        }
    }
}
