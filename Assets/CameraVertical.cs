using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVertical : MonoBehaviour
{
    float h = 0f;
    float v = 0f;
    // Update is called once per frame
    void Update()
    {
        v += -200.0f * Input.GetAxis("Mouse Y")*Time.deltaTime;
        v = Mathf.Clamp(v, -90, 60);
        h += 200.0f * Input.GetAxis("Mouse X")*Time.deltaTime;
        Quaternion target = Quaternion.Euler(v, h, 0); // any value as you see fit
        transform.rotation = target;
    }
}
