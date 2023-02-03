using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatyBalloons : MonoBehaviour
{

    public float moveSpeed = 1.0f;

    public float upperBound = 20;

    public ScoreManager scoreManager; // reference to the scoremanager

    public balloon Balloon; //reference balloon script for score
    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        Balloon = GetComponent<balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        //balloon float :)
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(Balloon.scoreToGive);//reduces score for failure 
            Destroy(gameObject); //pops balloons
        }

    }
}
