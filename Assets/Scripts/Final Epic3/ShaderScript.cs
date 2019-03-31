using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour {

    public Material myMaterial;
    public GameObject black;
    public float time;
    float v, rate;
    Color c, orig;
    // Use this for initialization
    void Start () {
        v = 0;
        c = new Color(191, 0, 130);
        orig = new Color(0, 90, 112);
        myMaterial.SetFloat("Vector1_A833BAAD", v);
        rate = 0.001f;
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        v += rate;
        

        //To change Properties on Shaders the name isn't what you call it, it's what unity calls it in its properties
        myMaterial.SetFloat("Vector1_A833BAAD", v);
        if(time > 5 && time < 8)
        {
            // myMaterial.SetColor("Color_D4D07BAB",c);

        }
        else
        {
            myMaterial.SetColor("Color_D4D07BAB", orig);

        }

        if (time > 290 && time <291)
        {
            Color white = black.GetComponent<MeshRenderer>().material.color;
            white.r = 255;
            white.g = 255;
            white.b = 255;

            black.GetComponent<MeshRenderer>().material.color = white;
            black.GetComponent<Black_Screen_Script>().fadeIn();

        }
        /*
        if (time >15 &&time < 16)
        {
        //Testing
        }
        */
        if (time > 283)
        {
           // rate = rate * rate;
            v += rate;
        }

       

          else if (v > 0.06 || v < -0.20)
        {
            rate = -rate;

        }
        v += rate;



    }
}
