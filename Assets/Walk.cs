using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float grav = 10f;
    bool floor = false;
    float yvec = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerEnter() {
        floor = true;
        yvec = 0;
    }

    void OnTriggerExit() {
        floor = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) return;
        float x = 0;
        float z = 0;
        float h = 0;

        if (!floor) yvec -= grav*.01f*Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && floor) yvec = 10f * Time.deltaTime;
        if (Input.GetKey(KeyCode.W)) z++;
        if (Input.GetKey(KeyCode.A)) x--;
        if (Input.GetKey(KeyCode.S)) z--;
        if (Input.GetKey(KeyCode.D)) x++;

         transform.position +=
                transform.right * Time.deltaTime * x * 10 +
                transform.up * yvec +
                transform.forward * Time.deltaTime * z * 10;

        h = 200.0f * Input.GetAxis("Mouse X") * Time.deltaTime;
        transform.Rotate(0, h, 0);
    }
}
