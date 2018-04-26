using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour {


    public float speed = 3.5f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            float _speed = speed;

            // SINGLE AXIS 

            //transform.LookAt(transform);
            //transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X")*_speed);


            // DOUBLE AXIS


            #if !UNITY_EDITOR && !UNITY_STANDALONE
                _speed = speed * 0.4f;
            #endif

            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * _speed, -Input.GetAxis("Mouse X") * _speed, 0));
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);

        }
    }

}

