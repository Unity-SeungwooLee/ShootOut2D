using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject asteroid;
    public float time = 0;
    public float maxTime = 3;
    float asteroidGenSpeed;
    void Update()
    {
        asteroidGenSpeed = Random.Range(1.0f, 5.0f);
        time += Time.deltaTime * asteroidGenSpeed;

        if(time > maxTime)
        {
            time = 0;
            Instantiate(asteroid, new Vector3(Random.Range(9.0f, 12.0f), Random.Range(-4.0f, 4.0f), 0), Quaternion.identity);
        }
    }
}
