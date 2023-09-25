using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text gemScore;
    public GameObject pauseMenu;
    public static GameManager instance;
    public List<GameObject> enemies;
    public GameObject asteroid;
    public float time = 0;
    public float spawnTime = 3;
    public float spawnSpeed;
    public float gem;
    public float maxRight;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        gem = 0;
        gemScore.text = gem.ToString();
        maxRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;
    }
    void Update()
    {
        spawnSpeed = Random.Range(1.0f, 5.0f);
        time += Time.deltaTime * spawnSpeed;

        if(time > spawnTime)
        {
            time = 0;
            int check = Random.Range(0, 2);
            if(check == 0)
            {
                Instantiate(asteroid, new Vector3(maxRight + Random.Range(2.0f, 5.0f), Random.Range(-4.0f, 4.0f), 0), Quaternion.identity);
            }
            else
            {
                int type = Random.Range(0, 2);
                Instantiate(enemies[type], new Vector3(maxRight + Random.Range(2.0f, 5.0f), Random.Range(-4.0f, 4.0f), 0), Quaternion.identity);
            }
        }
    }
    public void PauseAction()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void ResumeAction()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void MainMenuAction()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("MainMenuScene");
    }
}
