using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomText : MonoBehaviour
{
    private void Update()
    {
        GetComponent<TextMesh>().text = "new Text u want";
    }
}
