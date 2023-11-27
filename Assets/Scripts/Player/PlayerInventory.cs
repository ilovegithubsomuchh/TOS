using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<WeaponManager> WeaponSlots = new List<WeaponManager>(4);


    public void AddWeapon(int slotIndex, WeaponManager weapon)
    {
        WeaponSlots[slotIndex] = weapon;

    }


}
