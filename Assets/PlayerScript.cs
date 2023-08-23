using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float spd = 10;
    private SpriteRenderer spr;
    private Sprite[] player1Sprites;
    private Sprite[] player2Sprites;
    private Sprite[] player3Sprites;

    void Start()
    {
        spr = gameObject.GetComponent<SpriteRenderer>();
        player1Sprites = Resources.LoadAll<Sprite>("Sprites/player/player1");
        player2Sprites = Resources.LoadAll<Sprite>("Sprites/player/player2");
        player3Sprites = Resources.LoadAll<Sprite>("Sprites/player/player3");
    }
    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        Vector3 dir = new Vector3(x, y, 0).normalized;
        

        transform.Translate(dir * Time.deltaTime * spd);

        if(Input.GetKey(KeyCode.UpArrow))
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
    }
}
