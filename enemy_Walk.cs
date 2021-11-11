using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Walk : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(IsFacingRight())
        {
            rb.velocity = new Vector3(moveSpeed, 0f);
        }else
        {
            rb.velocity = new Vector3(-moveSpeed, 0f);
        }
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector3(-(Mathf.Sign(rb.velocity.x)), transform.localScale.y);
    }
}