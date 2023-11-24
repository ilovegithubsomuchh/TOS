using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;

public class KnifeBehaviour : Dart
{
    public PlayerMovement PlayerMovement;
    private float WeaponDirectionX;
    public float WeaponDirectionY;
   

    protected override void Start()
    {
        base.Start();
       
        PlayerMovement = FindObjectOfType<PlayerMovement>();
        WeaponDirectionX = PlayerMovement._inputValueX;
        WeaponDirectionY = PlayerMovement._inputValueY;
        if ((WeaponDirectionX == 0) && (WeaponDirectionY == 0))
        {
            WeaponDirectionX = 1;
        }
    }

    protected override void Update()
    {
        Movement();
       
    }

    protected override void Movement()
    {
        transform.position += new Vector3((WeaponDirectionX * (Speed * Time.deltaTime)),
            (WeaponDirectionY * (Speed * Time.deltaTime)), 0);
    }
}