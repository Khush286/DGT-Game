using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class miniMap : MonoBehaviour
{
    public string currentRoom = "";
    string objectName = "";
    void Start()
    {
        objectName = gameObject.name;
        getCurrentRoom();
        changePanelColour();
    }
    public void getCurrentRoom()
    {
        currentRoom = SceneManager.GetActiveScene().name;
    }

    public void changePanelColour()
    {
        if ( objectName == currentRoom)
        {

            gameObject.GetComponent<Image>().color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.white;
        }
    }
}
