using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
 

    public float speed = 10f;

    private Rigidbody rb;
    public float speed = 10f;
    public KeyCode forwardKey = KeyCode.W;
    public KeyCode backwardKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(forwardKey))
        {
            vertical = 1f;
        }
        else if (Input.GetKey(backwardKey))
        {
            vertical = -1f;
        }

        if (Input.GetKey(leftKey))
        {
            horizontal = -1f;
        }
        else if (Input.GetKey(rightKey))
        {
            horizontal = 1f;
        }
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        rb.AddForce(movement * speed);
    }
}
