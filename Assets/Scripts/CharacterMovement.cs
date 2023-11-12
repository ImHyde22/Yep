using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public const int Sprint = 10;
    public int MovementSpeed = 4;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (horizontalInput, verticalInput);

        transform.position += movement * MovementSpeed * Time.deltaTime;

        while (Input.GetKey("left shift"))
        {
            MovementSpeed = Sprint;
        }
    }
}
