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

    private void Update()
    {        
        ShootUp();
        ShootDown();
        ShootLeft();
        ShootRight();
    }
    private void ShootUp()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
           GameObject projectileObject = Instantiate(projectile, spellEmitterUp.position, transform.rotation);
        }
    }
    private void ShootDown()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject projectileObject = Instantiate(projectile, spellEmitterDown.position, transform.rotation);
        }
    }
    private void ShootLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject projectileObject = Instantiate(projectile, spellEmitterLeft.position, transform.rotation);
        }
    }
    private void ShootRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GameObject projectileObject = Instantiate(projectile, spellEmitterRight.position, transform.rotation);
        }
    }
}
