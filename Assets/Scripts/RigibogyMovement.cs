using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RigibogyMovement : MonoBehaviour
{
    public float speed;
    public Vector2 inputVector;
    public Rigidbody rigidBody;
    public Vector3 velocity;
    public float velocityMagnitude;
    public float jumpForce;
    public bool canJump;

    public int collectedItems;

    public TMPro.TextMeshProUGUI scoreText;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        canJump = true;
    }

    
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        rigidBody.AddForce(inputVector.x * speed, 0f, inputVector.y * speed, ForceMode.Impulse);

        velocity = rigidBody.velocity;
        velocityMagnitude = velocity.magnitude;

        if(Input.GetKeyDown(KeyCode.Space) && canJump) 
        {
            rigidBody.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque contra: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }

        if (collision.gameObject.CompareTag("KillZone"))
        {
            Debug.Log ("KILL MEEEE");

            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Ganaste, felicitaciones");

            SceneManager.LoadScene(1);
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            collectedItems++;
            scoreText.text = collectedItems.ToString();
        }
    }

}
