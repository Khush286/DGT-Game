using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;
    public Transform spellEmitter;

    public float projectileSpeed = 20f;

    private void Update()
    {        
        Shoot();
    }

    private void Shoot()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            GameObject projectileObject = Instantiate(projectile, spellEmitter.position, transform.rotation);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.forward * 10f, ForceMode2D.Force);
        }

    }
}
