using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    //C#不在意裡面有多少空格
     {
        Debug.Log("撞到了");
    }
}
