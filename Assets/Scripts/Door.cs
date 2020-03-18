using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] int doorID = 0;
    [SerializeField] int roomToAccess = 0;
    [SerializeField] int correspondingDoor = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Touched");
        if (other.tag == "Player")
        {
            Debug.Log("Door was touched");
            SceneManager.LoadScene(roomToAccess);
            GameObject.FindGameObjectWithTag("Door");
            TeleportPlayer();

        }
    }
}


