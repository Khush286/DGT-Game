﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CoinTextScript.coinAmount += 1;
            Destroy(gameObject);
            
        }
      
    }
    
}
