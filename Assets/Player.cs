using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator controlador;
    // Start is called before the first frame update
    void Start()
    {
        controlador = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //mudar
            controlador.SetTrigger("Thankful");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            controlador.SetTrigger("Jogging");

        }
    }
}
