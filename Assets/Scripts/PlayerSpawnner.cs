using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnner : MonoBehaviour
{
    public GameObject playerPrefab;
    public float minX, minZ, maxX, maxZ;
    public PlayerFollow playerFollow;


    private void Awake()
    {
        playerFollow = FindObjectOfType<PlayerFollow>();
    }
    private void Start()
    {
        Spawnner();
    }

    public void Spawnner()
    {
       Vector2 randomPosition = new Vector3(Random.Range(minX, maxX), 1, Random.Range(minZ, maxZ));
       GameObject player_1= PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
       playerFollow.SetCamTarget(player_1.transform);
    }
}