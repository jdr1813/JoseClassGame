using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMovement : MonoBehaviour
{
    private LevelBehavior tBehavior;
    // Start is called before the first frame update
    void Start()
    {
       tBehavior = FindObjectOfType<LevelBehavior>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= Vector3.forward * tBehavior.terrainSpeed;
    }
}
