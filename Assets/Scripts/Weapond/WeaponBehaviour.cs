using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;

public class WeaponBehaviour : BaseWeapon
{
    public PlayerMovement PlayerMovement;
    private float WeaponDirectionX;
    public float WeaponDirectionY;

    void Start()
    {
        base.Start();
        PlayerMovement = FindObjectOfType<PlayerMovement>();
        WeaponDirectionX = PlayerMovement._inputValueX;
        WeaponDirectionY = PlayerMovement._inputValueY;
    }

    void Update()
    {
        Movement();
    }

    protected override void Movement()
    {
        transform.position += new Vector3((WeaponDirectionX * (Speed * Time.deltaTime)),
            (WeaponDirectionY * (Speed * Time.deltaTime)), 0);
    }
}