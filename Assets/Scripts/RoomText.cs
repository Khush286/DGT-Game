using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RoomText : MonoBehaviour
{
    string currentRoom = "";

    private void Start()
    {
        currentRoom = SceneManager.GetActiveScene().name;
        GetComponent<Text>().text = currentRoom;
    }
}
