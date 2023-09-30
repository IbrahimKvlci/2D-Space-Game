using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GetScreenSize
{

    public static float Left { get; set; }
    public static float Right { get; set; }
    public static float Top { get; set; }
    public static float Bottom { get; set; }

    public static void Init()
    {
        float screenZ = -Camera.main.transform.position.z;
        Vector3 leftBottomCorner = new Vector3(0, 0, screenZ);
        Vector3 rightTopCorner = new Vector3(Screen.width, Screen.height, screenZ);

        Vector3 leftBottomCornerInGame = Camera.main.ScreenToWorldPoint(leftBottomCorner);
        Vector3 rightTopCornerInGame = Camera.main.ScreenToWorldPoint(rightTopCorner);
        
        Left=leftBottomCornerInGame.x;
        Right=rightTopCornerInGame.x;
        Top=rightTopCornerInGame.y;
        Bottom = leftBottomCornerInGame.y;
    }
}
