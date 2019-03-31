using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMainScript : MonoBehaviour {

    public GameObject person, p2, p3, p4, p5;

    public float time;


    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;



        //285/286
        if (time > 285 && time < 286) 
        {
            person.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
            p5.SetActive(false);

           
        }
    }
}
