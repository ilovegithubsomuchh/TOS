using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dart : BaseWeapon
{
    float x;
    float y;
    
    public override void WeaponSpawn()
    {
        DartSpawn();
    }

    public override void Movement()
    {
        
    }

    void Start()
    {
        WeaponSpawn();
    }

    IEnumerator DartSpawn()
    {
        

        switch (Player.transform.rotation.eulerAngles.z)
        {
            case  0 :

                x = 1;
                y = 0;
                Instantiate(WeaponInstanciate);
                break;
            case 45 :
                x = 1;
                y = 1;
                Instantiate(WeaponInstanciate);
                break;
        }

        return null;
    }

    public void Update()
    {
        transform.position = new Vector2(x, y);
    }
}

    


