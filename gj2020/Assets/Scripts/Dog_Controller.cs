using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Controller : MonoBehaviour
{

    public float rot_speed;
    void Start() {
        
    }

    void Update() {
        float dir = Input.GetAxis("Vertical");
        aim(dir);
    }

    void aim(float v_dir) {
        if (Input.GetButton("Vertical")) {
            transform.Rotate(new Vector3(0, 0, v_dir) * rot_speed * Time.deltaTime);
            Debug.Log("press");
        }   
    }
}
