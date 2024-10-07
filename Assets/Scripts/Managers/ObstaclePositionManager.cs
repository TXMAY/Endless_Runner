using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePositionManager : MonoBehaviour
{
    [SerializeField] int index = -1;
    [SerializeField] Transform[] parentRoads;
    [SerializeField] float[] randomPosZ = new float[16];

    void Awake()
    {
        for (int i = 0; i < randomPosZ.Length; i++)
        {
            randomPosZ[i] = -10.0f + 2.5f * i;
        }
    }

    void Start()
    {
        
    }

    public void InitializePosition()
    {
        index = (index + 1) % parentRoads.Length;

        transform.SetParent(parentRoads[index]);

        transform.localPosition += new Vector3(0, 0, 40);
    }
}
