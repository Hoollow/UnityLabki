﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookaround : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;

    public float sensitivity = 200f;

    float mouseXMove = 0.0f;
    float mouseYMove = 0.0f;
    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
       mouseXMove += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
       mouseYMove -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);

        // a dla osi X obracamy kamerę dla lokalnych koordynatów
        // -mouseYMove aby uniknąć ofektu mouse inverse
        mouseYMove = Mathf.Clamp(mouseYMove, -90f, 90f);


        //transform.Rotate(new Vector3(-mouseYMove, mouseXMove, 0f), Space.Self);

        transform.eulerAngles = new Vector3(mouseYMove, mouseXMove, 0.0f);
    } 
}
