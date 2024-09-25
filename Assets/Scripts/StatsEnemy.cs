using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsEnemy : MonoBehaviour
{
    [SerializeField] private float _life = 100f;
    //[SerializeField] private float _speed = 5f;




    public void TakeDmg(float damage)
    {
        _life -= damage;
    }
    public void TakeDmG(float damage, Vector2 position)
    {
        _life -= damage;

    }
}
