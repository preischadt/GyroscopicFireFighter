using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
     public float sensitivity = 10f;
     private Vector2 currentRotation;
    private bool hasGyro;


    void Start(){
        Cursor.visible = false;
    }

     void Update()
     {
         if (!hasGyro)
         {
             currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
             currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
             currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
             Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
             if (Input.GetMouseButtonDown(0))
                 Cursor.lockState = CursorLockMode.Locked;
         }
     }
}
