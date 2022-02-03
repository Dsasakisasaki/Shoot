using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour//継承は：コロン
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//0が左クリック、１が右クリック　Input入力系に使う
        {
            GameObject obj = Instantiate(prefab);

            obj.transform.parent = transform;//このスクリプトがアタッチされているオブジェクト（今回ならカメラ）

            obj.transform.localPosition =Vector3.zero;//オフセットの設定　今回は0 前に4ずらすなら.forward*4

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//Ray光線　Canera.main最初からあるメインカメラ
            //ScreenPointToRayカメラからポイントに向けた光線
            //Camera.mainでmainCameraタグの付いているカメラを指す

            Vector3 dir = ray.direction.normalized;//ray.directio　Ray型からVextor3型に変換する（Rayのベクトルを抜き出してる）
            //力のかけ方はだいたい以下の二種
            obj.GetComponent<Rigidbody>().velocity = dir * 100.0f;//.GetComponent<コンポーネント>()
            obj.GetComponent<Rigidbody>().AddForce(dir * 100f);//AddForce() 力を加える　　　こちらはメソッド　 ()が付くのは全てメソッド
                                                               //velocity　速度を●●にする(初速度) こちらはプロパティ(Javaで言うとこのフィールド)だから代入して使う
            //AddForce(dir * 100f,ForceMode.Inpulse);第二引数に力の加え方　これなら瞬間的に加える
        }
    }
}
