using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 플레이어 이동
    [SerializeField] private float speed = 5.0f;

    // 점프
    [SerializeField] private float jumpPower = 10.0f;

    // 중력
    [SerializeField] private float gravity = 9.8f;

    // 기본 이동
    private Vector3 moveDirection;

    // 컴포넌트
    CharacterController characterController; // 캐릭터 컨트롤러 컴포넌트


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        moveDirection = Vector3.zero;
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed; 
            if (Input.GetButton("Jump")) moveDirection.y = jumpPower;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
