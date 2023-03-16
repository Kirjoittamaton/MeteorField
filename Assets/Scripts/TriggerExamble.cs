using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExamble : MonoBehaviour
{
    public GameManager gm;
    public GameObject MineralCollectedEffect;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            Instantiate(MineralCollectedEffect, new Vector3(transform.position.x,transform.position.y + 15f, transform.position.z), transform.rotation);
            Destroy(other.gameObject);
            gm.AddScore();
            

        }
    }
}
