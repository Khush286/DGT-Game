using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsTextScript : MonoBehaviour
{
    //public static int playerHealth = 0;

    void Start()
    {
        //playerHealth = Player.playerHealth;
        //Debug.Log(playerHealth);
    }

    void Update()
    {
        foreach (Transform t in transform)
        {
            if (t.name == "1") ;// Do something to child one
            {


            }
            else if (t.name == "2") ;// Do something to child two
            {


            }
        }
    }
}
