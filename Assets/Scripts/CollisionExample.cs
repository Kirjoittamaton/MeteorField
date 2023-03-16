using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{
    public GameObject retryButton;
    public GameObject quitButton;
    public GameObject explosion;
    public GameObject destroyMusic;
    public GameObject GameOverText;
    public Animator cameraAnim;


    private void OnCollisionEnter(Collision other)
     {

        if(other.gameObject.tag == "Obstacle")
        {
            StartCoroutine(HitStop());
        }


    }

    public IEnumerator HitStop() 
    {
     Time.timeScale = 0f;
     yield return new WaitForSecondsRealtime(1f);
     Time.timeScale = 1f;
     GetComponent<Collider>().enabled = false;
     Instantiate(explosion, transform.position, transform.rotation);
     cameraAnim.SetTrigger("Shake");
     Destroy(destroyMusic.gameObject);
     GameOverText.SetActive(true);
     retryButton.SetActive(true);
     quitButton.SetActive(true);
     Destroy(gameObject);    
    }
}
  
    
       



 
    
       

              
                
       

