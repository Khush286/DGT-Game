using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int playerHealth = 3; // The Players current health
    public Rigidbody2D rb;
    public GameObject menuUI;
    private GameObject[] isThereBots;

    private void checkForHealth()
    {
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
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
        Cheats();
    }

    private void Cheats()
    {
        if(PauseMenu.CheatsEnabled)
        {
            if (Input.GetKeyDown(KeyCode.J) && playerHealth <= 2 && playerHealth >= 1)
            {
                playerHealth += 1;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                KeyTextScript.keyAmount += 1;
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                CoinTextScript.coinAmount += 1;
            }
            var item = GameObject.FindGameObjectsWithTag("Bot");
            if (item == null)
            {
                Debug.Log("returned null");
            }
            else if (item != null)
            {
                Debug.Log(item);
            }
        }

    }
}
