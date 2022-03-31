using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    //�Q�[���I�[�o�[�e�L�X�g
    private GameObject gameOverText;

    //���s�����e�L�X�g
    private GameObject runLengthText;

    //����������
    private float len = 0;

    //���鑬�x
    private float speed = 5f;

    //�Q�[���I�[�o�[�̔���
    private bool isGameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //�V�[���r���[����I�u�W�F�N�g�̎��Ԃ���������
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.isGameOver == false)
        {
            //�������������X�V����
            this.len += this.speed * Time.deltaTime;

            //������������\������
            this.runLengthText.GetComponent<Text>().text = "Distance: " + len.ToString("F2") + "m";
        }
        if (this.isGameOver == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    public void GameOver()
    {
        //�Q�[���I�[�o�[�ɂȂ����Ƃ��A��ʏ�ɃQ�[���I�[�o�[��\������
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
