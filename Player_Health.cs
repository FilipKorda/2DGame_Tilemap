using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    [SerializeField]
    Slider healthBar;
    [SerializeField]
    Text healthText;

    float health = 100;
    float currHealth;
    void Start()
    {
        healthBar.value = health;
        currHealth = healthBar.value;
        
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "enemy")
        {
            healthBar.value -= 2.5f;
            currHealth = healthBar.value;
        }
    }
    void Update()
    {
        healthText.text = currHealth.ToString()+ "%";
    }    
}
