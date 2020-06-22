﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed; // Speed of bot
    public Rigidbody2D rb;
    private Transform target; // Player to target
    public int health = 2; // Health of the bot

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void changeHealth()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            health -= 1;
        }
    }

    void Update()
    {
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.position) > 0.6)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }

}
