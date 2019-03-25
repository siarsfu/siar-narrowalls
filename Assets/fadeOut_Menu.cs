using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut_Menu : MonoBehaviour {

    public GameObject gameObject_Animation;
    Animator anim;

    // Use this for initialization
    void Start () {
        anim = gameObject_Animation.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("FadeOut", true);

 
    }
}
