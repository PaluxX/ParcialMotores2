using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NormalBullet : Bullet
{
    [SerializeField] private float _damage;
    public StatsEnemy Enemy;

    void Update()
    {
        transform.position += transform.right * _speed * Time.deltaTime;   
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Enemy.TakeDmg(10);
            print("X");
            Destroy(gameObject);

        }
    }



}
