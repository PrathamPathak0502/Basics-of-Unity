//make a new scene in unity
//for making bullet from game object select sphere 
//now create a c# script for that bullet as this
//attach this script to sphere(rename it as bullet for better understanding during developing game) in hierarchy
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(transform.position.z>= 15.0f) //this will help to give the bullet a distance how much it should travel 
            Destroy(this.gameObject);
    else
        transform.Translate(Vector3.forward*5.0f* Time.deltaTime);
    }
}
