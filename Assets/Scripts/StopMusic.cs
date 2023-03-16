using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public GameObject Obstacle;
    private void OnCollisionEnter(Collision other)
    {

       if (other.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }



    }
}