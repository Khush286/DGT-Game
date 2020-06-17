using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int playerHealth = 3;
    public Rigidbody2D rb;
    public GameObject menuUI;

    private void checkForHealth()
    {
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
            // enter gameover menu
            menuUI.GetComponent<PauseMenu>().GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
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
            SceneManager.LoadScene("Room" + nextScene);
            KeyTextScript.keyAmount -= 1;
            Destroy(gameObject);
        }
        else if (other.name == "PlayerCollider")
        {
            playerHealth -= 1;
            Debug.Log(playerHealth);
            checkForHealth();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            KeyTextScript.keyAmount += 1;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            CoinTextScript.coinAmount += 1;
        }
    }







}
