using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitMeter : MonoBehaviour
{
    //variable for the hit meter number
    float hm;

    //reference to game object needle
    GameObject needle;

    // Start is called before the first frame update
    void Start()
    {
        needle = transform.Find("Needle").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        hm = PlayerPrefs.GetInt("HitMeter");

        needle.transform.localPosition = new Vector3((hm-25)/33.333f, 0 , 0);
    }
}
