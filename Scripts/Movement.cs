using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 Vec;
    public float speed = 20f;
  
    // Update is called once per frame
    void Update()
    {

        Vec = transform.localPosition;
       
        //To move the object left or right using arrow keys.
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
       
        //To make the object move forward on its own.
        Vec.z +=  Time.deltaTime * speed;

        transform.localPosition = Vec;
    }
}  

