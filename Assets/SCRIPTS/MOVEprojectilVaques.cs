using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEprojectilVaques : MonoBehaviour
{
    private float verticalInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveForward(); 
    }

    private void moveForward()
    {
  
        transform.Translate(Vector3.forward * 30 * Time.deltaTime);
    }
}
