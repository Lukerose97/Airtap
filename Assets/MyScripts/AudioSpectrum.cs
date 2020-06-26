using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{
    public static float spectrumValue { get; private set; }

    private float[] audioSpectrum;

    // Update is called once per frame
    private void Update()
    {
        AudioListener.GetSpectrumData(audioSpectrum, 0, FFTWindow.Hamming);
        if(audioSpectrum != null && audioSpectrum.Length > 0)
        {
            spectrumValue = audioSpectrum[0] * 100;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        audioSpectrum = new float[128];
    }

    
}
