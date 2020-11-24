using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float speed = 150;

    // 회전 각도 직접 제어
    float angleX;

    void Start()
    {
            
    }

    void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        float h = MouseManager.Instance.MouseAxis.x;
        angleX += h * speed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, angleX, 0);
    }
}
