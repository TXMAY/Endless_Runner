using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoadLine
{
    LEFT = -1,
    MIDDLE,
    RIGHT,
}

public class Runner : State
{
    [SerializeField] Animator animator;
    [SerializeField] RoadLine roadLine;
    [SerializeField] Rigidbody rigidbody;

    [SerializeField] float speed = 25.0f;
    [SerializeField] float positionX = 4f;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    new void OnEnable()
    {
        base.OnEnable();

        InputManager.Instance.action += OnKeyUpdate;
    }
    void Start()
    {
        roadLine = RoadLine.MIDDLE;
    }

    void OnKeyUpdate()
    {
        if (roadLine != RoadLine.LEFT && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (roadLine != RoadLine.LEFT)
            {
                animator.Play("Left Avoid");
                roadLine--;
            }
        }
        if (roadLine != RoadLine.RIGHT && Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (roadLine != RoadLine.RIGHT)
            {
                animator.Play("Right Avoid");
                roadLine++;
            }
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

    void FixedUpdate()
    {
        if (state == false) return;
        Move();
    }

    new void OnDisable()
    {
        base.OnDisable();

        InputManager.Instance.action -= OnKeyUpdate;
    }
}
