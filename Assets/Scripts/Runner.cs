using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoadLine
{
    LEFT = -1,
    MIDDLE,
    RIGHT,
}

public class Runner : MonoBehaviour
{
    [SerializeField] RoadLine roadLine;
    [SerializeField] Rigidbody rigidbody;

    [SerializeField] float speed = 25.0f;
    [SerializeField] float positionX = 2.5f;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        roadLine = RoadLine.MIDDLE;
    }

    void OnKeyUpdate()
    {
        if (roadLine != RoadLine.LEFT && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            roadLine--;
        }
        if (roadLine != RoadLine.RIGHT && Input.GetKeyDown(KeyCode.RightArrow))
        {
            roadLine++;
        }
    }

    void Move()
    {
        rigidbody.position = Vector3.Lerp
        (
            rigidbody.position,
            new Vector3(positionX * (int)roadLine, transform.position.y),
            speed * Time.fixedDeltaTime
        );
    }

    void Update()
    {
        OnKeyUpdate();
    }

    void FixedUpdate()
    {
        Move();
    }
}
