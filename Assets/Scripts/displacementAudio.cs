using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displacementAudio : MonoBehaviour {

    public float displacementAmount;
    public ParticleSystem explosionParticles;
    //MeshRenderer meshRenderer;
    SkinnedMeshRenderer meshRenderer;

    //can be accessed publicly
    public static float spectrumValue { get; private set; }

    //hold spectrum data
    private float[] m_audioSpectrum;

    // Use this for initialization
    void Start () {
        meshRenderer = GetComponent<SkinnedMeshRenderer>();

        //initialize spectrum data.
        // this number can 64, 128, 256, 
        m_audioSpectrum = new float[128];

        

	}
	
	// Update is called once per frame
	void Update () {

        //pull data from audio listener
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);

        //check if spectrum data has any data in it
        //if it does, assign generalized spectrum value to the first
        //multiply by 100 to de normalize (arbitrary number, you can use any number really)
        if (m_audioSpectrum != null && m_audioSpectrum.Length > 0) {

            spectrumValue = m_audioSpectrum[0] * 100;
        }

        displacementAmount = Mathf.Lerp(displacementAmount, 0, Time.deltaTime);
        meshRenderer.material.SetFloat("_Amount", displacementAmount);

        if (Input.GetButtonDown("Jump")) {
            displacementAmount += 0.5f;
            explosionParticles.Play();
        }
		
	}
}
