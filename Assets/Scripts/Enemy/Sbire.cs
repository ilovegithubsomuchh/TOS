using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sbire : BaseEnemy
{
    public override void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position,enemyData.MoveSpeed * Time.deltaTime);
    }

    public override void Attack()
    {
        
    }

    public override void TakeDamage(float dmg)
    {
        currentHealth -= dmg;
        
        if (currentHealth < 0)
        {
            Kill();
        }
    }

    public override void Kill()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        currentMoveSpeed = enemyData.MoveSpeed;
        currentHealth = enemyData.MaxHealth;
        currentDamage = enemyData.Damage;
    }
}
