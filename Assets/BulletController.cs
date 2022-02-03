using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void OnBecameInvisible()//カメラのレンダリング範囲から消えたら処理が走る
    {
        Destroy(gameObject);
    }
}
