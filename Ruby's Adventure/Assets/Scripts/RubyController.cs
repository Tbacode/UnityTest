using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    // 当游戏开始时，Unity只在start中执行一次代码，且在第一帧更新前调用
    void Start()
    {
        // Application.targetFrameRate = 60; // 固定每秒10帧，影响到update方法的调用次数
    }
    
    // Update is called once per frame
    void Update()
    {
        // 获取用户的监听，水平和垂直方向监听
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // vector2变量类型：一种存储两个数字的数据类型，存储在Inspector面板里关于transform组件中position的x，y值
        Vector2 position = transform.position;
        //position.x = position.x + 0.1f * horizontal*Time.deltaTime; // 按照每秒0.1m速度移动 Time.daltaTiem限制
        //position.y = position.y + 0.1f * vertical;// 每帧0.1m，1秒60帧，按照每秒6m速度移动
        position.x = position.x + 0.025f * horizontal;
        position.y = position.y + 0.025f * vertical;
        transform.position = position;
    }
}
