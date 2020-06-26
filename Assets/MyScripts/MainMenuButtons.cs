using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    //Play game button to load the level
    public void PlayGame(string gameLevel)
    {
        SceneManager.LoadScene(gameLevel);
    }
}
