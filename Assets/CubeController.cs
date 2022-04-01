using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //cube�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;

    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GroundTag"
            ||
            collision.gameObject.tag == "BlockTag") 
        {
            audioSource.Play();
        }
    }
}
