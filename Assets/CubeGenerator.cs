using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    //Cube��Prefab
    public GameObject cubePrefab;

    //���Ԍv���p�̕ϐ�
    private float delta = 0;

    //Cube�̐�������
    private float span = 1.0f;

    //Cube�̐����ʒu:X���W
    private float genPosX = 12;

    //Cube�̐����ʒu�I�t�Z�b�g:X
    private float offsetY = 0.3f;

    //Cube�̏c�����̊Ԋu
    private float spaceY = 6.9f;

    //Cube�̐����ʒu�I�t�Z�b�g:Y
    private float offsetX = 0.5f;

    //Cube�̉������̊Ԋu
    private float spaceX = 0.4f;

    //Cube�̐������̏��
    private int maxBlockNum = 4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        //span�b�ȏ�̎��Ԃ��o�߂������𒲂ׂ�
        if (this.delta > this.span)
        {
            this.delta = 0;

            //��������Cube���������_���Ɍ��߂�
            int n = Random.Range(1, maxBlockNum + 1);

            //�w�肵��������Cube�𐶐�����
            for (int i = 0; i < n; i++)
            {
                //Cube�̐���
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
            }
            //����Cube�܂ł̐������Ԃ����߂�
            this.span = this.offsetX + this.spaceX * n;
        }
    }
}
