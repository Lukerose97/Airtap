using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinNoteMove : MonoBehaviour
{
    //Average beat tempo of a song
    public float beatTempo;
    //If the game has started
    public bool hasStarted;

    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
             if (Input.anyKeyDown)
             {
                 hasStarted = true;
             }
        }
        else
        {
            //move along the z axis
            transform.position -= new Vector3(0f, 0f, beatTempo * Time.deltaTime);
        }
    }
}
