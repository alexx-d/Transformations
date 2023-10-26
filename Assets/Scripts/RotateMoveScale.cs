using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoveScale : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3.0f;
    [SerializeField] private float _scaleSpeed = 0.1f;
    [SerializeField] private float _rotationSpeed = 50.0f;

    void LateUpdate()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
