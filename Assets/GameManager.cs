using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GUIStyle scoreStyle;//OnGUIで設定ができるようになる
    public GUIStyle msgStyle;
    int score = 0;
    string msg = "";

    private void Update()
    {
        if(msg == "GameOver")
        {
            Time.timeScale = 0f;//スローとかストップが出来る。止まってるだけUpdateが終わったわけではない
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 10, 10), score.ToString(), scoreStyle);//第三引数でスタイルを当てられる
        GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 25, 300, 50), msg, msgStyle);//画面の真ん中に設定 
        //スタート位置なので/2だけだと右寄りになるので文字の範囲の半分ずらした
    }
    //ゲッター
    public int GetScore()
    {
        return score;
    }
    //セッター
    public void SetScore(int score)
    {
        this.score = score;
    }

    public string GetMsg()
    {
        return msg;
    }

    public void SetMsg(string msg)
    {
        this.msg = msg;
    }
}
