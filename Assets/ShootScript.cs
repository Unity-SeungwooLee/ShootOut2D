using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject hitEffect;
    public float speed = 10;

    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * speed;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.tag);
        if(collision.tag == "Asteroid")
        {
            AsteroidScript asteroidScript = collision.gameObject.GetComponent<AsteroidScript>();
            asteroidScript.hp -= 3;
            Instantiate(hitEffect, transform.position, Quaternion.identity);
            if(asteroidScript.hp <= 0 )
            {
                Destroy(collision.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
