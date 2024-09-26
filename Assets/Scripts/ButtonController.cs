using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : Controller
{

    [SerializeField] Weapon _weapon;
    
    
    public override Vector3 GetMovementInput()
    {
        return _moveDir;
    }




    public void MoveRight()
    {

        _moveDir = Vector3.right;
        lookingLeft = false;
    
    }
    public void MoveLeft() 
    {
        
        _moveDir = Vector3.left;
        lookingLeft = true;
        

    }

    public void Static()
    {
        
        _moveDir = Vector3.zero;
            
    }

    public void Shoot() 
    {
        _weapon.Shoot();
    }
}
