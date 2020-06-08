using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public int health = 2;

    public void changeHealth()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            health -= 1;
        }
    }

    Vector2 movement;
    void Update()
    {
        movement.x = rb.velocity.x;
        movement.y = rb.velocity.y;
        movement = movement.normalized;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
