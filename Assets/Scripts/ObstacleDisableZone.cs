using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDisableZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Obstacle obstacle = other.GetComponent<Obstacle>();

        if(obstacle != null)
        {
            other.gameObject.SetActive(false);
        }
    }
}
