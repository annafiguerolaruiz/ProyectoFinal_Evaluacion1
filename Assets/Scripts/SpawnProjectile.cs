using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public float SpeedProjectile = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * SpeedProjectile * Time.deltaTime);
    }
}
