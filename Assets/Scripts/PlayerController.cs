using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    private float Speed = 30f;
    private float TurnSpeed = 25f;
    private float VerticalInput;
    private float HorizontalInput;

    private float Horizontal = 200f;
    private float Vertical = 200f;
    private float Frontal = 200f;
    private float VerticalZero = 0;

    private int TotalMonedas = 0;
    public GameObject ProjectilePrefab;

    private Vector3 InitialPos = new Vector3(0, 100, 0);


   
    void Start()
    {
        //Posición del helicoptero al iniciar partida
        transform.position = InitialPos;
        Debug.Log(TotalMonedas);
    }

    // Update is called once per frame
    void Update()
    {
        //Ejes horizontal y vertical del player

        VerticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * TurnSpeed * Time.deltaTime * VerticalInput);
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * TurnSpeed * Time.deltaTime * HorizontalInput);

        //Movimiento continuo frontal del Player
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        //Límites eje horizontal
        if (transform.position.x > Horizontal)
        {
            transform.position = new Vector3(Horizontal, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -Horizontal)
        {
            transform.position = new Vector3(-Horizontal, transform.position.y, transform.position.z);
        }

        //Límites eje vertical
        if (transform.position.y > Vertical)
        {
            transform.position = new Vector3(transform.position.x, Vertical, transform.position.z);
        }

         if (transform.position.y < VerticalZero)
        {
            transform.position = new Vector3(transform.position.x, VerticalZero, transform.position.z);
        }

         //Límites eje frontal
        if (transform.position.z > Frontal)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Frontal);
        }

        if (transform.position.z < -Frontal)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -Frontal);
        }

        //Proyectil
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(ProjectilePrefab, transform.position, gameObject.transform.rotation); 
        }

    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("MONEDA"))
        {
            TotalMonedas += 1;
            Destroy(otherCollider.gameObject);
            Debug.Log($"Tienes {TotalMonedas} MONEDAS");
            if (TotalMonedas == 10)
            {
                Time.timeScale = 0;
                Debug.Log("HAS GANADO");
            }
        }
    }
}
