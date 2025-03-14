using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private float Speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on verticle input
        transform.Translate(Vector3.forward * Time.deltaTime * 20 * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up ,turnSpeed * horizontalInput * Time.deltaTime); 
    }
}
