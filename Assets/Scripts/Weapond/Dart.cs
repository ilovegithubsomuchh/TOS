using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponController : BaseWeapon
{
    public GameObject prefab;


    protected override void WeaponSpawn()
    {
        base.WeaponSpawn();
        Instantiate(prefab);
        prefab.transform.position = transform.position;
    }


    protected override void Update()
    {
        base.Update();
      
        
    }

    
    
}