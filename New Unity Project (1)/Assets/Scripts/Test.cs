using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Destroy(gameObject);
            rb.AddForce(Vector3.up * 500);
        }
    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject, 0.5f);
        }
    }

 
}
