using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
	private GameManager gm;//キューブはインスペクターにいないのでpublicから設定できないのでこの方法を使う

	void OnCollisionEnter(Collision coll)//OnCollisionEnterコリジョン　物体同士がぶつかった時
	{
		if (coll.gameObject.tag == "Bullet")//.gameObject.tag==""引数に入ってきたもののタグ参照
		{
			gm.SetScore(gm.GetScore() + 1);
			Destroy(gameObject, 0.1f);//第二引数　消すまでの時間
		}

		if (coll.gameObject.tag == "Floor")
		{
			gm.SetMsg("GameOver");
		}
	}
	public void SetGameMananger(GameManager gm)//セッター　
	{
		this.gm = gm;
	}

}
