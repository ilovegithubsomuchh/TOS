using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    private float SpawnRate;
    protected float Speed;
    protected float Damage;
    protected float Duration;
    protected float ExplosionRadius;
    protected int NumberOfSpawn;
    protected float _currentSpawnRate;


    protected virtual void Start()
    {
         SpawnRate = 3f;
        
        Speed = 25f;
    }

    protected virtual void WeaponSpawn()
    {
        _currentSpawnRate = SpawnRate;
    }

    protected virtual void Movement()
    {
    }

    protected virtual void Update()
    {
    }
}