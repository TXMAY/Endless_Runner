using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] List<GameObject> roads;
    void Start()
    {
        roads.Capacity = 10;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        for (int i = 0; i < roads.Count; i++)
        {
            if (roads[i].transform.position.z <= -40)
            {
                roads[i].transform.position += new Vector3(0, 0, 160);
            }
            roads[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
