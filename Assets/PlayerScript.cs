using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    void Start()
    {
        
    }
    public float spd = 10;
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        Vector3 dir = new Vector3(x, y, 0).normalized;
        

        transform.Translate(dir * Time.deltaTime * spd);

        SpriteRenderer spr = gameObject.GetComponent<SpriteRenderer>();
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/player/player3");
            spr.sprite = sprites[0];
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/player/player2");
            spr.sprite = sprites[0];
        }
        else
        {
            Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/player/player1");
            spr.sprite = sprites[0];
        }
    }
}
