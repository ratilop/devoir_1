using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    // Start is called before the first frame update
    private float Timer;
    private bool canCount = true;
    private bool doOnce = false;
    void Start()
    {
        Timer = mainTimer;
    }


        // Update is called once per frame
        void Update()
    {
        if(Timer >= 0.0f && canCount)
        {
            Timer -= Time.deltaTime;
            uiText.text = Timer.ToString("F");
        }
        else if(Timer <=0 && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            Timer = 0.0f;

        }
    }
}
