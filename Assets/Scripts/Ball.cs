/*
作者名称:YHB

脚本作用:小球的运动

建立时间:2016.8.1.17.32 
*/

using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    #region 字段
    public float moveSpeed = 160;

    private Rigidbody2D r2d;
    #endregion

    #region Unity内置函数
    void Start()
    {
        r2d = this.GetComponent<Rigidbody2D>();

        r2d.velocity = Vector2.up * moveSpeed;//初始给一个速度
    }
    #endregion

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racket")
        {
            float angle = shootAngle(this.transform.position, collision.transform.position, collision.collider.bounds.size.x);

            Vector2 dir = new Vector2(angle, 1).normalized;

            r2d.velocity = dir * moveSpeed;
        }
    }

    //射出角度计算方法
    float shootAngle(Vector2 ballPos, Vector2 racketPos, float width)
    {
        return (ballPos.x - racketPos.x) / width;
    }
}
