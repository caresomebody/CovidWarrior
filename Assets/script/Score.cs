using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI text;
    int score;

    void Start()
    {
        if(instance==null){
            instance=this;
        }
    }

    // Update is called once per frame
    public void ChangeScore(int vacValue)
    {
     score+=vacValue;
     text.text="X" + score.ToString();   
    }
}
