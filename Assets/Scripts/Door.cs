using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // [SerializeField] GameObject player;
    [SerializeField] int doorID = 0;
    [SerializeField] int roomToAccess = 0;
    [SerializeField] int correspondingDoor = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Touched, but wasn't player");
        if (other.tag == "Player")
        {
            Debug.Log("Door was touched player");
            SceneManager.LoadScene(roomToAccess);
            GameObject.FindGameObjectWithTag("Door");
            //TeleportPlayer();
            //SceneManager.MoveGameObjectToScene(player, SceneManager.GetActiveScene());

        }
    }
}


