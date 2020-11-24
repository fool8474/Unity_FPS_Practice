using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotRayCast : MonoBehaviour
{
    public GameObject shotEffect;
    public GameObject shotPos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    void Shot()
    {
        RaycastHit hit;
        float distance = 100f;

        if (Physics.Raycast(shotPos.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            Debug.Log("충돌 " + hit.transform.name + " " + hit.point);
            Instantiate(shotEffect, hit.point, Quaternion.identity);
        }
    }
}
