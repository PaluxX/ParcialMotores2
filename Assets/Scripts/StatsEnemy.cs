using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatsEnemy : MonoBehaviour
{
    [SerializeField] private float _life = 100f;
  

    public void TakeDmg(float damage = 20)
    {
      _life -= damage;
    }

    private void Update()
    {
        if (_life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
