using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Play Global
    private static BackGroundAudio instance = null;
    public static BackGroundAudio Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        //stop automatic destroy when scene is loaded
        DontDestroyOnLoad(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
