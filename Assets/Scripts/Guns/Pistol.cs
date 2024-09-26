using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{

   public Bullet prefabBullet;
    public override void Shoot()
    {
        Instantiate(prefabBullet, _spawnPoint.transform.position, transform.rotation);
    }
}
