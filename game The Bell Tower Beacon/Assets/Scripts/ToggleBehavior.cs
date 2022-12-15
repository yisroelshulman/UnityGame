using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ToggleBehavior : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    public void SetVolume() {
        mixer.SetFloat("volume", volumeSlider.value);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
