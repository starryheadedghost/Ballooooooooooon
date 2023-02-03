using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    public int cliccToPop = 3; // How many cliccs to pop 

    public float scaleToIncrease = 0.10f; // scale increase when balloon clicc

   public ScoreManager scoreManager; // a reference to the score manager

   public int scoreToGive = 100;

    // Start is called before the first frame update
    void Start()
    {
        //get scoremanager componenet 
      
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
      //tryingto fix the code 
   void OnMouseDown()
   {
      cliccToPop -= 1; /* reduce clicc by one :)
      Inflate balloon */
      transform.localScale += Vector3.one * scaleToIncrease;
      //check if clicctopop is empty
      if(cliccToPop == 0)
      {
         // tell scoremanager to increase the score 
          scoreManager.IncreaseScoreText(scoreToGive);
         Destroy(gameObject); // destroy the balloon >:) 
      }
   }
}
