using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;

    int score;
    int score2;
    

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "= "+ score.ToString();
    }

    public void ChangeKillcount(int killMobs)
    {
        score2 += killMobs;
        text2.text = "= "+ score2.ToString();
    }
}
