using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/****************************** Project Header ******************************\
Script Name:  KeyTextScript
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Responsible for displaying the amount of keys the Player is currently holding.

\***************************************************************************/

public class KeyTextScript : MonoBehaviour
{
    Text text;
    [SerializeField] public static int keyAmount; // The Amount of keys the Player has

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (keyAmount == 0)
        {
            text.text = "No Keys";
        }
        else if (keyAmount <= 1)
        {
            text.text = keyAmount.ToString() + " Key";
        }
        else if (keyAmount > 1)
        {
            text.text = keyAmount.ToString() + " Keys";
        }
    }
}
