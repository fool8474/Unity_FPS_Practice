using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotRayCast : MonoBehaviour
{
    public GameObject shotEffect;

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

        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {
            Instantiate(shotEffect, hit.transform.position, Quaternion.identity);
        }
    }
}
