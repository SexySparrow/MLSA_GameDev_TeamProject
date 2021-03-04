using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce, jumpForce;

    public Transform player;

    private Vector2 moveInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            if (Input.GetKey("left shift"))
            {
                rb.AddForce(2 * sidewaysForce * Time.deltaTime, 0, 0);
            }
            else
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetKey("a"))
        {
            if (Input.GetKey("left shift"))
            {
                rb.AddForce(-2 * sidewaysForce * Time.deltaTime, 0, 0);
            }
            else
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetKey("w"))
        {
            if (player.position.y == 1)
            {
                rb.AddForce(0, jumpForce * Time.deltaTime, 0);
            }
        }
    }
}
