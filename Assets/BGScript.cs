using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScript : MonoBehaviour
{
    public float bgspeed = 2;
    SpriteRenderer bgspr;
    void Start()
    {
        bgspr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * bgspeed;
        Vector3 pos = transform.position;
        if(pos.x + bgspr.bounds.size.x / 2 < -8 )
        {
            float size = bgspr.bounds.size.x * 2;
            pos.x += size;
            transform.position = pos;
        }
    }
}
