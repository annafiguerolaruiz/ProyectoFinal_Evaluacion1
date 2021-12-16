using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private float Speed = 450f;
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Speed * Time.deltaTime);
    }
}
