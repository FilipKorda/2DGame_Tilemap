using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 5f;

    private void Update() 
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        var enemy = other.collider.GetComponent<EnemyHealth>();
        {
            enemy.TakeHit(1); /// tu zmieniasz damage!!!!
        }
        Destroy(gameObject);
    }
    
}
