using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextScript : MonoBehaviour
{
    Text text;
    [SerializeField] public static int coinAmount; // The Players coins

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Coins: " + coinAmount.ToString() + "/30";
    }
}
