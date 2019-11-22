using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public Animator anim;
    public AudioSource music;
    public GameObject personne1;
    public GameObject personne3;
    public GameObject Model3D;

    private Rigidbody rb;
    public int Score = 0;
    



    void Start()
    {
        anim = GetComponent<Animator>();

        Model3D = GetComponent<GameObject>();

        rb = GetComponent<Rigidbody>();
        music.Pause();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.rotation = Quaternion.LookRotation(movement);

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

        if (Input.GetKeyDown("e"))
        {
            if (personne1.activeSelf)
            {
                personne3.SetActive(true);
                personne1.SetActive(false);
            }
            else
            {
                personne1.SetActive(true);
                personne3.SetActive(false);
            }
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
