using UnityEngine;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples
{
    // This script is a simple example of how an interactive item can
    // be used to change things on gameobjects by handling events.
    public class ExampleInteractiveItem : MonoBehaviour
    {
        [SerializeField] private Material m_NormalMaterial;                
        [SerializeField] private Material m_OverMaterial;                  
        [SerializeField] private Material m_ClickedMaterial;               
        [SerializeField] private Material m_DoubleClickedMaterial;         
        [SerializeField] private VRInteractiveItem m_InteractiveItem;
        [SerializeField] private Renderer m_Renderer;
        [SerializeField] public float triggerDelay = 3f;


        Color colorStart = Color.red;
        Color colorEnd = Color.green;
        float duration = 1.0f;
        Renderer rend;

        AudioSource interactSound;


        void Start()
        {
            interactSound = GetComponent<AudioSource>();

        }

        private void Awake ()
        {
           // m_Renderer.material = m_NormalMaterial;
        }


        private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
            m_InteractiveItem.OnClick += HandleClick;
            m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
        }


        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
            m_InteractiveItem.OnClick -= HandleClick;
            m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
        }



        //Handle the Over event
        private void HandleOver()
        {
            // called when HMD hovers over object
            Debug.Log("Show over state");

            //Invoke("playAudio", triggerDelay);
           // m_Renderer.material = m_OverMaterial;
            interactSound.Play(0);
            //Debug.Log("Hit");
            //float lerp = Mathf.PingPong(Time.time, duration) / duration;
            // m_Renderer.material.color = Color.Lerp(colorStart, colorEnd, lerp);
        }

        void playAudio() {
            interactSound.Play(0);
        }

        //Handle the Out event
        private void HandleOut()
        {
            Debug.Log("Show out state");
          //  m_Renderer.material = m_NormalMaterial;
        }


        //Handle the Click event
        private void HandleClick()
        {
            Debug.Log("Show click state");
            m_Renderer.material = m_ClickedMaterial;
        }


        //Handle the DoubleClick event
        private void HandleDoubleClick()
        {
            Debug.Log("Show double click");
            m_Renderer.material = m_DoubleClickedMaterial;
        }
    }

}