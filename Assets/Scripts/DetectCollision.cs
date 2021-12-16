using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision otherCollider)
    {
        if (gameObject.CompareTag("OBSTACLE") && otherCollider.gameObject.CompareTag("PLAYER"))
        {
            Debug.Log($"GAME OVER");
            Time.timeScale = 0;
        }
        if (gameObject.CompareTag("OBSTACLE") && otherCollider.gameObject.CompareTag("PROYECTIL"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
        }
    }
}
