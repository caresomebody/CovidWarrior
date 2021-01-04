using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaksin : MonoBehaviour
{
    public int vacValue=1;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            Score.instance.ChangeScore(vacValue);
        }
    } 
}
