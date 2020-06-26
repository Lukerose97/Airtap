using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //varibale for the audio
    public AudioSource music;

    //bool for to check if audio is playing
    public bool playing;

    //reference to moving object script
    public MovingObjects moveObjects;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!playing)
        {
            if (Input.anyKeyDown)
            {
                playing = true;
                moveObjects.hasStarted = true;

                music.Play();
            }
        }
    }

}
