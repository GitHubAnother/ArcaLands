/*
作者名称:YHB

脚本作用:游戏输了脚本

建立时间:2016.8.4.19.28
*/

using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            UI._i.Los();
        }
    }
}
