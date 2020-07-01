using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************** Project Header ******************************\
Script Name:  KeyScript
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Handles the interaction between the player and Key objects found throughout the game.

\***************************************************************************/
public class KeyScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            KeyTextScript.keyAmount += 1;
            Destroy(gameObject);
        }

    }
}