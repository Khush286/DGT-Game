using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************** Project Header ******************************\
Script Name:  ProjectileLeft
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Intended for a projectile moving to the left.

\***************************************************************************/

public class ProjectileLeft : MonoBehaviour
{
    void Update()
    {
        Invoke("DestroyProjectile", 2.0f);
        transform.Translate(Vector3.left * Time.deltaTime * 5);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
