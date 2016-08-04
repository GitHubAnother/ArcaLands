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
    public GameObject Blacks;
    public GameObject ball;

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
    void Update()
    {
        GameOver();
    }
    #endregion

    #region 控制运动
    void Move()
    {
        float h = Input.GetAxis("Horizontal");

        r2d.velocity = h * moveSpeed * Vector2.right;
    }
    #endregion

    #region 判断游戏是否结束
    void GameOver()
    {
        if (Blacks.transform.childCount == 0)
        {
            //表示游戏赢了
            UI._i.Win();
            Destroy(ball);
        }
    }
    #endregion
}
