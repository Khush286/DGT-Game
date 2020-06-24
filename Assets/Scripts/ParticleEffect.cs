using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    public GameObject particleEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bot" || other.tag == "Walls") // If the collider was a bot damage it
        {
            GameObject Particle = Instantiate(particleEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(Particle, 3);
        }
    }
}
