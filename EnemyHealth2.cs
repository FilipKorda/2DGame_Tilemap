using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth2 : MonoBehaviour
{
    public static float currHealth;
    public float Health;
    public GameObject floatingPoints;
    public int monsterValue = 6;
    

    void Start()
    {
        currHealth = Health;
        
    }

    public void TakeHit(float damage)
    {
        currHealth -= damage;
        
        if(currHealth <= 0)
        {
            GameObject points = Instantiate(floatingPoints, transform.position, Quaternion.identity)as GameObject;
            points.transform.GetChild(0).GetComponent<TextMesh>().text = "4";
            ScoreManager.instance.ChangeKillcount(monsterValue);
            Destroy(gameObject);
        }
    }

}
