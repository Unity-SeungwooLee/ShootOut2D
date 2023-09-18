using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float asteroidSpeed = 5;
    public float rotationspeed = 30;
    public int hp = 10;
    public float gem = 2;

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * asteroidSpeed, Space.World);
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * rotationspeed));
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
