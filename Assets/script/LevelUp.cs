using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelUp : MonoBehaviour
{
    // Start is called before the first frame update
     public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void Replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    // Update is called once per frame
     public void GoToMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
