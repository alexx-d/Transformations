using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundY : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 50.0f;

    void LateUpdate()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }
}