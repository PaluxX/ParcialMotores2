using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Controller _controller;
    [SerializeField] float _speed;

    void Update()
    {
        transform.position += _controller.GetMovementInput() * _speed * Time.deltaTime;
    }
}
