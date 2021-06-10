using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehavior : MonoBehaviour
{
    public GameObject currentTerrain;
    public GameObject terrainPrefab;
    public float terrainSpeed = 20f;
    GameObject oldTerrain = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(currentTerrain.transform.position.z < -100f)
        {
            
            oldTerrain = currentTerrain;
            currentTerrain = Instantiate(terrainPrefab, new Vector3(-506.9f, 1.7f, 874.5f), Quaternion.identity);
        }
        if (oldTerrain != null)
        {


            if (oldTerrain.transform.position.z < -1000f)
            {
                Destroy(oldTerrain);
            }
        }
    }
}
