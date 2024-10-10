using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePositionManager : State
{
    private Coroutine coroutine;

    [SerializeField] int index = -1;

    [SerializeField] Transform[] parentRoads;
    [SerializeField] Transform[] randomPosX;

    [SerializeField] ObstacleManager obstacleManager;

    [SerializeField] float[] randomPosZ = new float[16];

    void Awake()
    {
        for (int i = 0; i < randomPosZ.Length; i++)
        {
            randomPosZ[i] = -10.0f + 2.5f * i;
        }
    }


    public void InitializePosition()
    {
        if (coroutine == null)
        {
            coroutine = StartCoroutine(SetPosition());
        }

        index = (index + 1) % parentRoads.Length;

        transform.SetParent(parentRoads[index]);

        transform.localPosition += new Vector3(0, 0, 40);
    }

    public IEnumerator SetPosition()
    {
        while (state)
        {
            yield return CoroutineCache.WaitForSecond(2.5f);

            transform.localPosition = new Vector3(0, 0, randomPosZ[Random.Range(0, randomPosZ.Length)]);

            obstacleManager.GetObstacle().SetActive(true);

            obstacleManager.GetObstacle().transform.position = randomPosX[Random.Range(0, randomPosX.Length)].position;

            obstacleManager.GetObstacle().transform.SetParent(transform.root.GetChild(index));
        }
    }
}
