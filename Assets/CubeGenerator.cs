using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    //CubeのPrefab
    public GameObject cubePrefab;

    //時間計測用の変数
    private float delta = 0;

    //Cubeの生成時間
    private float span = 1.0f;

    //Cubeの生成位置:X座標
    private float genPosX = 12;

    //Cubeの生成位置オフセット:X
    private float offsetY = 0.3f;

    //Cubeの縦方向の間隔
    private float spaceY = 6.9f;

    //Cubeの生成位置オフセット:Y
    private float offsetX = 0.5f;

    //Cubeの横方向の間隔
    private float spaceX = 0.4f;

    //Cubeの生成個数の上限
    private int maxBlockNum = 4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        //span秒以上の時間が経過したかを調べる
        if (this.delta > this.span)
        {
            this.delta = 0;

            //生成するCube数をランダムに決める
            int n = Random.Range(1, maxBlockNum + 1);

            //指定した数だけCubeを生成する
            for (int i = 0; i < n; i++)
            {
                //Cubeの生成
                GameObject go = Instantiate(cubePrefab);
                go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
            }
            //次のCubeまでの生成時間を決める
            this.span = this.offsetX + this.spaceX * n;
        }
    }
}
