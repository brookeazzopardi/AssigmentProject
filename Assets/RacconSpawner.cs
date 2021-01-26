using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacconSpawner : MonoBehaviour
{

    public GameObject racconPrefab;
    public Transform[] spawnPoints;
    public float gameTime;
    public Text gameText;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        gameTime -= Time.deltaTime;
        if(gameTime < 1)
        {
            gameTime = 0;
        }
        gameText.text = gameTime.ToString();

    }
    public void Spawn()
    { 
        GameObject raccon = Instantiate(racconPrefab) as GameObject; 
        raccon.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
    }
}