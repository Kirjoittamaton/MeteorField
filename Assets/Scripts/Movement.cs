using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public float originalSpeed;
    public float boostSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        originalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetButton("Jump"))
        {
            speed = boostSpeed;
        }

        else 
        {
            speed = originalSpeed;
        }

        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
   }
   
}