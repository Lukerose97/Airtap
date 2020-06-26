using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public AudioClip MusicClip; //music file

    public AudioSource MusicSource; //source of music file

    // Use this for initialization
    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }

    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            
    }
    */
}
