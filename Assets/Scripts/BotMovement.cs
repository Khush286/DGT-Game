using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotMovement : MonoBehaviour
{
    public Transform target; // Target to follow
    public float speed = 2f; // Movement speed
    private float minDistance = 1f; // How close to get to the Target
    public int health = 2; // Health of the bot
    private float range;

    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);

        if (range > minDistance)
        {
            transform.Translate(Vector2.MoveTowards(transform.position, target.position, range) * speed * Time.deltaTime);
        }
    }

}
