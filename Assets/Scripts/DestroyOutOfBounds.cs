using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float Horizontal = 150f;
    private float Vertical = 150f;
    private float Frontal = 150f;
    private float VerticalZero = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Horizontal)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -Horizontal)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > Vertical)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < VerticalZero)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > Frontal)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -Frontal)
        {
            Destroy(gameObject);
        }
    }
}
