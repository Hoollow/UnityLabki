using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad1 : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;
    Vector3 StartPosition;
    private bool Right = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Right)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
        

        if(gameObject.transform.position.x >=10.0f)
        {
            Right = false;
        }
        if(gameObject.transform.position.x <= -10.0f)
        {
            Right = true;
        }
    }

}
