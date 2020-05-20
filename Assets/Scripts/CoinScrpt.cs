using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScrpt : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        CoinTextScript.coinAmount += 1;
        Destroy(gameObject);
    }
}
