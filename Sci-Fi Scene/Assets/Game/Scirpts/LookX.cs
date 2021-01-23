using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField]
    private float _sensetivity = 1.005f;
    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");
        
        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += _mouseX * _sensetivity;
        transform.localEulerAngles = newRotation;
    }
}
