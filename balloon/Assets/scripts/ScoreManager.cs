using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public int score; // keep score lol 

    public TextMeshProUGUI scoreText; // modifies score text  


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }
    //adds score
    public void IncreaseScoreText(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
    //subtract score
    public void DecreaseScoreText(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    //calculates score
    
    public void UpdateScoreText()
    {
        scoreText.text = "Score:" + score;
    }
}
