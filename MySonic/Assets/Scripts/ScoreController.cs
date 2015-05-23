using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static int score;

    Text text; 

    public void Start()
    {
        text = GetComponent<Text>();

        score = 0;
        UpdateScore();
    }
    
    
    public void Update()
    {
        if(score < 0)
        {
            score = 0;
        }
        text.text = "" + score;
    }

    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScore();
    }

    public void UpdateScore()
    {
        text.text = "Score: " + score;
    }
}
