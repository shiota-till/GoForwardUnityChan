using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //cube�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cube���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɂł���j������
        if (transform.position.x < this.deadLine) 
        {
            Destroy(gameObject);
        }
    }
}
