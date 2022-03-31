using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //cubeの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cubeを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外にでたら破棄する
        if (transform.position.x < this.deadLine) 
        {
            Destroy(gameObject);
        }
    }
}
