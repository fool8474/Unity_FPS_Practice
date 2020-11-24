﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance;

    public float axisPower;

    private Vector3 prevMousePosition;
    private Vector2 mouseAxis; public Vector2 MouseAxis { get { return mouseAxis; } }

    private void Awake()

    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            DestroyImmediate(this.gameObject);
        }
    }

    void Start()
    {
        prevMousePosition = Input.mousePosition;
    }

    void Update()
    {
        Debug.Log(Input.GetAxis("Mouse X") + " " + Input.GetAxis("Mouse Y"));

        SetMousePos();
    }

    public void SetMousePos()
    {
        mouseAxis = Input.mousePosition - prevMousePosition;
        prevMousePosition = Input.mousePosition;
        mouseAxis.x = mouseAxis.x / Screen.currentResolution.width;
        mouseAxis.y = mouseAxis.y / Screen.currentResolution.height;
        mouseAxis *= axisPower;
    }
}
