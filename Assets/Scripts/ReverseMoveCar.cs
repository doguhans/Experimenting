using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseMoveCar : MonoBehaviour
{
    
     
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         CarMove();
        if(Input.GetKey(KeyCode.P))
        {
            moveSpeed = 0f;
                 
        }
        else if(Input.GetKey(KeyCode.U))
        {
            moveSpeed = 10f;
        }
    }

void CarMove()
{
    float xValue= Time.deltaTime * moveSpeed;
    transform.Translate(xValue,0,0);
    
  if(transform.position.x < -10.0f)
   {
       float xpos =GetComponent<Transform>().position.x;
        xpos= xpos -31;
        transform.Translate(xpos,0,0);
   }

}

}
