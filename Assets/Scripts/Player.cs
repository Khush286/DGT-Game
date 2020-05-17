using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D other) // Waits for door collision, then loads corresponding room
    {
        if (other.tag == "Door")
        {
            int nextScene = other.GetComponent<Door>().roomToAccess;
            SceneManager.LoadScene(nextScene);
            Destroy(gameObject);
        }
    }
    /* public void AmIMoving()
    {
        if (transform.hasChanged)
        {
            // moving
            return;
        }
    } */

}
