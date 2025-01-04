using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _playerAnimator; // Declare the Animator variable

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the _playerAnimator by getting the Animator component attached to this GameObject
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _playerAnimator.SetInteger("state", 2); // Set the "state" parameter to 2
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _playerAnimator.SetInteger("state", 1); // Set the "state" parameter to 1
        }
        else if (Input.GetKey(KeyCode.R))
        {
            _playerAnimator.SetInteger("state", 3); // Set the "state" parameter to 3
        }
        else
        {
            _playerAnimator.SetInteger("state", 0); // Set the "state" parameter to 0 (default state)
        }
    }
}
