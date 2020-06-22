using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
