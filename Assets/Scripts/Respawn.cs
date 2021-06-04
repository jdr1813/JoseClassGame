using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    bool isDead = false;
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
        isDead = true;
    }
}
