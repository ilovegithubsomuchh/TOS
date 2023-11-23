using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    protected float SpawnRate;
    protected float Speed;
    protected float Damage;
    protected float Duration;
    protected float ExplosionRadius;
    protected int NumberOfSpawn;
    
    public GameObject Player;
    public GameObject WeaponInstanciate;


    public abstract void WeaponSpawn();

    public abstract void Movement();

    private void Start()
    {
        
    }
}
