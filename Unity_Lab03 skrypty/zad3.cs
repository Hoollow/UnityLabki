using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2ale3 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    //Rigidbody rb;
    //Vector3 StartPosition;

    private bool Right = true;
    //private bool Down = true;
   // private bool Up = true;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //StartPosition = transform.position;

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



        if (gameObject.transform.position.x >= 10.0f)
        {
            Right = false;
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }


        if (gameObject.transform.position.y >= 10.0f)
        {
            //Destroy(gameObject);
            Right = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
        }


        if(gameObject.transform.position.x <= -10.0f && gameObject.transform.position.y >= 10.0f)
        {
            Right = false;
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        if (gameObject.transform.position.y <= -10.0f)
        {
            //Destroy(gameObject);
            Right = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }

        if (gameObject.transform.position.x >= 10.0f && gameObject.transform.position.y <= -10.0f)
        {

            Right = false;
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }


    }
}
