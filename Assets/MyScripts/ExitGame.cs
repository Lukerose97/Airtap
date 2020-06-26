using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Exit Game
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
