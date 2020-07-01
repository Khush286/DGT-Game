using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/****************************** Project Header ******************************\
Script Name:  RoomText
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Displays the current Unity Scene your in as text.

\***************************************************************************/

public class RoomText : MonoBehaviour
{
    string currentRoom = ""; // the current game scene

    private void Start()
    {
        currentRoom = SceneManager.GetActiveScene().name;
        GetComponent<Text>().text = currentRoom ;
    }
}
