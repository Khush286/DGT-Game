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
    private GameObject[] checkForBots;
    public bool botsExist;
    public GameObject particleEffect;

    private void checkForHealth()
    {
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void SpawnParticleEffect(Vector2 spawnPosition)
    {
        GameObject Particle = Instantiate(particleEffect, spawnPosition, Quaternion.identity) as GameObject;
        Destroy(Particle, 3);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door" && KeyTextScript.keyAmount >= 1 && IsThisArrayEmpty())
        {
            int nextScene = other.GetComponent<Door>().roomToAccess;
            SceneManager.LoadScene("Room" + nextScene);
            KeyTextScript.keyAmount -= 1;
            Destroy(gameObject);
        }
        else if (other.tag == "LockedDoor" && CoinTextScript.coinAmount >= 30 && IsThisArrayEmpty())
        {
            int nextScene = other.GetComponent<Door>().roomToAccess;
            SceneManager.LoadScene("Room" + nextScene);
            KeyTextScript.keyAmount -= 1;
            Destroy(gameObject);
        }
        else if (other.name == "PlayerCollider")
        {
            playerHealth -= 1;
            SpawnParticleEffect(other.gameObject.transform.position);
            Destroy(other.transform.parent.gameObject);
            Debug.Log(playerHealth);
            checkForHealth();
        }
    }
    void Update()
    {
        Cheats();
        checkForBots = GameObject.FindGameObjectsWithTag("Bot");
    }
    private bool IsThisArrayEmpty()
    {
        if (checkForBots == null || checkForBots.Length == 0)
        {
            return true;

        } else { return false; }

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
            if (Input.GetKeyDown(KeyCode.H) && IsThisArrayEmpty())
            {
                Debug.Log("if");
            }
            else if (Input.GetKeyDown(KeyCode.H) && !IsThisArrayEmpty())
            {
                Debug.Log("else if");
            }
        }

    }
}
