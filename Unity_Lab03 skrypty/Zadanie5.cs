using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    public int HowMany = 10;

    void Start()
    {

        for (int i = 0; i < HowMany; i++)
        {
            Instantiate(cube, SpawnPoints(), Quaternion.identity);
        }
       
    }

    Vector3 SpawnPoints()
        {
            float x = Random.Range(0f, 9f);
            float y = Random.Range(0f, 9f);
            float z = Random.Range(0f, 9f);    
        return new Vector3(x, y,z);
        }


}
