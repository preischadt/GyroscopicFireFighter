using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceRotation : MonoBehaviour
{
    private GameObject camParent;
    private bool hasGyro;
    
    // Start is called before the first frame update
    void Start()
    {
        camParent = new GameObject("CamParent");
        camParent.transform.position = transform.position;
        transform.parent = camParent.transform;
        hasGyro = SystemInfo.supportsGyroscope;
        if (hasGyro)
        {
            Input.gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasGyro)
        {
            camParent.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
            transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0);
        }
    }
}
