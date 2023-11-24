using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : BaseWeapon
{
    public List<GameObject> prefab;

    protected override void Start()
    {
        base.Start();
    }


    void Update()
    {
        _currentSpawnRate -= Time.deltaTime;
        if (_currentSpawnRate <= 0f)
        {
            WeaponSpawn();
        }
    }

    protected override void WeaponSpawn()
    {
        base.WeaponSpawn();
        foreach (var elements in prefab)
        {
            GameObject weapon = Instantiate(elements);
            weapon.transform.position = transform.position;
            weapon.transform.SetParent(transform);
        }
    }
}