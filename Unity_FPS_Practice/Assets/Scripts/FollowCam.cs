using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public Transform target;
    public Transform target1st;

    public float speed = 10.0f;
    private bool isFPS;

    void Start()
    {
        isFPS = false;
    }

    void Update()
    {
        FollowTarget();  

        // 1인칭 to 3인칭, 3인칭 to 1인칭
        ChangeView();
    }

    private void ChangeView()
    {
        if(Input.GetKeyDown("1"))
        {
            isFPS = true;
        }

        if (Input.GetKeyDown("3"))
        {
            isFPS = false;
        }

        if(isFPS)
        {
            transform.position = target1st.position;
        }

        else
        {
            transform.position = target.position;
        }
    }

    private void FollowTarget()
    {
        // 타겟방향 구하기 (벡터의 뺄셈)
        // 방향 = 타겟 - 자기자신
        Vector3 dir = target.position - transform.position;
        dir.Normalize();
        transform.Translate(dir * speed * Time.deltaTime);

        // Distance()함수 사용 - 벡터 리턴
        // magnitude 속성 사용 - 실수 리턴
        // sqrMagnitude 속성 사용


        // 1
        if(Vector3.Distance(target.position, transform.position) < 1.0f)
        {
            transform.position = target.position;
        }

        // 2
        //float distance = (target.position - transform.position).magnitude;
        //if (distance < 1.0f) transform.position = target.position;

        // 3
        // 성능상 유리하다 - 루트연산을 하지 않음.
        //float distance = (target.position - transform.position).sqrMagnitude;
        //if (distance < 1.0f) transform.position = target.position;
    }
}
