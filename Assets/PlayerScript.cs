using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10;
    private SpriteRenderer spr;
    private Sprite[] player1Sprites;
    private Sprite[] player2Sprites;
    private Sprite[] player3Sprites;
    Vector3 min, max;
    Vector2 colsize, chrsize;

    public GameObject shoot;
    public Transform shootPointTransform;

    void Start()
    {
        spr = gameObject.GetComponent<SpriteRenderer>();
        player1Sprites = Resources.LoadAll<Sprite>("01_Sprites/player/player1");
        player2Sprites = Resources.LoadAll<Sprite>("01_Sprites/player/player2");
        player3Sprites = Resources.LoadAll<Sprite>("01_Sprites/player/player3");

        min = new Vector3(-8, -4.5f, 0);
        max = new Vector3(8, 4.5f, 0);

        colsize = GetComponent<BoxCollider2D>().size;
        chrsize = new Vector2(colsize.x / 2, colsize.y / 2);
    }
    
    void Update()
    {
        Move();
        PlayerShoot();
        
    }
    /*
    public float shotMax = 0.1f;
    public float shotDelay = 0;
    void PlayerShoot()
    {
        shotDelay += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(shotDelay > shotMax)
            {
                shotDelay = 0;
                Instantiate(shoot, shootPointTransform.position, Quaternion.identity);
            }
        }
        
    }
    */
    void PlayerShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shoot, shootPointTransform.position, Quaternion.identity);
        }

    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        Vector3 dir = new Vector3(x, y, 0).normalized;


        transform.Translate(dir * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            spr.sprite = player3Sprites[0];
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            spr.sprite = player2Sprites[0];
        }
        else
        {
            spr.sprite = player1Sprites[0];
        }

        float nowX = transform.position.x;
        float nowY = transform.position.y;

        nowX = Mathf.Clamp(nowX, min.x + chrsize.x, max.x - chrsize.x);
        nowY = Mathf.Clamp(nowY, min.y + chrsize.y, max.y - chrsize.y);

        transform.position = new Vector3(nowX, nowY, transform.position.z);
    }
}
