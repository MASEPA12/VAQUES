using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCONTROLLER : MonoBehaviour
{
    private float horitzontalInput;
   
    void Update()
    {
        horitzontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * 15 * Time.deltaTime * horitzontalInput); //Moviment manual
        transform.Translate(Vector3.forward * 15 * Time.deltaTime); //Moviment automàtic
    }
}
