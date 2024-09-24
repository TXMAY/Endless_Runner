using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGameObject : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 60.0f;

    public float RotationSpeed
    {
        get { return rotationSpeed; }
    }
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
