using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
	public GameObject prefab;//キューブを登録する
	public GameManager gm;

	void Start()
	{
		StartCoroutine(Create());//コルーティを呼び出す
	}
	//コルーチンで生成を行う
	IEnumerator Create()//落下スピードを早くする　コルーティ定義
	{
		//生成間隔の初期値
		float delta = 1.5f;
		while (true)
		{
			GameObject obj = Instantiate(//キューブ作成　インスタンシェイトしたものを操作したいのでobjを作って代入してる
				prefab,//何を
				new Vector3(Random.Range(-10.0f, 10.0f),//floatのときは最後を含む、intの時は最後を含まない 
							Random.Range(10.0f, 15.0f), 
							Random.Range(-0.5f, 3.0f)),
				Quaternion.identity//向き　.identity 回転が0

			);
			//GameMangerをセットする。
			obj.GetComponent<CubeController>().SetGameMananger(gm);
			//生成間隔時間停止
			yield return new WaitForSeconds(delta);//コルーティンには必ず一つ必要
			//徐々に生成間隔を早める
			if (delta > 0.5f)
			{
				delta -= 0.05f;
			}
		}
	}
}
