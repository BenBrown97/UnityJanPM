﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPMJan : MonoBehaviour
{
    public GameObject testGameObject;
    public Transform location;
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        #region Translational movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }

        #endregion

        #region Rotation using mouse

        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * turnSpeed);

        #endregion


        #region Rotation using keyboard
        //if (input.getkey(keycode.e))
        //{
        //    transform.rotate(vector3.up);
        //}
        //if (input.getkey(keycode.q))
        //{
        //    transform.rotate(vector3.down);
        //}
        //if (input.getkey(keycode.u))
        //{
        //    transform.rotate(vector3.right);
        //}
        //if (input.getkey(keycode.n))
        //{
        //    transform.rotate(vector3.left);
        //}
        #endregion


    }

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}