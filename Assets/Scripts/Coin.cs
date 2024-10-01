using UnityEngine;

public class Coin : State
{
    [SerializeField] float speed;

    [SerializeField] GameObject rotationGameObject;

    new void OnEnable()
    {
        base.OnEnable();

        rotationGameObject = GameObject.Find("RotationGameObject");

        transform.localRotation = rotationGameObject.transform.localRotation;

        speed = rotationGameObject.GetComponent<RotationGameObject>().RotationSpeed;
    }
    void Update()
    {
        if (state == false) return;

        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
