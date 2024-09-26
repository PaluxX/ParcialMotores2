using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Controller _controller;
    [SerializeField] float _speed;

    //[SerializeField] Weapon _weapon;

    void Update()
    {
        transform.position += _controller.GetMovementInput() * _speed * Time.deltaTime;

        if(_controller.lookingLeft == true)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
    }
}
