using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //cube‚ÌˆÚ“®‘¬“x
    private float speed = -12;

    //Á–ÅˆÊ’u
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cube‚ğˆÚ“®‚³‚¹‚é
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //‰æ–ÊŠO‚É‚Å‚½‚ç”jŠü‚·‚é
        if (transform.position.x < this.deadLine) 
        {
            Destroy(gameObject);
        }
    }
}
