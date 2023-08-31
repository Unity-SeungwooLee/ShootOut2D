using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int type = 0;
    public int hp = 3;
    public float enemySpeed = 4;
    void Start()
    {
        switch (type)
        {
            case 0:
                hp = 10; enemySpeed = 1.5f;
                break;
            case 1:
                hp = 20; enemySpeed = 1.4f;
                break;
        }
    }


    void Update()
    {
        transform.position += Vector3.left * enemySpeed * Time.deltaTime;
    }
}
