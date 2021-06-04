using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapVelocity : MonoBehaviour
{
    public float maxSpeed = 10f;
    private Rigidbody localRgb;
    // Start is called before the first frame update
    void Start()
    {
        localRgb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(localRgb.velocity.magnitude > maxSpeed)
        {
            localRgb.velocity = Vector3.ClampMagnitude(localRgb.velocity, maxSpeed);
        }
    }
}
