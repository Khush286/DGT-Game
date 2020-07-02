using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/****************************** Project Header ******************************\
Script Name:  Player
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Handles the players interaction with the gamespace and Cheating if it's enabled.

\***************************************************************************/

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

    private void DoorInteraction(int roomToAccess)
    {
        SceneManager.LoadScene("Room" + roomToAccess);
        KeyTextScript.keyAmount -= 1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door" && KeyTextScript.keyAmount >= 1 && IsThisArrayEmpty(checkForBots))
        {
            DoorInteraction(other.GetComponent<Door>().roomToAccess);
        }
        else if (other.tag == "LockedDoor" && CoinTextScript.coinAmount >= 30 && KeyTextScript.keyAmount >= 1 && IsThisArrayEmpty(checkForBots))
        {
            DoorInteraction(other.GetComponent<Door>().roomToAccess);

        }
        else if (other.name == "PlayerCollider")
        {
            playerHealth -= 1;
            SpawnParticleEffect(other.gameObject.transform.position);
            other.GetComponentInParent<EnemyFollow>().health = 0;
            other.GetComponentInParent<EnemyFollow>().changeHealth();
            checkForHealth();
        }
        else if (other.name == "HeartItem" && playerHealth != 3)
        {
            playerHealth += 1;
            Destroy(other.gameObject);
        }
    }

    private bool IsThisArrayEmpty(Array array)
    {
        if (array == null || array.Length == 0)
        {
            return true;
        }
        else { return false; }
    }
    void Update()
    {
        Cheats();
        checkForBots = GameObject.FindGameObjectsWithTag("Bot");
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
            if (Input.GetKeyDown(KeyCode.H) && IsThisArrayEmpty(checkForBots))
            {
                Debug.Log("if");
            }
            else if (Input.GetKeyDown(KeyCode.H) && !IsThisArrayEmpty(checkForBots))
            {
                Debug.Log("else if");
            }
        }

    }
}
