using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
 
     private float Horizontal = 150f;
     private float Vertical = 150f;
     private float Frontal = 150f;
     private float VerticalZero = 0;

     public GameObject obstaclePrefab;
     private Vector3 spawnPosition;

     private float startTime = 2f;
     private float repeatRate = 5f;

     // Start is called before the first frame update
     void Start()
     {
        //Función para que llame al obstaculo
         InvokeRepeating("SpawnObstaclePrefab", startTime, repeatRate);
     }

     public Vector3 RandomSpawnPosition()
     {
         return new Vector3(Random.Range(-Horizontal, Horizontal), Random.Range(VerticalZero, Vertical), Random.Range(-Frontal, Frontal));
     }

     public void SpawnObstaclePrefab()
     {

         spawnPosition = RandomSpawnPosition();
         Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
     }
    
}
