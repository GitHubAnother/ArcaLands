/*
作者名称:YHB

脚本作用:控制

建立时间:2016.16.46
*/

using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour
{
    #region 字段
    public float moveSpeed = 100;

    private Rigidbody2D r2d;
    #endregion

    #region Unity内置函数
    void Start()
    {
        r2d = this.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }
    #endregion

    #region 控制运动
    void Move()
    {
        float h = Input.GetAxis("Horizontal");

        r2d.velocity = h * moveSpeed * Vector2.right;
    }
    #endregion
}
