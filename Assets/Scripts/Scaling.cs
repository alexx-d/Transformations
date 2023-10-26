using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.1f;

    void LateUpdate()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
