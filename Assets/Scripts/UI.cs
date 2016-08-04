/*
作者名称:YHB

脚本作用:游戏赢了输了后显示的UI

建立时间:2016.8.4.19.23
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    #region 字段
    private GameObject win;
    private GameObject los;
    private GameObject winbtn;
    private GameObject losbtn;
    #endregion

    #region Unity内置函数
    public static UI _i;
    void Awake()
    {
        _i = this;
    }
    void Start()
    {
        win = this.transform.FindChild("win").gameObject;
        los = this.transform.FindChild("los").gameObject;
        winbtn = this.transform.FindChild("winbtn").gameObject;
        losbtn = this.transform.FindChild("losbtn").gameObject;

        win.SetActive(false);
        los.SetActive(false);
        winbtn.SetActive(false);
        losbtn.SetActive(false);
    }
    #endregion

    #region 按钮事件 一样都是重新加载场景
    public void LoadScene()
    {
        Application.LoadLevel(0);
    }
    #endregion

    #region 输了 赢了的外调方法
    public void Los()
    {
        los.SetActive(true);
        losbtn.SetActive(true);
    }
    public void Win()
    {
        win.SetActive(true);
        winbtn.SetActive(true);
    }
    #endregion
}
