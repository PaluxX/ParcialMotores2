using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatsEnemy : MonoBehaviour
{
    public float life = 100f;
    public Bullet _bullet;

    public Renderer enemigoRenderer;

    
    private void Update()
    {



        colorChange();
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

    
    void colorChange()
    {
        
        
        if (life <= 50)
        {
            enemigoRenderer.material.color = Color.yellow;

            if (life <= 30)
            {
                enemigoRenderer.material.color = Color.red;
            }
        }

       
    }
    void die()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

}
    
  

   

    



