using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObject : MonoBehaviour
{
    public Vector3 newPosition;
    public float speed;
    public Vector2 inputVector; 
    void Start()
    {
        Debug.Log("Game Start");
    }

    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        transform.Translate(inputVector.x * speed, 0f, inputVector.y * speed);

        Debug.Log("Game runing");

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Key P Pressed");
            transform.position = newPosition;
        }
    }
}
