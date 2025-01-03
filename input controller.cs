using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
          //Debug.Log("w key is pressed");
        transform.Translate(Vector3.forward * 8.0f* Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            //Debug.Log("w key is pressed");
            transform.Translate(Vector3.back * 3.0f * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            //Debug.Log("w key is pressed");
            transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
        // if (Input.GetKey(KeyCode.w))
        //Debug.Log("w key is pressed");
        //transform.Translate(Vector3.left * 1.0f * Time.deltaTime);
        //As we hh\ave given w both up and left it is going diagonal

        if (Input.GetKey(KeyCode.S))
              //Debug.Log("S key is pressed");
        transform.Translate(Vector3.right * 1.0f * Time.deltaTime);
      
    }
    public void OnCollisionEnter(Collision collision)
    {
       // Destroy(collision.gameObject);
       //for all object

        if(collision.gameObject.name == "Coin")
            Destroy(collision.gameObject);
        else if(collision.gameObject.name == "Enemy")
            Destroy(this.gameObject);
    }
}
