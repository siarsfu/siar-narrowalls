using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {
   public GameObject text1;


	// Use this for initialization
	void Start () {
#pragma warning disable CS1718 // Comparison made to same variable
        const string V = "Are you cool?";
       // if (text1 != V)
        {
#pragma warning restore CS1718 // Comparison made to same variable
          
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
