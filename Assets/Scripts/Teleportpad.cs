using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportpad : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform playerPrefab;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           // playerPrefab.position = teleportTarget.position;
           other.gameObject.transform.position = teleportTarget.transform.position;
        }
    }
}
