using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    public int jumpHeight = 500;
    bool canJump = true;
    public Rigidbody rb;
    private int jumpsLeft = 0;
    private bool isFlying = false;
    public float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
        if (Input.GetKeyDown("space") && canJump && jumpsLeft > 0)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
            if (!isFlying) canJump = false;
            jumpsLeft--;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
            jumpsLeft++;
        }
        else
        {
            canJump = false;
            print("not ground");
        }
        if (collision.gameObject.name == "RightBoundary")  
        {
            rb.velocity = Vector3.zero;
        }
        if (collision.gameObject.name == "LeftBoundary")
        {
            rb.velocity = Vector3.zero;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "trigger")
        {
            isFlying = true;
            canJump =  true;
            jumpsLeft--;
        }

    }
}
