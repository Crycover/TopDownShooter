using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    [SerializeField] private WeaponData _weaponData;
    public int damage;
    void Update()
    {
        _weapon.transform.Rotate(0, 0, 360f * Time.deltaTime);
        damage = _weaponData.Damage;
    }

}
