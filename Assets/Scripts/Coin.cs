using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] GameObject rotationGameObject;

    void OnEnable()
    {
        rotationGameObject = GameObject.Find("RotationGameObject");

        transform.localRotation = rotationGameObject.transform.localRotation;

        speed = rotationGameObject.GetComponent<RotationGameObject>().RotationSpeed;
    }
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
