using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Level 1");
    }

    public void PlayAgain(){
        SceneManager.LoadScene("Level 1");
    }

    public void Tutorial(){
        SceneManager.LoadScene("Tutorial 1");
    }

    public void GoToMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame(){
        Application.Quit();
    }

}
