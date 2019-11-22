using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlerFPS : MonoBehaviour
{
    public Transform target;

    public float pitch = 2f;
    public Vector3 offset;
    public Animator player;
    private float yawspeed = 50.0f;
    public float currentyaw;

    private void Start()
    {
        
    }

    void Update()
    {
        //currentyaw -= Input.GetAxis("Horizontal") * yawspeed * Time.fixedDeltaTime;
        if (player.GetBool("animer") == true)
        {
            
            player.SetBool("marche", false);
            player.SetBool("animer", false);

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
        transform.RotateAround(transform.position, Vector3.up, currentyaw);
        
    }
}

