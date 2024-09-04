using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibogyMovement : MonoBehaviour
{
    public float speed;
    public Vector2 inputVector;
    public Rigidbody rigidBody;
    public float jumpForce;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        rigidBody.AddForce(inputVector.x * speed, 0f, inputVector.y * speed, ForceMode.Impulse);

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rigidBody.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
        }
    }
}
