using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************** Project Header ******************************\
Script Name:  ProjectileRight
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Intended for a projectile moving to the right.

\***************************************************************************/

public class ProjectileRight : MonoBehaviour
{
    void Update()
    {
        Invoke("DestroyProjectile", 2.0f);
        transform.Translate(Vector3.right * Time.deltaTime * 5);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
