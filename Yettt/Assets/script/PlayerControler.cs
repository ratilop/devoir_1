using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public Animator anim;
    public AudioSource music;
    public Camera personne1;
    public Camera personne3;
   
    private Rigidbody rb;
    public int Score = 0;
    public int angleTournage=0;



    void Start()
    {
        anim = GetComponent<Animator>();
       
      
        rb = GetComponent<Rigidbody>();
        music.Pause();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (moveHorizontal != 0f || moveVertical != 0)
        {
            if (anim.GetBool("marche") == false)
            {
                music.Play();
            }

            anim.SetBool("marche", true);
            
        }
        else
        {
            if (anim.GetBool("marche") == true)
            {
                music.Pause();
            }
            anim.SetBool("marche", false);
            
        }




        if (Input.GetKeyDown("a"))
        {
            gameObject.transform.Rotate(0, -angleTournage, 0);
        }

        if (Input.GetKeyUp("a"))
        {
            gameObject.transform.Rotate(0, angleTournage, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            gameObject.transform.Rotate(0, angleTournage, 0);
        }

        if (Input.GetKeyUp("d"))
        {
            gameObject.transform.Rotate(0, -angleTournage, 0);
        }

        

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Pick Up")
        {
        
            other.gameObject.tag = "Null";
            Score = Score + 1;

        }

    }
}
