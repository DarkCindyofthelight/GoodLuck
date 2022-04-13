using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // DANS LE ROCHHHHERRRRRRRR

    Collider collidear;
    public AudioSource odio;
    public AudioSource badodio;
    public int speed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        odio.Stop();
        badodio.Stop();
        collidear = GetComponent<Collider>();
    }

    void Update()
    {
        //rb.AddForce(Vector3.up * 0.5f, ForceMode.Impulse);
        rb.AddForce(Vector3.forward * 0.1f, ForceMode.Impulse);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Badbox"))
        {
            badodio.Play();
            // Destroy(gameObject);
            collidear.enabled = false;
            Debug.Log("j'ai toucher");

        }

        if (other.gameObject.CompareTag("Box"))
        {
            odio.Play();
            // Destroy(gameObject);
            collidear.enabled = false;
            Debug.Log("j'ai toucher");

        }

    }

}
