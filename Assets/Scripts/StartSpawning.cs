using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // Update is called once per frame
    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(Random.Range(0.0f,1.0f));
        int randomBalloonIndex = Random.Range(0,balloons.Length);
        int spawnPointsIndex = Random.Range(0,spawnPoints.Length);
        Instantiate(balloons[randomBalloonIndex],spawnPoints[spawnPointsIndex].position,Quaternion.identity);
         StartCoroutine(StartSpawning());
    }
    
}
