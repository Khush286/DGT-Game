using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/****************************** Project Header ******************************\
Script Name:  HeartsTextScript
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Handles the displaying of the amount of hearts the player has.

\***************************************************************************/

public class HeartsTextScript : MonoBehaviour
{
    private GameObject heart1;
    private GameObject heart2;
    private GameObject heart3;

    void Update()
    {
        checkForHealth();
    }

    void Start()
    {
        foreach (Transform t in transform)
        {
            if (t.name == "1")
            {
                heart1 = t.gameObject;
            }
            else if (t.name == "2")
            {
                heart2 = t.gameObject;
            }
            else if (t.name == "3")
            {
                heart3 = t.gameObject;
            }
        }
    }

    private void checkForHealth()
    {
        if ( Player.playerHealth == 3)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        else if (Player.playerHealth == 2)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        else if (Player.playerHealth == 1)
        {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        else if (Player.playerHealth == 0)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
    }
}
