using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGPlanetScript : MonoBehaviour
{
    float bgpspeed;
    SpriteRenderer bgpspr;
    void Start()
    {
        bgpspeed = Random.Range(2.0f, 10.0f);
        bgpspr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * bgpspeed;

        Vector3 pos = transform.position;

        if(pos.x + bgpspr.bounds.size.x / 2 < -8)
        {
            pos.x += bgpspr.bounds.size.x * 3;
            transform.position = pos;

            bgpspeed = Random.Range(2.0f, 10.0f);
        }
    }
}
