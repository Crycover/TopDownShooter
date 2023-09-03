using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private EnemyData _enemyData;
    [SerializeField] private WeaponManager _weaponManager;
    private int _health;
    [SerializeField] private AudioSource _audioSource;
    private void Awake()
    {
        _weaponManager = GameObject.FindGameObjectWithTag("Player").GetComponent<WeaponManager>();
        _enemyData.Health = 100;
        _health = _enemyData.Health;
    }

    private void Update()
    {
        if(_health <= 0)
        {
            Destroy(this.gameObject, 0.2f);
        }
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            _audioSource.Play();
            TakeDamage(_weaponManager.damage);
            Debug.Log(_health);
        }
    }
}
