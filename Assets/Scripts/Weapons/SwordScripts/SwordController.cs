using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : WeaponManager
{
    protected override void Attack()
    {
        base.Attack();
        GameObject Sword = Instantiate(WeaponData.prefab);
        Sword.transform.position = transform.position;
        Sword.transform.SetParent(transform);
    }
}