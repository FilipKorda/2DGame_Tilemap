using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float JumpForce;
    public float Speed;
    private Rigidbody2D rb2D;
    public Bullet BulletPrefab;
    public Transform firePoint;

    private void Start() 
    { 
        rb2D=GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() 
    {
        

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * Speed;

        if(!Mathf.Approximately(0,movement))
        
            transform.rotation = movement > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
        
        if(Input.GetKey(KeyCode.Space) && Mathf.Abs(rb2D.velocity.y)<0.001f)
        {
            rb2D.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
        }        
    }

    

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(BulletPrefab, firePoint.position, transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }

}