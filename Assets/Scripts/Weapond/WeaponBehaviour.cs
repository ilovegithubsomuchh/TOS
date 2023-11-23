using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : BaseWeapon
{
    public PlayerMovement PlayerMovement;
    void Update()
    {
        Movement();
    }

    protected override void Movement()
    {
        
    }
}