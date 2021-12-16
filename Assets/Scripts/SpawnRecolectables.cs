using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRecolectables : MonoBehaviour
{
    //Limites pantalla
    private float Horizontal = 150f;
    private float Vertical = 150f;
    private float Frontal = 150f;
    private float VerticalZero = 0;

    // Start is called before the first frame update
    void Start()
    {
        //El recolectable se genera de manera aleatoria dentro de los limites de pantalla
        transform.position = new Vector3(Random.Range(-Horizontal, Horizontal), Random.Range(-Frontal, Frontal), Random.Range(VerticalZero, Vertical));
    }
}
