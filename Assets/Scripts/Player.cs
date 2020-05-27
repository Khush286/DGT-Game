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
        if (other.tag == "Door" && KeyTextScript.keyAmount >= 1)
        {
            int nextScene = other.GetComponent<Door>().roomToAccess;
            SceneManager.LoadScene("Room" + nextScene);
            KeyTextScript.keyAmount -= 1;
            Destroy(gameObject);

        }

        else if (other.tag == "LockedDoor" && CoinTextScript.coinAmount >= 30)
        {
                int nextScene = other.GetComponent<Door>().roomToAccess;
                SceneManager.LoadScene(nextScene);
                Destroy(gameObject);
        }
    }


 

}
