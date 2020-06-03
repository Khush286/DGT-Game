using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMain : MonoBehaviour
{
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Walls")
        {
            DestroyProjectile();
        }

        if (other.tag == "Bot")
        {
            Debug.Log("Projectile hit a Bot");
            // other.GetComponent<Rigidbody2D>().AddForce(new Vector2(10,10)); ADDS KNOCKBACK
        }
    }
}
