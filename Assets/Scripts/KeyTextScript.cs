using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTextScript : MonoBehaviour
{
    Text text;
    [SerializeField] public static int keyAmount;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        keyAmount = 50;
    }

    // Update is called once per frame
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
