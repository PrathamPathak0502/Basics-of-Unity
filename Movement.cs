using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Function xecuted");
        transform.Translate(Vector3.right*0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(" update Function xecuted");
        // transform.Translate(Vector3.right*0.5f);
        // transform.Rotate(Vector3.up * 30.0f);
        transform.localScale += new Vector3(0,0.01f,0);
    }
}
