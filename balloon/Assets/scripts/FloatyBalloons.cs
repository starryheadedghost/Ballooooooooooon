using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatyBalloons : MonoBehaviour
{

    public float moveSpeed = 1.0f;

    public float upperBound = 20;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //balloon float :)
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if(transform.position.y > upperBound)
        {
            Destroy(gameObject);
        }

    }
}
