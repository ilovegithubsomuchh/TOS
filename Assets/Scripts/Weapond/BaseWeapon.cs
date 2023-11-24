using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    public GameObject prefab;
    protected float SpawnRate;
    protected float Speed;
    protected float Damage;
    protected float Duration;
    protected float ExplosionRadius;
    protected int NumberOfSpawn;
    private float _currentSpawnRate;


    protected virtual void Start()
    {
        SpawnRate = 2f;
        _currentSpawnRate = 2f;
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
        _currentSpawnRate -= Time.deltaTime;
        if (_currentSpawnRate <= 0f)
        {
            Debug.Log("here");
            WeaponSpawn();
        }
    }
}