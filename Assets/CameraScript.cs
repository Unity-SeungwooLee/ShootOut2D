using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    void Awake()
    {
        Camera cam = GetComponent<Camera>();
        Rect rect = cam.rect;
        float ratio = (float)Screen.width / Screen.height;
        float scaleWidth = ratio / ((float)16 / 9);
        print(scaleWidth);

        if(scaleWidth < 1)
        {
            rect.height = scaleWidth;
            rect.y = (1 - scaleWidth) / 2;
        }
        cam.rect = rect;
    }
}
