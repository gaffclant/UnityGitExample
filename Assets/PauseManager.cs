using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    bool paused = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            paused = !paused;
            Debug.Log("Paused");
            if (paused) {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                GetComponent<Renderer>().enabled = true;
                return;
            }
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
            GetComponent<Renderer>().enabled = false;
        }
    }
}
