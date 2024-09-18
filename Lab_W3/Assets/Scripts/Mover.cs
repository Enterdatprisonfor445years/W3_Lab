using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newva : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpStrength = 7f;
    [SerializeField] LayerMask groundFloor;

    Rigidbody rb;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
        Jump();
    }

    void PrintInstructions()
    {

        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys!");
        Debug.Log("Press Space to Jump! It will help jump over and avoid obstacles!");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, 0, zValue);
    }

    void Jump()
    {
 
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundFloor);

        // Jump when player presses spacebar and is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        }
    }
}