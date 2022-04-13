using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class Move : MonoBehaviour
{
    public GameObject spawner;
    public GameObject préfab;
    public float speed = 5;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        float y = Input.GetAxisRaw("Jump");
        gameObject.transform.Translate(new Vector3(x, y, z) * speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(préfab, spawner.transform.position, transform.rotation);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("dimitri"))
        {
            Debug.Log("tu me touche arrete");
            transform.position = new Vector3(0, 0, -2);
        }
    }
   
    

}

