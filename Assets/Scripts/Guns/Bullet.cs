using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] protected float _speed;
    public float _damage;

    StatsEnemy _enemy;

    
    
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 8)
        {

            
            Destroy(gameObject);

        }
    }


}
