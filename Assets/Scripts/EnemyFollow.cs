﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************** Project Header ******************************\
Script Name:  EnemyFollow
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Handles the Enemies 'AI', and health.

\***************************************************************************/

public class EnemyFollow : MonoBehaviour
{
    public float speed; // Speed of bot
    public Rigidbody2D rb;
    private Transform target; // Player to target
    public int health = 2; // Health of the bot
    public GameObject coin;
    public GameObject key;
    private GameObject[] checkForBots;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void changeHealth()
    {
        if (health <= 0)
        {
            Debug.Log(checkForBots.Length);
            Destroy(gameObject);
            if (checkForBots.Length == 1)
            {
                key = Instantiate(key, transform.position, transform.rotation);
            }
            else
            {
                coin = Instantiate(coin, transform.position, transform.rotation);
            }

        }
        else
        {
            health -= 1;
        }
    }
    void Update()
    {
        checkForBots = GameObject.FindGameObjectsWithTag("Bot");
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.position) > 0.6)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
}
