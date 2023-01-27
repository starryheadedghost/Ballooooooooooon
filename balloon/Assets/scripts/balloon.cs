using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    public int cliccToPop = 3; // How many cliccs to pop 

    public float scaleToIncrease = 0.10f; // scale increase when balloon clicc


    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnMouseDown()
   {
      cliccToPop -= 1; /* reduce clicc by one :)
      Inflate balloon */
      transform.localScale += Vector3.one * scaleToIncrease;
      //check if clicctopop is empty
      if(cliccToPop == 0)
      {
         Destroy(gameObject); // destroy the balloon >:) 
      }
   }
}
