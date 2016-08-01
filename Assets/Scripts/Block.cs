/*
作者名称:YHB

脚本作用:销毁砖块

建立时间:2016.8.1.18.39
*/

using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Destroy(this.gameObject);
        }
    }
}
