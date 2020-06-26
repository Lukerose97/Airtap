using UnityEngine;
using UnityEngine.UI;

public class DestroyMovingObjects : MonoBehaviour {

    //bool to check button press for testing
    public bool canBePressed = false;

    //bool to check button press for testing
    public bool handCollision = false;

    //Varibale to hold the key to be hit when playing the game
    public KeyCode key;

    //Game manager object
    GameObject gm;

    //Note gameObject
    GameObject note;

    //public variable for moving objects
    public GameObject movingSphere;

    //Initialization
    void Start()
    {
        gm = GameObject.Find("ExitKillZone");
    }

    void Update()
    {
        if (canBePressed && Input.GetKeyDown(key))
        {
            Destroy(note);
            gm.GetComponent<GameManager2>().addStreak();
            addScore();
            canBePressed = false;
        }
        else if(canBePressed && handCollision)
        {
            Destroy(note);
            gm.GetComponent<GameManager2>().addStreak();
            addScore();
            canBePressed = false;
        }
    }

    void addScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + gm.GetComponent<GameManager2>().getScore());
    }

    //on enter other becomes true
    private void OnTriggerEnter(Collider other)
    {
        //win note collision
        if (other.gameObject.tag == "WinNote")
        {
            gm.GetComponent<GameManager2>().Win();
        }
        //moving note collision
        if (other.tag == "CollisionCubes")
        {
            note = other.gameObject;
            canBePressed = true;
        }
        //hand collision
        else if (other.tag == "hands")
        {
            note = other.gameObject;
            handCollision = true;
        }
    }

    //on enter other becomes false
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CollisionCubes")
        {
            canBePressed = false;
            gm.GetComponent<GameManager2>().ResetStreak();
        }
        else if (other.tag == "hands")
        {
            note = other.gameObject;
            handCollision = true;
        }
    }

}
