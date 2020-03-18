using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // configuration parameters
    [SerializeField] Player player;
    [SerializeField] float moveSpeed = 8.5f; // player movement speed
    [SerializeField] float padding = 0.6f; // how close you can get to the edge of the screen
    //

    float xMin;
    float xMax;
    float yMin;
    float yMax;

    float AngleBetweenPoints(Vector2 a, Vector2 b) // Formula for finding the angle between two points
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    } 

    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        SetUpMoveBoundaries();
    }

    void Update()
    {
        Move();
        LookAtMouse();
        AmIMoving();

    }

    //public void TeleportPlayer()
    //{
        
    //}

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

    }

    private void SetUpMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }

    private void Move()
    {

        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);
        transform.position = new Vector2(newXPos, transform.position.y);
        transform.position = new Vector2(transform.position.x, newYPos);
    }



}
