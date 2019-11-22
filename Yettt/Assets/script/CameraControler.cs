﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform target;
    public Animator player;
    public float pitch = 2f;
    public Vector3 offset;
   
    private float yawspeed = 50.0f;
    public float currentyaw;
    public GameObject ccamera;

    private void Start()
    {
        
    }


    void Update()
    {
        if (player.GetBool("animer") == false)
        {
            player.SetBool("animer", true);

        }
        
       if (Input.GetKeyDown("a"))
        {
            currentyaw = -90;
        }
        if (Input.GetKeyDown("w"))
        {
            currentyaw = 0;
        }
        if (Input.GetKeyDown("s"))
        {
            currentyaw = 180;
        }
        if (Input.GetKeyDown("d"))
        {
            currentyaw = 90;

            
        }
    }

    void LateUpdate()
    {

        transform.position = target.position - offset;
        transform.LookAt(target.transform.position + Vector3.up /* pitch*/);
        transform.RotateAround(target.position, Vector3.up, currentyaw);
    }
}
