using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnInterval = 1.5f;
    private float startDelay = 2;
    private Player_Controller playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<Player_Controller>();
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        if( playerControllerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(Random.Range(23, 39), 0, 0);
            Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
        }
    }
}
