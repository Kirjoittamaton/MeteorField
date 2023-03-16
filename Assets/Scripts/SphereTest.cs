using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTest : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "pallo";
        transform.position = new Vector3(0, 2, 0);
        

    }   

    // Update is called once per frame
    void Update()
    {
        // This line move the sphere up
        // transform.position = transform.position + Vector3.up* speed * Time.deltaTime;
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
    }
}
