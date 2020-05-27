using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextScript : MonoBehaviour
{
    Text text;
    [SerializeField] public static int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        coinAmount = 30;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Coins: " + coinAmount.ToString() + "/30";
    }
}
