using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] int doorID = 0;
    public int roomToAccess = 0;
    [SerializeField] int correspondingDoor = 0;
}


