using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 플레이어 이동
    public float speed = 5.0f;
    CharacterController cc; // 캐릭터 컨트롤러 컴포넌트

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();    
    }

    private void Move()
    {
        // 플레이어 이동
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize(); // 대각선 이동 속도를 상하좌우와 동일하게 만들기.
        //transform.Translate(dir * speed * Time.deltaTime);

        // 카메라가 보는 방향으로 이동하도록
        dir = Camera.main.transform.TransformDirection(dir);
        cc.Move(dir * speed * Time.deltaTime);
        //transform.Translate(dir * speed * Time.deltaTime);
    }
}
