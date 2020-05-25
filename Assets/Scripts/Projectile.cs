using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rb;
    public float thrust = 1.0f;
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 5);
    }

}
