using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    Vector2 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = EnemyHealth.currHealth;
        transform.localScale = localScale;
    }
}
