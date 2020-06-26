using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandCollisions : MonoBehaviour
{
    //bool to check button press for testing
    public bool handCollision = false;

    //String for game level
    public string gameLevel;

    //on enter other becomes true
    private void OnTriggerEnter(Collider other)
    {
        //moving note collision
        if (other.tag == "hands")
        {
            handCollision = true;
            //Play game button to load the level
                SceneManager.LoadScene(gameLevel);
        }
    }

    //on enter other becomes false
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "hands")
        {
            handCollision = false;
        }
    }
}
