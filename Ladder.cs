using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{

    public float speed = 1;

   private void OnTriggerStay2D(Collider2D other) {
       if(other.tag == "Player" && Input.GetKey(KeyCode.W))
       {
           other.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, speed);

       }
       else
       {
           if(other.tag == "Player" && Input.GetKey(KeyCode.S))
           {
               other.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, -speed);

           }
           else
           {
               other.GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, 0.001f);
           }
       }
   }
}
