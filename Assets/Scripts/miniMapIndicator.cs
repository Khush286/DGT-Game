using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class miniMapIndicator : MonoBehaviour
{
    public string currentRoom = ""; // The current game Scene
    int value = 0;
    public Transform[] childs;
    public GameObject[] childObjects;

    void Start()
    {
        childs = gameObject.GetComponentsInChildren<Transform>();
        childObjects = new GameObject[childs.Length];

        foreach (Transform trans in childs)
        {
            value++;
            childObjects.SetValue(trans.gameObject, value - 1);
        }
    }

    void Update()
    {
        currentRoom = SceneManager.GetActiveScene().name;
        foreach (GameObject go in childObjects)
        {
            if (go.name == currentRoom)
            {
                go.GetComponent<Image>().color = Color.green;
                break;
            }
        }

    }
}
