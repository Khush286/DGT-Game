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
    public float delayInSeconds;

    private var shotFired = false;
    int time = 2;

    function FireShot()
    {
        if(Input.GetKey(KeyCode.UpArrow))
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

        yield WaitForSeconds(time);
        shotFired = false;

        function Update()
        {
            if ((!shotFired) && (Input.GetKey(KeyCode.LeftArrow))
            {
                // immediately set the shot flag so another shot can not be made
                shotFired = true;
                FireShot();
            }
        }
    }

}
