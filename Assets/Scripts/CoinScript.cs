using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************** Project Header ******************************\
Script Name:  CoinScript
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Displays the amount of coins the Player has as text.

\***************************************************************************/

public class CoinScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CoinTextScript.coinAmount += 1;
            Destroy(gameObject);
            
        }
    }
}
 