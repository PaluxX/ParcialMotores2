using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatsEnemy : MonoBehaviour
{
    public float life = 100f;
    public Bullet _bullet;
    private void Update()
    {
        
        
       die();

    }



    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 9)
        {
            
            TakeDamage();
         

        }
    }


    void TakeDamage()
    {
        life -= _bullet._damage;
    }

    void die()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

}
    
  

   

    



