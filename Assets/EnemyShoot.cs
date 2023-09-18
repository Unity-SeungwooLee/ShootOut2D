using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float speed = 4;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
