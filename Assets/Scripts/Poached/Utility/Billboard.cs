using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Billboard : MonoBehaviour
{
    [SerializeField] private bool isEnabled = true;
    
    private Transform cam;

    private void Awake()
    {
        if (Camera.main != null) cam = Camera.main.transform;
    }

    private void LateUpdate()
    {
        if (!isEnabled) return;
        transform.LookAt(cam);
        transform.Rotate(0, 180, 0);
    }
}