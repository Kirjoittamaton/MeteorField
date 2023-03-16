using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    public int score;
    public static int hiScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiScoreText;



    public GameObject[] meteorFields;
    public GameObject player;

    public Animator fadeScreen;
    public float TransitionTinme;

    private void Start()
    {
        hiScore = PlayerPrefs.GetInt("HiScore");
        hiScoreText.text = "Hi Score: " + hiScore.ToString();
        
    }

    public void StartGame()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(1));
    }


    public void Retry()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(1));

    }

    public void Exit()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(0));

    }

    public void OnApplicationQuit()
    {
        fadeScreen.SetTrigger("FadeOut");
        Application.Quit();
    }


    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();

        if(score > hiScore)
        {
            hiScore = score;
            hiScoreText.text = "Hi Score: "+hiScore.ToString();
            PlayerPrefs.SetInt("HiScore", hiScore);
            PlayerPrefs.Save();
        }
    }
    public void ClearData()
    {
        PlayerPrefs.SetInt("HiScore", 0);
        hiScore = PlayerPrefs.GetInt("HiScore");
        hiScoreText.text = "Hi Score: " + hiScore.ToString();
        PlayerPrefs.Save();
        }

    public void SpawnMeteorField()
    {
        int rnd = Random.Range(0,4);
        Instantiate(meteorFields[rnd],new Vector3(player.transform.position.x, player.transform.position.y+14,player.transform.position.z), player.transform.rotation);
    }

    public IEnumerator LoadLevel(int levelToLoad)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(levelToLoad);
        
    }
}