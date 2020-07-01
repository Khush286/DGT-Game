using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************** Project Header ******************************\
Script Name:  ProjectileUp
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Intended for a projectile moving upwards.

\***************************************************************************/

public class ProjectileUp : MonoBehaviour
{
    void Update()
    {
        Invoke("DestroyProjectile", 2.0f);
        transform.Translate(Vector3.up * Time.deltaTime * 5);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
