using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour {

    public Material myMaterial, hollow, h2,h3,h4,h5,h6;
    public GameObject black;
    public float time;
    float v, rate, noise,nr,newR;
    Color c, orig;
    bool effect=false;

    // Use this for initialization
    void Start () {
        v = 0;
        c = new Color(191, 0, 130);
        orig = myMaterial.color;
        myMaterial.SetFloat("Vector1_A833BAAD", v);
        myMaterial.SetFloat("Vector1_B1098557", 0);
        rate = 0.001f;
        noise = 2.5f;
        nr = .00025f;
        
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        noise += nr;
        v += rate;


        myMaterial.SetFloat("Vector1_B1098557", noise);
        hollow.SetFloat("_Alpha", v);

        //To change Properties on Shaders the name isn't what you call it, it's what unity calls it in its properties
        myMaterial.SetFloat("Vector1_A833BAAD", v);
        if(time > 5 && time < 8)
        {
            // myMaterial.SetColor("Color_D4D07BAB",c);

        }
        else
        {
            //myMaterial.SetColor("Color_D4D07BAB", orig);

        }


        if (time > 24)
        {
            h6.SetFloat("_Alpha", v);
        }

        
        if (time > 30)
        {
            h5.SetFloat("_Alpha", v);
            

        }
        if (time > 45)
        {
            hollow.SetFloat("_Alpha", v + .08f);
        }
        if (time > 60)
        {
            h4.SetFloat("_Alpha", v);

        }
        if (time > 120)
        {
            h3.SetFloat("_Alpha", nr);

        }
        if (time > 180)
        {
            h2.SetFloat("_Alpha", nr);

        }

        if (time > 290 && time <291)
        {
            Color white = black.GetComponent<MeshRenderer>().material.color;
            white.r = 255;
            white.g = 255;
            white.b = 255;

            black.GetComponent<MeshRenderer>().material.color = white;

        }

        if(time > 293 && time < 294)
        {
            black.GetComponent<Black_Screen_Script>().fadeIn();

        }



        /*
        if (time >15 &&time < 16)
        {
        //Testing
        }
        */





        if (time > 15 && effect == false)
            {
            // rate = rate * rate;
            if (rate < 0)
            {
                rate = -rate;
            }
            v += rate;
              
            Debug.Log("DISSOLVE");
            if (time > 23)
            {
                  effect = true;
                noise = 0;
                v = 0;
            }

        }

            else if ((v > 0.06 || v < -0.20)&&effect==false)
            {
                rate = -rate;

            }
            v += rate;

        if (effect)
        {
            if (time > 287)
            {
                // rate = rate * rate;
                if (rate < 0)
                {
                    rate = -rate;
                }
                v += rate;
            }

            else if (v > 0.06 || v < -0.20)
            {
                rate = -rate;

            }
            v += rate;
        }


    }
}
