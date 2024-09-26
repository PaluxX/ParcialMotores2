using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet
{
      
    
    void Update()
    {
        transform.position += transform.right * _speed * Time.deltaTime;   
    }
}
