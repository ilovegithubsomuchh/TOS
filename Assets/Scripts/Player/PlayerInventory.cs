using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class PlayerInventory : MonoBehaviour
{
    public List<WeaponManager> WeaponSlots = new List<WeaponManager>(4);
    private Player _player;
    
    

    #region Upgrade Class

    [System.Serializable]
    public class WeaponUpgrade
    {
        public GameObject startingWeapon;
        public WeaponSO WeaponData;
    }

    [System.Serializable]
    public class UpgradeUI
    {
        public TextMeshProUGUI UpgradeName;
        public TextMeshProUGUI UpgradeDescription;
        public Image UpgradeIcon;
        public Button UpgradeButton;
    }

    public List<WeaponUpgrade> UpgradeOptions = new List<WeaponUpgrade>();
    public List<UpgradeUI> UIOptions = new List<UpgradeUI>();

    #endregion


    private void Start()
    {
        _player = GetComponent<Player>();
    }

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

    void UpgradeOption()
    {
        foreach (var upgrade in UIOptions)
        {
            WeaponUpgrade WeaponToUpgrade = UpgradeOptions[Random.Range(0, UpgradeOptions.Count)];
            if (WeaponToUpgrade != null)
            {
                
                bool newWeapon = false;
                for (int i = 0; i < WeaponSlots.Count; i++)
                {
                    if (WeaponSlots[i] != null && WeaponSlots[i].WeaponData == WeaponToUpgrade.WeaponData)
                    {
                        newWeapon = false;
                        
                        if (!newWeapon)
                        {
                            upgrade.UpgradeButton.onClick.AddListener(() => LevelUpWeapon(i));
                        }
                        break;
                    }
                    else
                    {
                        newWeapon = true;
                    }
                }

                if (newWeapon)
                {
                    Debug.Log("here");
                    upgrade.UpgradeButton.onClick.AddListener(() => _player.SpawnWeapon(WeaponToUpgrade.startingWeapon));
                }
            }
        }
    }


    void ClearUpgradeOptions()
    {

        foreach (var upgrade in UIOptions)
        {
            upgrade.UpgradeButton.onClick.RemoveAllListeners();
        }
    }


    public void RemoveAndAndUpgrades()
    {
        ClearUpgradeOptions();
        UpgradeOption();
        
    }
    
    
}