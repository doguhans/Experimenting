using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update

    float xTranslate = 0.016f;
    float yRotate = -0.04f;
    float camSpeed= 0.1f;
     // Update is called once per frame
    void Update()
    {
        // test comment: made some changes
        if(Input.GetKey(KeyCode.X))
        {
        xTranslate = 0f;
        yRotate = 0f;
        }
        if(Input.GetKey(KeyCode.C))
        {
        xTranslate = 0.016f;
        yRotate = -0.04f;
        }
        if(Input.GetKey(KeyCode.M))
        {
            camSpeed += 0.05f;
        }
        if(Input.GetKey(KeyCode.N))
        {
            camSpeed -= 0.05f;
        }
        transform.Translate(xTranslate * camSpeed,0,0);
        transform.Rotate(0,yRotate * camSpeed,0);
    }
}
