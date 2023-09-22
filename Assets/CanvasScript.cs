using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CanvasScript : MonoBehaviour
{
    public TMP_Text myText;
    void Start()
    {
        print("Width " + Screen.width);
        print("Height " + Screen.height);
        print(Camera.main.ViewportToScreenPoint(new Vector3(0,0,0)));
        print(Camera.main.ViewportToScreenPoint(new Vector3(1, 1, 0)));
        myText.GetComponent <RectTransform>().position = Camera.main.ViewportToScreenPoint(new Vector3(0, 0, 0));
    }

    private void Update()
    {
        myText.GetComponent<RectTransform>().position = Input.mousePosition;
    }
}