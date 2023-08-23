using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGStarScript : MonoBehaviour
{
    float bgstar_speed;
    float bgstar_y;
    SpriteRenderer bgstar;
    void Start()
    {
        bgstar = GetComponent<SpriteRenderer>();
        bgstar_speed = Random.Range(1.0f, 5.0f);
        bgstar_y = Random.Range(-4.7f, 4.7f);
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * bgstar_speed;
        Vector3 pos = transform.position;
        if(pos.x + bgstar.bounds.size.x / 2 < -8)
        {
            pos.x += bgstar.bounds.size.x * 2;
            pos.y = bgstar_y;
            transform.position = pos;

            bgstar_speed = Random.Range(1.0f, 5.0f);
            bgstar_y = Random.Range(-4.7f, 4.7f);
        }
    }
}
