using UnityEngine;

[CreateAssetMenu(menuName = "TopDown / Weapon / Weapon Data")]
public class WeaponData : ScriptableObject
{
    [SerializeField] private int _damage;

    public int Damage { get { return _damage; } set { _damage = value; } }
}
