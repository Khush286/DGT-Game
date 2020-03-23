using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {

    }
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            int nextScene = other.GetComponent<Door>().roomToAccess;
            SceneManager.LoadScene(nextScene);
            Destroy(gameObject);
        }
    }


    /* float AngleBetweenPoints(Vector2 a, Vector2 b) // Formula for finding the angle between two points
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
    public void AmIMoving()
    {
        if (transform.hasChanged)
        {
            // moving
            return;
        }
    }

    private void LookAtMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
        float angle = AngleBetweenPoints(transform.position, mousePosition);
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

    } */

}
