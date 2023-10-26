using UnityEngine;

public class MovementForward : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5.0f;

    void LateUpdate()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}