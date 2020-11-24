using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float speed = 150; // 회전속도 ( Time.deltaTime을 통해 1초에 150도 회전)
    float angleX, angleY; // 직접 제어할 회전각도

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        Vector3 dir = new Vector3(v, h, 0);
        //transform.eulerAngles += dir * speed * Time.deltaTime; 

        //Vector3 angle = transform.eulerAngles;
        //angle += dir * speed * Time.deltaTime;

        //if (angle.x > 60) angle.x = 60;
        //if (angle.x < -60) angle.x = -60;
        //transform.eulerAngles = angle;

        angleX += h * speed * Time.deltaTime;
        angleY -= v * speed * Time.deltaTime;
        angleY = Mathf.Clamp(angleY, -60, 60);
        transform.localEulerAngles = new Vector3(angleY, angleX, 0);
    }
}
