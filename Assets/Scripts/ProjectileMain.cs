using System.Collections;
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
        if (other.tag == "Walls")
        {
            DestroyProjectile();
        }

        if (other.tag == "Bot")
        {
            other.GetComponent<BotMovement>().changeHealth();
            Invoke("DestroyProjectile", 0.1f);
        }

    }

}
