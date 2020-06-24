﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMain : MonoBehaviour
{
    private int changeHealth;

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Walls") // if the collider was a wall destroy projectile
        {
            DestroyProjectile();
        }

        if (other.tag == "Bot") // If the collider was a bot damage it
        {
            other.GetComponent<EnemyFollow>().changeHealth();

            DestroyProjectile();
        }
    }
}
