using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * speed;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
