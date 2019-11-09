using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour
{
    public Animator Gemm;
    public int compteur;
    public AudioSource son;


    // Start is called before the first frame update
    void Start()
    {
        Gemm = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Gemm.GetBool("Destruct"))
        {

            if (compteur == 0)
            {
                this.gameObject.SetActive(false);
                
            }
            else
                compteur--;

        }



    }

    void OnTriggerEnter(Collider other)
    {
        
        Gemm.SetBool("Destruct", true);
        son.Play();
    }
 }
