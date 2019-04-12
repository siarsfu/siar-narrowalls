using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMainScript : MonoBehaviour {

    public GameObject person, p2, p3, p4, p5,p6, cube;

    public float time;


    // Use this for initialization
    void Start () {
        p2.SetActive(true);
        p4.SetActive(true);
        p3.SetActive(true);
        p5.SetActive(true);
        cube.SetActive(true);
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if(time > 25 && time < 26)
        {
            //p2.SetActive(false);
            p4.SetActive(false);
            p3.SetActive(false);
            p5.SetActive(false);
            p6.SetActive(false);
        }

        if(time > 35 && time < 37)
        {
            p2.SetActive(true);
        }

        if(time > 120 && time < 122)
        {
            p3.SetActive(true);
            p6.SetActive(true);
        }

        if (time > 180 && time < 182)
        {
            p5.SetActive(true);

        }

        if (time > 200 && time < 202)
        {
            p4.SetActive(true);
        }

        //285/286
        if (time > 238 && time < 239) 
        {
            person.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
            p5.SetActive(false);
            p6.SetActive(false);
           
        }
    }
}
