using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public float jumpForce = 24f;

    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Rigidbody2D playerRb = collision.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
            anim.SetTrigger("JumpPlatform");
            Destroy(gameObject, 1f);
            }
        }
    }
}
