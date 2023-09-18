using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int type = 0;
    public int hp = 3;
    public float enemySpeed = 4;
    public float gem;
    public float time;
    public GameObject enemyShoot;
    public float maxShootTime;
    public float shootSpeed;
    void Start()
    {
        switch (type)
        {
            case 0:
                hp = 10; enemySpeed = 1.5f; gem = 3; maxShootTime = Random.Range(2, 5); shootSpeed = 3;
                break;
            case 1:
                hp = 20; enemySpeed = 1.4f; gem = 4; maxShootTime = Random.Range(2, 5); shootSpeed = 4;
                break;
        }
    }

    void Update()
    {
        time += Time.deltaTime;
        if(time > maxShootTime)
        {
            time = 0;
            GameObject shootObj = Instantiate(enemyShoot, transform.position, Quaternion.identity);
            EnemyShoot shootScript = shootObj.GetComponent<EnemyShoot>();
            shootScript.speed = shootSpeed;
        }
        transform.position += Vector3.left * enemySpeed * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
