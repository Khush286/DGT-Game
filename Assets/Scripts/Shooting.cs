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
    public float projectileSpeed = 12f;

    float timeLastShot = 0f;
    float delayBetweenShots = 0.8f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && (Time.time > timeLastShot + delayBetweenShots))
        {
            timeLastShot = Time.time;
            var go = Instantiate(projectile, spellEmitterUp.position, transform.rotation) as GameObject;
            go.AddComponent<ProjectileUp>();
        }

        if (Input.GetKey(KeyCode.DownArrow) && (Time.time > timeLastShot + delayBetweenShots))
        {
            timeLastShot = Time.time;
            var go = Instantiate(projectile, spellEmitterDown.position, transform.rotation) as GameObject;
            go.AddComponent<ProjectileDown>();
        }

        if (Input.GetKey(KeyCode.LeftArrow) && (Time.time > timeLastShot + delayBetweenShots))
        {
            timeLastShot = Time.time;
            var go = Instantiate(projectile, spellEmitterLeft.position, transform.rotation) as GameObject;
            go.AddComponent<ProjectileLeft>();
        }
        if (Input.GetKey(KeyCode.RightArrow) && (Time.time > timeLastShot + delayBetweenShots))
        {
            timeLastShot = Time.time;
            var go = Instantiate(projectile, spellEmitterRight.position, transform.rotation) as GameObject;
            go.AddComponent<ProjectileRight>();
        }   

    }

}
