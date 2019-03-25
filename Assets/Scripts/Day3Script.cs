using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3Script : MonoBehaviour {
    public float time;
    public GameObject dad,kid, terri,woman, dadvoice, childv, polv, ambi;
    //public Animation dfd;
    Animator anim, anim1, anim2, anim3;



    // Use this for initialization
    void Start()
    {
        anim = dad.GetComponent<Animator>();
        anim1=kid.GetComponent<Animator>();
        anim2=terri.GetComponent<Animator>();
        anim3 = woman.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float h = time;
        anim.SetFloat("timer", time);
        anim1.SetFloat("timer", time);
        anim2.SetFloat("timer", time);
        anim3.SetFloat("timer", time);

        if (time > 10)
        {
            //anim.SetBool("loopOnce", true);

            dadvoice.SetActive(true);

        }
        if (time > 29)
        {
            childv.SetActive(true);
        }

        if (time > 50)
        {
            polv.SetActive(true);
        }
        if(time > 54)
        {
            ambi.SetActive(false);
        }

    }
}