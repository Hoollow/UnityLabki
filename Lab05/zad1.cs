using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad1 : MonoBehaviour
{
    public float speed = 1.5f;
    private bool move = true;
    private bool moveWithPlayer = true;
    public Vector3 startPostion;
    public Vector3 endPositon;
    

    private void Start()
    {
        startPostion = transform.position;
    }

    private void Update()
    {
        if(moveWithPlayer)
        {
            if (move)
            {
                transform.position = Vector3.MoveTowards(transform.position, endPositon, speed * Time.deltaTime);
            }
            else
                transform.position = Vector3.MoveTowards(transform.position, startPostion, speed * Time.deltaTime);

            if(transform.position == endPositon)
            {
                move = false;
            }
            else if(transform.position == startPostion)
            {
                move = true;
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            moveWithPlayer = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            moveWithPlayer = false;
        }
    }

}
