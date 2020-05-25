using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform spellEmitterUp;
    public Transform spellEmitterDown;
    public Transform spellEmitterLeft;
    public Transform spellEmitterRight;
    public float projectileSpeed = 20f;

    public int Shot;
    public bool canShoot;
    public float time = 5f;


    public void Update()
    {
        if (canShoot)
        {
            StartCoroutine(shoot());
        }
    }

    public IEnumerator shoot()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
           var go = Instantiate(projectile, spellEmitterUp.position, transform.rotation) as GameObject;
           go.AddComponent<ProjectileUp>();
             
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            var go = Instantiate(projectile, spellEmitterDown.position, transform.rotation) as GameObject;
            go.AddComponent<ProjectileDown>();
             
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var go = Instantiate(projectile, spellEmitterLeft.position, transform.rotation) as GameObject;
            go.AddComponent<ProjectileLeft>();
             
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            var go = Instantiate(projectile, spellEmitterRight.position, transform.rotation) as GameObject;
            go.AddComponent<ProjectileRight>();
             
        }
        canShoot = false;
        yield return new WaitForSeconds(time);
        canShoot = true;

    }


}
