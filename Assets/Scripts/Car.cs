using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var position = transform.position;
        var step = Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.W))
        {
            position.x += step;
        }

        if (Input.GetKey(KeyCode.A))
        {
            position.z += step;
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.x -= step;
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.z -= step;
        }

        transform.position = position;
    }
}