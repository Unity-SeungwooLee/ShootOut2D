using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    public float gemSpeed = 2;
    public float gem = 1;
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * gemSpeed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
