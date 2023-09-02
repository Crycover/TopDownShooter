using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    void Update()
    {
        _weapon.transform.Rotate(0, 0, 45 * Time.deltaTime * 5f);
    }
}
