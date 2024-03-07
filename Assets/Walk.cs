using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float grav = 10.0f;
    bool floor = false;
    float yvec = 0;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rigidBody = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter() {
        floor = true;
        yvec = 0;
        Debug.Log("Floor");
    }

    void OnTriggerExit() {
        floor = false;
    }


    // Update is called once per frame
    void Update()
    {
        float x = 0;
        float z = 0;
        if (Input.GetKeyDown(KeyCode.Space) && floor)
        {
            yvec = .1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            z++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x--;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x++;
        }

        transform.position += transform.forward * Time.deltaTime * z * 10;
        transform.position += transform.right * Time.deltaTime * x * 10;
        if (!floor) {
            yvec -= grav*Time.deltaTime*.01f;
        }
        transform.position += transform.up * yvec;


        float h = 2.0f * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);

        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
