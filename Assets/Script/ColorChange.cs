using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public bool red;
   

    void Start()
    {

        red = false;


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            red = true;

        }



        if (red == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;


        }


    }
    

}