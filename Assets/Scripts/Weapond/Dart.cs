using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponController : BaseWeapon
{
  


    protected override void WeaponSpawn()
    {
        base.WeaponSpawn();
       GameObject Knife =  Instantiate(base.prefab);
        Knife.transform.position = transform.position;
    }


    protected override void Update()
    {
        base.Update();
      
        
    }

    
    
}