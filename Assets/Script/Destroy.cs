using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    

    void Start()
    {
        
    }

    
   
    
        void OnCollisionEnter(Collision collision)
        {
            if (gameObject.CompareTag("dimitri"))

            Destroy(this.gameObject);


        }
    
}
