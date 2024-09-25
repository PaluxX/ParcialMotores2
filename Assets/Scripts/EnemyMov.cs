using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    [SerializeField] public Transform _player;
    [SerializeField] public float _detection = 5f;
    [SerializeField] public float _speed;

    private Rigidbody _rb;
    private Vector3 _movement;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, _player.position); 

        if (distanceToPlayer < _detection)
        { 
            Vector2 direction = (_player.position - transform.position).normalized;

            _movement = new Vector2(direction.x, 0);
        }
        _rb.MovePosition(_rb.position + _movement * _speed * Time.deltaTime);

    }
}
