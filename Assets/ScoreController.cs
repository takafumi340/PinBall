using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //得点を0で初期化
    private int score = 0;

    //得点を表示するテキスト
    private GameObject ScoreText;

    // Start is called before the first frame update
    void Start()
    {
    　　//ScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
    }

    //ボールがターゲットへ衝突した時に呼ばれる関数
    private void OnCollisionEnter(Collision collision)
    {
        //ボールがSmallStarへ衝突した時に10点を加算
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        //ボールがLargeStarへ衝突した時に20点を加算
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
        }
        //ボールがSmallCloudへ衝突した時に15点を加算
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 15;
        }
        //ボールがLargeCloudへ衝突した時に30点を加算
        else if (collision.gameObject.tag == "LargeCloudTag")
            this.score += 30;

        //ScoreTextに得点を表示
        this.ScoreText.GetComponent<Text>().text = "Score:" + score;
    }
}
