using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject character;
    public float cameraHeight; 
    public float cameraDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterPosition = character.transform.position;
        gameObject.transform.position =  new Vector3(characterPosition.x, cameraHeight, characterPosition.z + cameraDistance);
    }
}
