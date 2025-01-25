using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb; // Reference to the Rigidbody component

    public float moveSpeed = 5f;
    public float rotationSpeed = 30f;
    public float scaleSpeed = 0.01f;
    public float jumpForce = 5f;

    void Start()
    {
        Debug.Log("Start Function Executed");
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
    }

    void Update()
    {
        // Debug message for each frame
        Debug.Log("Update Function Executed");

        // Move the object with arrow keys 
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(new Vector3(moveX, 0, moveY));

        // Rotate the object continuously
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Scale the object gradually
        transform.localScale += new Vector3(0, scaleSpeed, 0);

        // Jump when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
