using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //���_��0�ŏ�����
    private int score = 0;

    //���_��\������e�L�X�g
    private GameObject ScoreText;

    // Start is called before the first frame update
    void Start()
    {
    �@�@//ScoreText�I�u�W�F�N�g���擾
        this.ScoreText = GameObject.Find("ScoreText");
    }

    //�{�[�����^�[�Q�b�g�֏Փ˂������ɌĂ΂��֐�
    private void OnCollisionEnter(Collision collision)
    {
        //�{�[����SmallStar�֏Փ˂�������10�_�����Z
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        //�{�[����LargeStar�֏Փ˂�������20�_�����Z
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
        }
        //�{�[����SmallCloud�֏Փ˂�������15�_�����Z
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 15;
        }
        //�{�[����LargeCloud�֏Փ˂�������30�_�����Z
        else if (collision.gameObject.tag == "LargeCloudTag")
            this.score += 30;

        //ScoreText�ɓ��_��\��
        this.ScoreText.GetComponent<Text>().text = "Score:" + score;
    }
}
