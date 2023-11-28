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

    public void LevelUpWeapon(int slotIndex)
    {
        if (WeaponSlots.Count > slotIndex && (WeaponSlots != null))
        {
            WeaponManager weaponManager = WeaponSlots[slotIndex];

            GameObject newWeapon = Instantiate(weaponManager.WeaponData.NextUpgrade, transform.position,
                Quaternion.identity);

            newWeapon.transform.SetParent(transform);
            AddWeapon(slotIndex, newWeapon.GetComponent<WeaponManager>());
            Destroy(transform.GetChild(slotIndex).gameObject);
        }
    }
}