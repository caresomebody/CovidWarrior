using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour{

     public int playerSpeed = 10;
    public bool facingRight = true;
    public int playeJumpPower =1250;
    public float moveX;


    // Update is called once per frame
    void Update(){
        playerMove();
    }

    void playerMove(){
        //controlst
        moveX= Input.GetAxis("Horizontal");
        //animations
        //player direction
        if (moveX < 0.0f && facingRight==false){
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true){
            FlipPlayer();
        }
        //physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump(){

    }

    void FlipPlayer(){

    }
}
