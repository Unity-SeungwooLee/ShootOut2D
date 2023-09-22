using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text gemScore;
    public static GameManager instance;
    public List<GameObject> enemies;
    public GameObject asteroid;
    public float time = 0;
    public float spawnTime = 3;
    public float spawnSpeed;
    public float gem;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        gem = 0;
        gemScore.text = gem.ToString();
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
                Instantiate(asteroid, new Vector3(Random.Range(9.0f, 12.0f), Random.Range(-4.0f, 4.0f), 0), Quaternion.identity);
            }
            else
            {
                int type = Random.Range(0, 2);
                Instantiate(enemies[type], new Vector3(Random.Range(9.0f, 12.0f), Random.Range(-4.0f, 4.0f), 0), Quaternion.identity);
            }
        }
    }
}
