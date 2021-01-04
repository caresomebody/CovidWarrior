using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masker : MonoBehaviour
{
    public int healthBonus=1;
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            if(Hearth.health>0){
            Hearth.health =  Hearth.health + healthBonus;
            }
        }
    } 
}